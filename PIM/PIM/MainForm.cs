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
    public partial class MainForm : Form
    {
        public bool ok = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private static string connectionString = "provider=Microsoft.JET.OLEDB.4.0;"
                                        + "data source = "
                                        + Application.StartupPath
                                        + @"..\..\..\pim.mdb";

        private OleDbConnection myConnection = new OleDbConnection(connectionString);

        private string commandString = "select * from pers_info";
        private OleDbCommand myCommand = new OleDbCommand();


        private void btnInsert_Click(object sender, EventArgs e)
        {
            ok = true;
            try
            {
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = myCommand;

                OleDbCommandBuilder myCommandBuilder = new OleDbCommandBuilder(DBAdapter);

                DataSet DS = new DataSet();

                DBAdapter.Fill(DS, "pers_info");

                DataTable pers_infoTable = DS.Tables["pers_info"];
                DataRow newRow = pers_infoTable.NewRow();

                if (txtEmp_num.Text == "")
                {
                    MessageBox.Show("사번을 입력해 주십시오.", "인사정보관리", MessageBoxButtons.OK);
                    clear();
                    myConnection.Close();
                    txtEmp_num.Focus();
                    return;
                }
                OleDbDataReader myReader = myCommand.ExecuteReader();
                
                while (myReader.Read())
                {
                    if (num(txtEmp_num) == myReader.GetInt32(0))
                    {
                        MessageBox.Show("이미 등록된 사원입니다.", "인사정보관리", MessageBoxButtons.OK);
                        clear();
                        myReader.Close();
                        myConnection.Close();
                        txtEmp_num.Focus();
                        return;
                    }
                }

                myReader.Close();

                newRow["emp_num"] = num(txtEmp_num);
                newRow["emp_name"] = txtName.Text;

                if (rdoSex_m.Checked)
                    newRow["sex"] = "남자";
                else if (rdoSex_w.Checked)
                    newRow["sex"] = "여자";

                if (Reg_num1() != 0)
                    newRow["reg_num1"] = Reg_num1();
                else
                {
                    MessageBox.Show("주민번호 앞자리를 잘못 입력하셨습니다.", "인사정보관리", MessageBoxButtons.OK);
                    txtRegNum1.Text = "";
                    myConnection.Close();
                    return;
                }
                if (Reg_num2() != 0)
                    newRow["reg_num2"] = Reg_num2();
                else
                {
                    MessageBox.Show("주민번호 뒷자리를 잘못 입력하셨습니다.", "인사정보관리", MessageBoxButtons.OK);
                    txtRegNum2.Text = "";
                    myConnection.Close();
                    return;
                }
                newRow["jobposition"] = cmbJobPosition.Text;
                newRow["jobrank1"] = num(txtJobRank1);
                newRow["jobrank2"] = num(txtJobRank2);
                newRow["department"] = cmbDepartment.Text;
                newRow["duty"] = txtDuty.Text;
                newRow["joindiv"] = cmbJoinDiv.Text;
                newRow["join_day1"] = num(txtJoinDay1);
                newRow["join_day2"] = num(txtJoinDay2);
                newRow["join_day3"] = num(txtJoinDay3);
                newRow["resign_reason"] = txtResignR.Text;
                newRow["resign_day1"] = num(txtResignD1);
                newRow["resign_day2"] = num(txtResignD2);
                newRow["resign_day3"] = num(txtResignD3);
                newRow["hl_edu"] = cmbHiEdu.Text;
                newRow["school_name"] = txtSchoolName.Text;
                newRow["marriage"] = cmbMarriage.Text;
                newRow["military"] = cmbMilitary.Text;
                newRow["discharge"] = cmbDischarge.Text;
                newRow["E_Mail"] = txtEMail1.Text + "@" + txtEMail2.Text;
                newRow["house_type"] = cmbHouse.Text;
                newRow["h_address"] = txtH_Address.Text;
                newRow["postcode"] = num(txtPost);
                newRow["phone1"] = num(cmbPhone);
                newRow["phone2"] = num(txtPhone1);
                newRow["phone3"] = num(txtPhone2);
                newRow["cellphone1"] = num(cmbCellPhone);
                newRow["cellphone2"] = num(txtCellPhone1);
                newRow["cellphone3"] = num(txtCellPhone2);
                newRow["religion"] = txtReligion.Text;
                newRow["hobby"] = txtHobby.Text;
                newRow["foreign_lang1"] = cmbForeign1.Text;

                if (rdoLevel_H1.Checked)
                    newRow["level1"] = "상";
                else if (rdoLevel_M1.Checked)
                    newRow["level1"] = "중";
                else if (rdoLevel_L1.Checked)
                    newRow["level1"] = "하";

                newRow["foreign_lang2"] = cmbForeign2.Text;

                if (rdoLevel_H2.Checked)
                    newRow["level2"] = "상";
                else if (rdoLevel_M2.Checked)
                    newRow["level2"] = "중";
                else if (rdoLevel_L2.Checked)
                    newRow["level2"] = "하";
                if(ok == true)
                {
                    pers_infoTable.Rows.Add(newRow);
                    DBAdapter.Update(DS, "pers_info");
                }
                else
                {
                    return;
                }

                MessageBox.Show("입력되었습니다.", "인사정보관리", MessageBoxButtons.OK);

                clear();
                txtEmp_num.Focus();
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

        private void clear()
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
                    ctl.BackColor = Color.White;
                    if (ctl.Name == cmbEMail.Name)
                        ctl.Text = "직접입력";
                    else
                        ctl.Text = null;
                }
            }
        }

        public int num(TextBox tb)
        {
            
            if (tb.Text == "")
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < tb.Text.Length; i++)
                {
                    if (tb.Text[i] >= '0' && tb.Text[i] <= '9')
                    {

                    }
                    else
                    {
                        MessageBox.Show("숫자만 입력해 주세요.", "인사정보관리", MessageBoxButtons.OK);
                        tb.Text = "";
                        tb.BackColor = Color.FromArgb(255, 167, 167);
                        ok = false;
                        myConnection.Close();
                        return 0;
                    }

                }
                return int.Parse(tb.Text);
            }
        }

        public int num(ComboBox cb)
        {
            
            if (cb.Text == "")
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < cb.Text.Length; i++)
                {
                    if (cb.Text[i] >= '0' && cb.Text[i] <= '9')
                    {

                    }
                    else
                    {
                        MessageBox.Show("숫자만 입력해 주세요.", "인사정보관리", MessageBoxButtons.OK);
                        cb.Text = "";
                        cb.BackColor = Color.FromArgb(255, 167, 167);
                        ok = false;
                        myConnection.Close();
                        return 0;
                    }

                }
                return int.Parse(cb.Text);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbEMail_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEMail.Text != "직접입력")
                txtEMail2.Text = cmbEMail.Text;
            else
                txtEMail2.Text = "";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            cmbEMail.Text = "직접입력";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = myCommand;

                DataSet DS = new DataSet();

                DBAdapter.Fill(DS, "pers_info");

                DataTable pers_infoTable = DS.Tables["pers_info"];

                OleDbDataReader myReader = myCommand.ExecuteReader();
                int en=0, samename = 0;
                while (myReader.Read())
                {
                    if (num(txtEmp_num) == myReader.GetInt32(0))
                    {
                        fill(myReader);
                        en++;
                    }

                    if (txtName.Text == ChkDbStr(myReader.GetValue(1)))
                    {
                        samename++;
                    }
                }
                myReader.Close();

                if (en == 0 && samename == 0)
                {
                    MessageBox.Show("해당 사원의 데이터가 없습니다.", "인사정보관리", MessageBoxButtons.OK);
                    clear();
                    myReader.Close();
                    myConnection.Close();
                    return;
                }
                if (txtEmp_num.Text == "" && samename == 1)
                {
                    OleDbDataReader myReader2 = myCommand.ExecuteReader();
                    while (myReader2.Read())
                    {
                        if (txtName.Text == ChkDbStr(myReader2.GetValue(1)))
                        {
                            fill(myReader2);
                        }
                    }
                    myReader2.Close();
                }
                if (txtEmp_num.Text == "" && samename > 1)
                {
                    SameNameForm sameName = new SameNameForm(txtName.Text);
                    sameName.ShowDialog();

                    OleDbDataReader myReader2 = myCommand.ExecuteReader();
                    while (myReader2.Read())
                    {
                        if (sameName.passemp == myReader2.GetInt32(0))
                        {
                            fill(myReader2);
                        }
                    }
                    myReader2.Close();
                }
                
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
        private void fill(OleDbDataReader myReader)
        {
            txtEmp_num.Text = myReader.GetInt32(0).ToString();
            txtName.Text = myReader.GetString(1);

            if (myReader.GetString(2) == "남자")
                rdoSex_m.Checked = true;
            else
                rdoSex_w.Checked = true;

            txtRegNum1.Text = myReader.GetInt32(3).ToString();
            txtRegNum2.Text = myReader.GetInt32(4).ToString();
            cmbJobPosition.SelectedItem = ChkDbStr(myReader.GetValue(5));
            txtJobRank1.Text = myReader.GetInt32(6).ToString();
            txtJobRank2.Text = myReader.GetInt32(7).ToString();
            cmbDepartment.SelectedItem = ChkDbStr(myReader.GetValue(8));
            txtDuty.Text = ChkDbStr(myReader.GetValue(9));
            cmbJoinDiv.SelectedItem = ChkDbStr(myReader.GetValue(10));
            txtJoinDay1.Text = myReader.GetInt32(11).ToString();
            txtJoinDay2.Text = myReader.GetInt32(12).ToString();
            txtJoinDay3.Text = myReader.GetInt32(13).ToString();
            txtResignR.Text = ChkDbStr(myReader.GetValue(14));
            txtResignD1.Text = myReader.GetInt32(15).ToString();
            txtResignD2.Text = myReader.GetInt32(16).ToString();
            txtResignD3.Text = myReader.GetInt32(17).ToString();
            cmbHiEdu.SelectedItem = ChkDbStr(myReader.GetValue(18));
            txtSchoolName.Text = ChkDbStr(myReader.GetValue(19));
            cmbMarriage.SelectedItem = ChkDbStr(myReader.GetValue(20));
            cmbMilitary.SelectedItem = ChkDbStr(myReader.GetValue(21));
            cmbDischarge.SelectedItem = ChkDbStr(myReader.GetValue(22));
            string[] em = ChkDbStr(myReader.GetString(23)).Split('@');
            txtEMail1.Text = em[0];
            txtEMail2.Text = em[1];
            cmbHouse.SelectedItem = ChkDbStr(myReader.GetValue(24));
            txtH_Address.Text = ChkDbStr(myReader.GetValue(25));
            txtPost.Text = myReader.GetInt32(26).ToString();
            if (myReader.GetInt32(27) == 2)
            {
                cmbPhone.SelectedItem = myReader.GetInt32(27).ToString("00");
            }
            else
            {
                cmbPhone.SelectedItem = myReader.GetInt32(27).ToString("000");
            }
            txtPhone1.Text = myReader.GetInt32(28).ToString();
            txtPhone2.Text = myReader.GetInt32(29).ToString();
            cmbCellPhone.SelectedItem = myReader.GetInt32(30).ToString("000");
            txtCellPhone1.Text = myReader.GetInt32(31).ToString();
            txtCellPhone2.Text = myReader.GetInt32(32).ToString();
            txtReligion.Text = ChkDbStr(myReader.GetValue(33));
            txtHobby.Text = ChkDbStr(myReader.GetValue(34));
            cmbForeign1.SelectedItem = ChkDbStr(myReader.GetValue(35));

            if (ChkDbStr(myReader.GetValue(36)) == "상")
                rdoLevel_H1.Checked = true;
            else if (ChkDbStr(myReader.GetValue(36)) == "중")
                rdoLevel_M1.Checked = true;
            else
                rdoLevel_L1.Checked = true;

            cmbForeign2.Text = ChkDbStr(myReader.GetValue(37));

            if (ChkDbStr(myReader.GetValue(38)) == "상")
                rdoLevel_H2.Checked = true;
            else if (ChkDbStr(myReader.GetValue(38)) == "중")
                rdoLevel_M2.Checked = true;
            else
                rdoLevel_L2.Checked = true;
        }
        private string ChkDbStr(object inObj)
        {
            if (inObj == null)
            { return ""; }
            else
            { return inObj.ToString(); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            ok = true;
            
            try
            {
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();

                OleDbDataAdapter DBAdapter = new OleDbDataAdapter();
                DBAdapter.SelectCommand = myCommand;

                OleDbCommandBuilder myCommandBuilder = new OleDbCommandBuilder(DBAdapter);
                DataSet DS = new DataSet("pers_info");

                DBAdapter.Fill(DS, "pers_info");

                DataTable pers_infoTable = DS.Tables["pers_info"];

                OleDbDataReader myReader = myCommand.ExecuteReader();
                int em = 0;
                while (myReader.Read())
                {
                    if (num(txtEmp_num) == myReader.GetInt32(0))
                    {
                        em++;
                    }
                }
                myReader.Close();
                if(em == 0)
                {
                    MessageBox.Show("존재하지 않는 사원입니다.", "인사정보관리", MessageBoxButtons.OK);
                    clear();
                    myConnection.Close();
                    txtEmp_num.Focus();
                    return;
                }
                Console.WriteLine(txtEmp_num.Text);
                DataRow[] empRow = pers_infoTable.Select("emp_num = '" + txtEmp_num.Text + "'");

                empRow[0]["emp_name"] = txtName.Text;

                if (rdoSex_m.Checked)
                    empRow[0]["sex"] = "남자";
                else if (rdoSex_w.Checked)
                    empRow[0]["sex"] = "여자";

                if (Reg_num1() != 0)
                    empRow[0]["reg_num1"] = Reg_num1();
                else
                {
                    MessageBox.Show("주민번호 앞자리를 잘못 입력하셨습니다.", "인사정보관리", MessageBoxButtons.OK);
                    txtRegNum1.Text = "";
                    myConnection.Close();
                    return;
                }

                if (Reg_num2() != 0)
                    empRow[0]["reg_num2"] = Reg_num2();
                else
                {
                    MessageBox.Show("주민번호 뒷자리를 잘못 입력하셨습니다.", "인사정보관리", MessageBoxButtons.OK);
                    txtRegNum2.Text = "";
                    myConnection.Close();
                    return;
                }

                empRow[0]["jobposition"] = cmbJobPosition.Text;
                empRow[0]["jobrank1"] = num(txtJobRank1);
                empRow[0]["jobrank2"] = num(txtJobRank2);
                empRow[0]["department"] = cmbDepartment.Text;
                empRow[0]["duty"] = txtDuty.Text;
                empRow[0]["joindiv"] = cmbJoinDiv.Text;
                empRow[0]["join_day1"] = num(txtJoinDay1);
                empRow[0]["join_day2"] = num(txtJoinDay2);
                empRow[0]["join_day3"] = num(txtJoinDay3);
                empRow[0]["resign_reason"] = txtResignR.Text;
                empRow[0]["resign_day1"] = num(txtResignD1);
                empRow[0]["resign_day2"] = num(txtResignD2);
                empRow[0]["resign_day3"] = num(txtResignD3);
                empRow[0]["hl_edu"] = cmbHiEdu.Text;
                empRow[0]["school_name"] = txtSchoolName.Text;
                empRow[0]["marriage"] = cmbMarriage.Text;
                empRow[0]["military"] = cmbMilitary.Text;
                empRow[0]["discharge"] = cmbDischarge.Text;
                empRow[0]["E_Mail"] = txtEMail1.Text + "@" + txtEMail2.Text;
                empRow[0]["house_type"] = cmbHouse.Text;
                empRow[0]["h_address"] = txtH_Address.Text;
                empRow[0]["postcode"] = num(txtPost);
                empRow[0]["phone1"] = num(cmbPhone);
                empRow[0]["phone2"] = num(txtPhone1);
                empRow[0]["phone3"] = num(txtPhone2);
                empRow[0]["cellphone1"] = num(cmbCellPhone);
                empRow[0]["cellphone2"] = num(txtCellPhone1);
                empRow[0]["cellphone3"] = num(txtCellPhone2);
                empRow[0]["religion"] = txtReligion.Text;
                empRow[0]["hobby"] = txtHobby.Text;
                empRow[0]["foreign_lang1"] = cmbForeign1.Text;

                if (rdoLevel_H1.Checked)
                    empRow[0]["level1"] = "상";
                else if (rdoLevel_M1.Checked)
                    empRow[0]["level1"] = "중";
                else if (rdoLevel_L1.Checked)
                    empRow[0]["level1"] = "하";

                empRow[0]["foreign_lang2"] = cmbForeign2.Text;

                if (rdoLevel_H2.Checked)
                    empRow[0]["level2"] = "상";
                else if (rdoLevel_M2.Checked)
                    empRow[0]["level2"] = "중";
                else if (rdoLevel_L2.Checked)
                    empRow[0]["level2"] = "하";

                if (ok == true)
                {
                    DataSet UpdatedSet = DS.GetChanges(DataRowState.Modified);

                    DBAdapter.Update(UpdatedSet, "pers_info");
                    DS.AcceptChanges();
                }
                else
                {
                    return;
                }
                

                MessageBox.Show("수정되었습니다.", "인사정보관리", MessageBoxButtons.OK);

                clear();
                txtEmp_num.Focus();
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
                OleDbDataAdapter DBAdapter = new OleDbDataAdapter(commandString, connectionString);
                OleDbCommandBuilder myCommandBuilder = new OleDbCommandBuilder(DBAdapter);
                DataSet DS = new DataSet("pers_info");

                DBAdapter.Fill(DS, "pers_info");

                DataTable pers_infoTable = DS.Tables["pers_info"];

                DataRow[] empRow = pers_infoTable.Select("emp_num = '" + txtEmp_num.Text + "'");
                if(MessageBox.Show(this,"삭제하시겠습니까?","인사정보관리",MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    empRow[0].Delete();

                    DBAdapter.Update(DS.GetChanges(DataRowState.Deleted), "pers_info");
                    MessageBox.Show("삭제되었습니다.", "인사정보관리", MessageBoxButtons.OK);

                    clear();
                }
                else
                {
                    MessageBox.Show("삭제 작업이 취소되었습니다.", "인사정보관리", MessageBoxButtons.OK);

                    clear();
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

        private void msFamily_Click(object sender, EventArgs e)
        {
            FamilyForm familyForm = new FamilyForm(num(txtEmp_num),txtName.Text);
            this.Hide();
            familyForm.ShowDialog();
        }

        private void msLicence_Click(object sender, EventArgs e)
        {
            LicenceForm licenceForm = new LicenceForm(num(txtEmp_num), txtName.Text);
            this.Hide();
            licenceForm.ShowDialog();
        }

        private void msPreCompany_Click(object sender, EventArgs e)
        {
            PreCompanyForm preCompanyForm = new PreCompanyForm(num(txtEmp_num), txtName.Text);
            this.Hide();
            preCompanyForm.ShowDialog();
        }

        private int Reg_num1()
        {
            string reg1;
            reg1 = txtRegNum1.Text;
            if (reg1.Length == 6)
                for (int i = 0; i < reg1.Length; i++)
                {
                    if (reg1[i] >= '0' && reg1[i] <= '9')
                    {
                        return int.Parse(reg1);
                    }
                    else
                        return 0;
                }
            return 0;
        }
        private int Reg_num2()
        {
            string reg1, reg2, reg3;
            reg1 = txtRegNum1.Text;
            reg2 = txtRegNum2.Text;
            reg3 = reg1 + reg2;
            int reg = 0;
            int[] num = { 2, 3, 4, 5, 6, 7, 8, 9, 2, 3, 4, 5 };
            if (reg2.Length == 7)
                for (int i = 0; i < reg2.Length; i++)
                {
                    if (reg2[i] >= '0' && reg2[i] <= '9')
                    {
                        
                    }
                    else
                        return 0;
                }
            else
                return 0;
            for (int j = 0; j < reg3.Length - 1; j++)
            {
                reg = reg + ((int.Parse(reg3[j].ToString()) * num[j]));
                Console.WriteLine(int.Parse(reg3[j].ToString()) + "*" + num[j] + "=" +(int.Parse(reg3[j].ToString()) * num[j]));
                Console.WriteLine(reg + ((int.Parse(reg3[j].ToString()) * num[j])));
                if ((11 - (reg % 11))%10 == int.Parse(reg3[12].ToString()))
                {
                    return int.Parse(reg2);
                }
            }
            return 0;
        }
    }
}
