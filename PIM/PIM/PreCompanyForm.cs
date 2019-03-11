using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace PIM
{
    public partial class PreCompanyForm : Form
    {
        private int empn;
        private string name;
        private MainForm mainForm = new MainForm();
        public PreCompanyForm()
        {
            InitializeComponent();
        }
        public PreCompanyForm(int empn, string name)
        {
            InitializeComponent();
            this.empn = empn;
            this.name = name;
        }

        private string connectionString = "provider=Microsoft.JET.OLEDB.4.0;"
                                        + "data source = "
                                        + Application.StartupPath
                                        + @"..\..\..\pim.mdb";

        private OleDbCommand myCommand = new OleDbCommand();

        private void PreCompany_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection myConnection = new OleDbConnection(connectionString);
                string commandString = "select * from pre_company where emp_num=" + this.empn;

                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();
                OleDbDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (empn != 0)
                    txtEmp_num.Text = empn.ToString();
                txtName.Text = name;

                dgvPreCompany.Rows.Clear();
                dgv(myReader);
                myConnection.Close();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }


        private void btnInsert_Click(object sender, EventArgs e)
        {
            mainForm.ok = true;
            try
            {
                OleDbConnection myConnection = new OleDbConnection(connectionString);

                string commandString = "select * from pre_company where emp_num=" + this.empn;
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = myCommand;

                OleDbCommandBuilder myCommandBuilder = new OleDbCommandBuilder(DBAdapter);

                DataSet DS = new DataSet();

                DBAdapter.Fill(DS, "pre_company");

                DataTable pre_companyTable = DS.Tables["pre_company"];
                DataRow newRow = pre_companyTable.NewRow();

                if (txtEmp_num.Text == "")
                {
                    MessageBox.Show("사번을 입력해 주십시오.", "인사정보관리", MessageBoxButtons.OK);
                    clear();
                    myConnection.Close();
                    return;
                }

                string jday = txtJoinDay.Text;
                string rday = txtResignDay.Text;
                if ((jday.Length != 8) || (rday.Length != 8))
                {
                    MessageBox.Show("입사일 및 퇴사일은 8자리 숫자만 입력해 주십시오.\nex) 20181225", "인사정보관리", MessageBoxButtons.OK);
                    txtJoinDay.Text = "";
                    txtResignDay.Text = "";
                    myConnection.Close();
                    return;
                }
                newRow["emp_num"] = mainForm.num(txtEmp_num);
                newRow["emp_name"] = txtName.Text;
                newRow["join_day1"] = jday.Substring(0, 4);
                newRow["join_day2"] = jday.Substring(4, 2);
                newRow["join_day3"] = jday.Substring(6, 2);
                newRow["resign_day1"] = rday.Substring(0, 4);
                newRow["resign_day2"] = rday.Substring(4, 2);
                newRow["resign_day3"] = rday.Substring(6, 2);
                newRow["jobrank"] = cmbJobRank.Text;
                newRow["duty"] = txtDuty.Text;
                newRow["company"] = txtCompany.Text;
                if (mainForm.ok == true)
                {
                    pre_companyTable.Rows.Add(newRow);

                    DBAdapter.Update(DS, "pre_company");
                }
                else
                {
                    myConnection.Close();
                    return;
                }
                MessageBox.Show("입력되었습니다.", "인사정보관리", MessageBoxButtons.OK);

                clear();

                OleDbDataReader myReader = myCommand.ExecuteReader();

                dgvPreCompany.Rows.Clear();
                dgv(myReader);

                myConnection.Close();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEmp_num.Text == "")
                {
                    MessageBox.Show("사번을 입력해 주십시오.", "인사정보관리", MessageBoxButtons.OK);
                    clear();
                    return;
                }
                OleDbConnection myConnection = new OleDbConnection(connectionString);
                string commandString = "select * from pre_company where emp_num=" + txtEmp_num.Text;

                empn = mainForm.num(txtEmp_num);
                name = txtName.Text;

                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();
                OleDbDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (empn != 0)
                    txtEmp_num.Text = empn.ToString();
                txtName.Text = name;

                dgvPreCompany.Rows.Clear();
                dgv(myReader);
                myConnection.Close();
                if (dgvPreCompany.Rows.Count == 0)
                {
                    MessageBox.Show("내용이 없습니다.", "인사정보관리", MessageBoxButtons.OK);
                    clear();
                    return;
                }
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mainForm.ok = true;
            try
            {
                OleDbConnection myConnection = new OleDbConnection(connectionString);
                string commandString = "select * from pre_company where emp_num=" + this.empn;
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = myCommand;

                OleDbCommandBuilder myCommandBuilder = new OleDbCommandBuilder(DBAdapter);
                DataSet DS = new DataSet("pre_company");

                DBAdapter.Fill(DS, "pre_company");

                DataTable pre_companyTable = DS.Tables["pre_company"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = pre_companyTable.Columns["id"];
                pre_companyTable.PrimaryKey = PrimaryKey;

                DataRow currRow = pre_companyTable.Rows.Find(SelectedRowIndex);

                string jday = txtJoinDay.Text;
                string rday = txtResignDay.Text;
                if ((jday.Length != 8) || (rday.Length != 8))
                {
                    MessageBox.Show("입사일 및 퇴사일은 8자리 숫자만 입력해 주십시오.\nex) 20181225", "인사정보관리", MessageBoxButtons.OK);
                    txtJoinDay.Text = "";
                    txtResignDay.Text = "";
                    myConnection.Close();
                    return;
                }
                currRow.BeginEdit();
                currRow["join_day1"] = jday.Substring(0, 4);
                currRow["join_day2"] = jday.Substring(4, 2);
                currRow["join_day3"] = jday.Substring(6, 2);
                currRow["resign_day1"] = rday.Substring(0, 4);
                currRow["resign_day2"] = rday.Substring(4, 2);
                currRow["resign_day3"] = rday.Substring(6, 2);
                currRow["jobrank"] = cmbJobRank.Text;
                currRow["duty"] = txtDuty.Text;
                currRow["company"] = txtCompany.Text;
                currRow.EndEdit();
                if (mainForm.ok == true)
                {
                    DataSet UpdatedSet = DS.GetChanges(DataRowState.Modified);

                    DBAdapter.Update(UpdatedSet, "pre_company");
                    DS.AcceptChanges();
                }
                else
                {
                    myConnection.Close();
                    return;
                }

                OleDbDataReader myReader;
                myReader = myCommand.ExecuteReader();

                dgvPreCompany.Rows.Clear();
                dgv(myReader);
                MessageBox.Show("수정되었습니다.", "인사정보관리", MessageBoxButtons.OK);
                clear();
                myConnection.Close();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection myConnection = new OleDbConnection(connectionString);

                string commandString = "select * from pre_company where emp_num=" + this.empn;
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = myCommand;

                OleDbCommandBuilder myCommandBuilder = new OleDbCommandBuilder(DBAdapter);

                DataSet DS = new DataSet();

                DBAdapter.Fill(DS, "pre_company");

                DataTable pre_companyTable = DS.Tables["pre_company"];

                DataRow[] empRow = pre_companyTable.Select("emp_num = '" + txtEmp_num.Text + "'");
                if (MessageBox.Show(this, "삭제하시겠습니까?", "인사정보관리", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    empRow[0].Delete();

                    DBAdapter.Update(DS.GetChanges(DataRowState.Deleted), "pre_company");
                    MessageBox.Show("삭제되었습니다.", "인사정보관리", MessageBoxButtons.OK);

                    clear();
                }
                else
                {
                    MessageBox.Show("삭제 작업이 취소되었습니다.", "인사정보관리", MessageBoxButtons.OK);

                    clear();
                }

                OleDbDataReader myReader;
                myReader = myCommand.ExecuteReader();

                dgvPreCompany.Rows.Clear();
                dgv(myReader);

                myConnection.Close();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvPreCompany_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string commandString = "select * from pre_company where emp_num=" + this.empn;

            OleDbDataAdapter DBAdapter = new OleDbDataAdapter(commandString, connectionString);

            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "pre_company");

            DataTable pre_companyTable = DS.Tables["pre_company"];

            DataRow currRow = pre_companyTable.Rows[e.RowIndex];
            txtJoinDay.Text = currRow["join_day1"].ToString() + currRow["join_day2"].ToString() + currRow["join_day3"].ToString();
            txtResignDay.Text = currRow["resign_day1"].ToString() + currRow["resign_day2"].ToString() + currRow["resign_day3"].ToString();
            cmbJobRank.Text = currRow["jobrank"].ToString();
            txtDuty.Text = currRow["duty"].ToString();
            txtCompany.Text = currRow["company"].ToString();

            SelectedRowIndex = (int)currRow["id"];
        }

        private void PreCompanyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private int SelectedRowIndex;
        public void clear()
        {
            foreach (Control ctl in this.Controls)
            {
                if (typeof(System.Windows.Forms.TextBox) == ctl.GetType())
                {
                    ctl.Text = null;
                    ctl.BackColor = Color.White;
                }
                if (typeof(System.Windows.Forms.ComboBox) == ctl.GetType())
                {
                    ctl.Text = null;
                    ctl.BackColor = Color.White;
                }
            }
        }
        private void dgv(OleDbDataReader myReader)
        {
            int i = 0;
            while (myReader.Read())
            {
                dgvPreCompany.Rows.Add();
                txtName.Text = myReader.GetString(2);
                dgvPreCompany["Col1", i].Value = i + 1;
                dgvPreCompany["Col4", i].Value = myReader.GetInt32(3).ToString("0000") + "/" + myReader.GetInt32(4).ToString("00") + "/" + myReader.GetInt32(5).ToString("00");
                dgvPreCompany["Col4", i].Value = myReader.GetInt32(6).ToString("0000") + "/" + myReader.GetInt32(7).ToString("00") + "/" + myReader.GetInt32(8).ToString("00");
                dgvPreCompany["Col5", i].Value = myReader.GetString(9);
                dgvPreCompany["Col2", i].Value = myReader.GetString(10);
                dgvPreCompany["Col3", i].Value = myReader.GetString(11);

                i++;

            }
            myReader.Close();
        }
    }
}
