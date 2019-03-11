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
    public partial class DnRForm : Form
    {
        string depart;
        string rank;
        string commandString = "select emp_num, emp_name, department, jobposition, jobrank1, duty, " +
                    "join_day1, join_day2, join_day3, cellphone1, cellphone2, cellphone3 from pers_info ";
        public DnRForm()
        {
            InitializeComponent();
        }
        string connectionString = "provider=Microsoft.JET.OLEDB.4.0;"
                                        + "data source = "
                                        + Application.StartupPath
                                        + @"..\..\..\pim.mdb";
        private OleDbCommand myCommand = new OleDbCommand();

        private void cmbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void search()
        {
            depart = cmbDepartment.Text;
            rank = txtJobRank.Text;
            if (txtJobRank.Text == "")
            {
                commandString = commandString + "where department='" + depart + "'";
                dgv(commandString);
            }
            else if (cmbDepartment.Text == "")
            {
                commandString = commandString + "where jobrank1=" + rank;
                dgv(commandString);
            }
            else
            {
                commandString = commandString + "where department='" + depart + "' and jobrank1=" + rank;
                dgv(commandString);
            }
        }
        private void dgv(string commandString)
        {
            try
            {
                Console.WriteLine(commandString);
                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();
                OleDbDataReader myReader;
                myReader = myCommand.ExecuteReader();
                int i = 0;
                dgvDnP.Rows.Clear();
                while (myReader.Read())
                {
                    dgvDnP.Rows.Add();
                    dgvDnP["Col1", i].Value = i + 1;
                    dgvDnP["Col2", i].Value = myReader.GetInt32(0);
                    dgvDnP["Col3", i].Value = myReader.GetString(1);
                    dgvDnP["Col4", i].Value = myReader.GetString(2);
                    dgvDnP["Col5", i].Value = myReader.GetString(3);
                    dgvDnP["Col6", i].Value = myReader.GetInt32(4) + "급";
                    dgvDnP["Col7", i].Value = myReader.GetString(5);
                    dgvDnP["Col8", i].Value = myReader.GetInt32(6).ToString("0000") + "/" + myReader.GetInt32(7).ToString("00") + "/" + myReader.GetInt32(8).ToString("00");
                    dgvDnP["Col9", i].Value = myReader.GetInt32(9).ToString("000") + "-" + myReader.GetInt32(10).ToString("0000") + "-" + myReader.GetInt32(11).ToString("0000");

                    i++;

                }
                myReader.Close();
                myConnection.Close();
                this.commandString = "select emp_num, emp_name, department, jobposition, jobrank1, duty, " +
                    "join_day1, join_day2, join_day3, cellphone1, cellphone2, cellphone3 from pers_info ";
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            this.Hide();
            menu.ShowDialog();
        }

        private void DnRForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void txtJobRank_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }
}
