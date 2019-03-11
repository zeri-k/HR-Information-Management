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
    public partial class LicenceForm : Form
    {
        private int empn;
        private string name;
        private MainForm mainForm = new MainForm();
        public LicenceForm()
        {
            InitializeComponent();
        }
        public LicenceForm(int empn, string name)
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
        private void LicenceForm_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection myConnection = new OleDbConnection(connectionString);
                string commandString = "select * from licence where emp_num=" + this.empn;

                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();
                OleDbDataReader myReader;
                myReader = myCommand.ExecuteReader();

                if (empn != 0)
                    txtEmp_num.Text = empn.ToString();
                txtName.Text = name;

                dgvLicence.Rows.Clear();
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

                string commandString = "select * from licence where emp_num=" + this.empn;
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = myCommand;

                OleDbCommandBuilder myCommandBuilder = new OleDbCommandBuilder(DBAdapter);

                DataSet DS = new DataSet();

                DBAdapter.Fill(DS, "licence");

                DataTable licenceTable = DS.Tables["licence"];
                DataRow newRow = licenceTable.NewRow();

                if (txtEmp_num.Text == "")
                {
                    MessageBox.Show("사번을 입력해 주십시오.", "인사정보관리", MessageBoxButtons.OK);
                    clear();
                    myConnection.Close();
                    return;
                }
                
                string day = txtDay.Text;
                if (day.Length != 8)
                {
                    MessageBox.Show("취득일자는 8자리 숫자만 입력해 주십시오.\nex) 20181225", "인사정보관리", MessageBoxButtons.OK);
                    txtDay.Text = "";
                    myConnection.Close();
                    return;
                }
                newRow["emp_num"] = mainForm.num(txtEmp_num);
                newRow["emp_name"] = txtName.Text;
                newRow["licence_n"] = txtLicenceN.Text;
                newRow["licence_rank"] = txtJobRank.Text;
                newRow["day1"] = day.Substring(0, 4);
                newRow["day2"] = day.Substring(4, 2);
                newRow["day3"] = day.Substring(6, 2);
                newRow["publish"] = txtPublish.Text;
                if (mainForm.ok == true)
                {
                    licenceTable.Rows.Add(newRow);

                    DBAdapter.Update(DS, "licence");
                }
                else
                {
                    myConnection.Close();
                    return;
                }

                MessageBox.Show("입력되었습니다.", "인사정보관리", MessageBoxButtons.OK);

                clear();

                OleDbDataReader myReader = myCommand.ExecuteReader();

                dgvLicence.Rows.Clear();
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
        private void dgv(OleDbDataReader myReader)
        {
            int i = 0;
            while (myReader.Read())
            {
                dgvLicence.Rows.Add();
                txtName.Text = myReader.GetString(2);
                dgvLicence["Col1", i].Value = i + 1;
                dgvLicence["Col2", i].Value = myReader.GetString(3);
                dgvLicence["Col3", i].Value = myReader.GetString(4);
                dgvLicence["Col4", i].Value = myReader.GetInt32(5).ToString("0000") + "/" + myReader.GetInt32(6).ToString("00") + "/" + myReader.GetInt32(7).ToString("00");
                dgvLicence["Col5", i].Value = myReader.GetString(8);

                i++;

            }
            myReader.Close();
        }
        private int SelectedRowIndex;

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
                string commandString = "select * from licence where emp_num=" + txtEmp_num.Text;

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

                dgvLicence.Rows.Clear();
                dgv(myReader);
                myConnection.Close();
                if (dgvLicence.Rows.Count == 0)
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
                string commandString = "select * from licence where emp_num=" + this.empn;
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = myCommand;

                OleDbCommandBuilder myCommandBuilder = new OleDbCommandBuilder(DBAdapter);
                DataSet DS = new DataSet("licence");

                DBAdapter.Fill(DS, "licence");

                DataTable licenceTable = DS.Tables["licence"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = licenceTable.Columns["id"];
                licenceTable.PrimaryKey = PrimaryKey;

                DataRow currRow = licenceTable.Rows.Find(SelectedRowIndex);

                string day = txtDay.Text;
                if (day.Length != 8)
                {
                    MessageBox.Show("취득일자는 8자리 숫자만 입력해 주십시오.\nex) 20181225", "인사정보관리", MessageBoxButtons.OK);
                    txtDay.Text = "";
                    myConnection.Close();
                    return;
                }
                currRow.BeginEdit();
                currRow["licence_n"] = txtLicenceN.Text;
                currRow["licence_rank"] = txtJobRank.Text;
                currRow["day1"] = day.Substring(0, 4);
                currRow["day2"] = day.Substring(4, 2);
                currRow["day3"] = day.Substring(6, 2);
                currRow["publish"] = txtPublish.Text;
                currRow.EndEdit();
                if (mainForm.ok == true)
                {
                    DataSet UpdatedSet = DS.GetChanges(DataRowState.Modified);

                    DBAdapter.Update(UpdatedSet, "licence");
                    DS.AcceptChanges();
                }
                else
                {
                    myConnection.Close();
                    return;
                }
                    

                OleDbDataReader myReader;
                myReader = myCommand.ExecuteReader();

                dgvLicence.Rows.Clear();
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

                string commandString = "select * from licence where emp_num=" + this.empn;
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = myCommand;

                OleDbCommandBuilder myCommandBuilder = new OleDbCommandBuilder(DBAdapter);

                DataSet DS = new DataSet();

                DBAdapter.Fill(DS, "licence");

                DataTable licenceTable = DS.Tables["licence"];

                DataRow[] empRow = licenceTable.Select("emp_num = '" + txtEmp_num.Text + "'");
                if (MessageBox.Show(this, "삭제하시겠습니까?", "인사정보관리", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    empRow[0].Delete();

                    DBAdapter.Update(DS.GetChanges(DataRowState.Deleted), "licence");
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

                dgvLicence.Rows.Clear();
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

        private void dgvLicence_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string commandString = "select * from licence where emp_num=" + this.empn;

            OleDbDataAdapter DBAdapter = new OleDbDataAdapter(commandString, connectionString);

            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "licence");

            DataTable licenceTable = DS.Tables["licence"];

            DataRow currRow = licenceTable.Rows[e.RowIndex];
            txtLicenceN.Text = currRow["licence_n"].ToString();
            txtJobRank.Text = currRow["licence_rank"].ToString();
            txtDay.Text = currRow["day1"].ToString() + currRow["day2"].ToString() + currRow["day3"].ToString();
            txtPublish.Text = currRow["publish"].ToString();

            SelectedRowIndex = (int)currRow["id"];
        }

        private void LicenceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

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
    }
}
