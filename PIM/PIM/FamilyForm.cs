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
    public partial class FamilyForm : Form
    {
        private int empn;
        private string name;
        private MainForm mainForm = new MainForm();
        public FamilyForm()
        {
            InitializeComponent();
        }
        public FamilyForm(int empn, string name)
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

        private void FamilyForm_Load(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection myConnection = new OleDbConnection(connectionString);
                string commandString = "select * from family where emp_num=" + this.empn;
                
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();
                OleDbDataReader myReader;
                myReader = myCommand.ExecuteReader();
                if(empn != 0)
                    txtEmp_num.Text = empn.ToString();
                txtName.Text = name;

                dgvFamily.Rows.Clear();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            mainForm.ok = true;
            try
            {
                OleDbConnection myConnection = new OleDbConnection(connectionString);

                string commandString = "select * from family where emp_num=" + this.empn;
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = myCommand;

                OleDbCommandBuilder myCommandBuilder = new OleDbCommandBuilder(DBAdapter);

                DataSet DS = new DataSet();

                DBAdapter.Fill(DS, "family");

                DataTable familyTable = DS.Tables["family"];
                DataRow newRow = familyTable.NewRow();

                if (txtEmp_num.Text == "")
                {
                    MessageBox.Show("사번을 입력해 주십시오.", "인사정보관리", MessageBoxButtons.OK);
                    clear();
                    myConnection.Close();
                    return;
                }

                newRow["emp_num"] = mainForm.num(txtEmp_num);
                newRow["emp_name"] = txtName.Text;
                newRow["f_name"] = txtFName.Text;
                newRow["relation"] = cmbRelation.Text;
                newRow["birth1"] = mainForm.num(txtBirthDay1);
                newRow["birth2"] = mainForm.num(txtBirthDay2);
                newRow["birth3"] = mainForm.num(txtBirthDay3);
                newRow["hl_edu"] = cmbHiEdu.Text;
                newRow["cohabitation"] = cmbCohabitation.Text;
                newRow["job"] = txtJob.Text;
                if(mainForm.ok == true)
                {
                    familyTable.Rows.Add(newRow);
                    DBAdapter.Update(DS, "family");
                }
                else
                {
                    myConnection.Close();
                    return;
                }
                

                MessageBox.Show("입력되었습니다.", "인사정보관리", MessageBoxButtons.OK);

                clear();

                OleDbDataReader myReader = myCommand.ExecuteReader();

                dgvFamily.Rows.Clear();
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
                dgvFamily.Rows.Add();
                dgvFamily["Col1", i].Value = i + 1;
                txtName.Text = myReader.GetString(2);
                dgvFamily["Col2", i].Value = myReader.GetString(3);
                dgvFamily["Col3", i].Value = myReader.GetString(4);
                dgvFamily["Col4", i].Value = myReader.GetInt32(5).ToString("0000") + "/" + myReader.GetInt32(6).ToString("00") + "/" + myReader.GetInt32(7).ToString("00");
                dgvFamily["Col5", i].Value = myReader.GetString(8);
                dgvFamily["Col6", i].Value = myReader.GetString(9);
                dgvFamily["Col7", i].Value = myReader.GetString(10);

                i++;

            }
            myReader.Close();
        }
        private int SelectedRowIndex;
        private void btnEdit_Click(object sender, EventArgs e)
        {
            mainForm.ok = true;
            try
            {
                OleDbConnection myConnection = new OleDbConnection(connectionString);
                string commandString = "select * from family where emp_num=" + this.empn;
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = myCommand;

                OleDbCommandBuilder myCommandBuilder = new OleDbCommandBuilder(DBAdapter);
                DataSet DS = new DataSet("family");
                
                DBAdapter.Fill(DS, "family");
                
                DataTable familyTable = DS.Tables["family"];
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = familyTable.Columns["id"];
                familyTable.PrimaryKey = PrimaryKey;

                DataRow currRow = familyTable.Rows.Find(SelectedRowIndex);

                currRow.BeginEdit();
                currRow["f_name"] = txtFName.Text;
                currRow["relation"] = cmbRelation.Text;
                currRow["birth1"] = mainForm.num(txtBirthDay1);
                currRow["birth2"] = mainForm.num(txtBirthDay2);
                currRow["birth3"] = mainForm.num(txtBirthDay3);
                currRow["hl_edu"] = cmbHiEdu.Text;
                currRow["cohabitation"] = cmbCohabitation.Text;
                currRow["job"] = txtJob.Text;
                currRow.EndEdit();
                if (mainForm.ok == true)
                {
                    DataSet UpdatedSet = DS.GetChanges(DataRowState.Modified);

                    DBAdapter.Update(UpdatedSet, "family");
                    DS.AcceptChanges();
                }
                else
                {
                    myConnection.Close();
                    return;
                }
                

                OleDbDataReader myReader;
                myReader = myCommand.ExecuteReader();

                dgvFamily.Rows.Clear();
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

        private void dgvFamliy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string commandString = "select * from family where emp_num=" + this.empn;

            OleDbDataAdapter DBAdapter = new OleDbDataAdapter(commandString, connectionString);

            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "family");

            DataTable familyTable = DS.Tables["family"];

            DataRow currRow = familyTable.Rows[e.RowIndex];
            txtFName.Text = currRow["f_name"].ToString();
            cmbRelation.Text = currRow["relation"].ToString();
            txtBirthDay1.Text = currRow["birth1"].ToString();
            txtBirthDay2.Text = currRow["birth2"].ToString();
            txtBirthDay3.Text = currRow["birth3"].ToString();
            cmbHiEdu.Text = currRow["hl_edu"].ToString();
            cmbCohabitation.Text = currRow["cohabitation"].ToString();
            txtJob.Text = currRow["job"].ToString();

            SelectedRowIndex = (int)currRow["id"];
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                OleDbConnection myConnection = new OleDbConnection(connectionString);

                string commandString = "select * from family where emp_num=" + this.empn;
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = myCommand;

                OleDbCommandBuilder myCommandBuilder = new OleDbCommandBuilder(DBAdapter);

                DataSet DS = new DataSet();

                DBAdapter.Fill(DS, "family");

                DataTable familyTable = DS.Tables["family"];

                DataRow[] empRow = familyTable.Select("emp_num = '" + txtEmp_num.Text + "'");
                if(MessageBox.Show(this,"삭제하시겠습니까?","인사정보관리",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    empRow[0].Delete();

                    DBAdapter.Update(DS.GetChanges(DataRowState.Deleted), "family");
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

                dgvFamily.Rows.Clear();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtEmp_num.Text == "")
                {
                    MessageBox.Show("사번을 입력해 주십시오.", "인사정보관리", MessageBoxButtons.OK);
                    clear();
                    return;
                }
                OleDbConnection myConnection = new OleDbConnection(connectionString);
                string commandString = "select * from family where emp_num=" + txtEmp_num.Text;

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

                dgvFamily.Rows.Clear();
                dgv(myReader);
                myConnection.Close();
                if(dgvFamily.Rows.Count == 0)
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

        private void FamilyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        public void clear()
        {
            foreach (Control ctl in this.Controls)
            {
                if (typeof(System.Windows.Forms.TextBox) == ctl.GetType())
                {
                    if(ctl != txtEmp_num && ctl != txtName)
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
