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
    public partial class DnPNP : Form
    {
        string[] depart = { "총계", "총무부", "경리부", "경영기획실", "마케팅부", "영업부" };
        string[] posi = { "사장", "부사장", "전무", "부장", "과장", "대리", "사원"};
        public DnPNP()
        {
            InitializeComponent();
        }
        string connectionString = "provider=Microsoft.JET.OLEDB.4.0;"
                                        + "data source = "
                                        + Application.StartupPath
                                        + @"..\..\..\pim.mdb";
        private OleDbCommand myCommand = new OleDbCommand();
        private void DnPNP_Load(object sender, EventArgs e)
        {
            int[,] num = new int[8, 6];
            int sum = 0;
            int[] sum1 = new int[6];
            try
            {
                string commandString = "select department, jobposition from pers_info";
                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();
                OleDbDataReader myReader;
                myReader = myCommand.ExecuteReader();
                dgvDnPNP.Rows.Clear();

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        num[i, j] = 0;
                        sum1[j] = 0;
                    }
                }

                while (myReader.Read())
                {
                    for (int i = 0; i < 7; i++)
                    {
                        if (posi[i] == myReader.GetString(1))
                        {
                            for (int j = 0; j < 6; j++)
                            {
                                if (depart[j] == myReader.GetString(0))
                                {
                                    num[i, j]++;
                                }
                            }
                        }
                    }
                }
                myReader.Close();
                myConnection.Close();

                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        sum = sum + num[i, j];
                    }
                    num[i, 0] = sum;
                    sum = 0;
                }
                
                
                for (int i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {
                        sum1[i] = sum1[i] + num[j, i];
                    }
                }
                

                dgvDnPNP.Rows.Clear();
                for (int i = 0; i < 6; i++)
                {
                    dgvDnPNP.Rows.Add();
                    dgvDnPNP["Col1", i].Value = depart[i];
                    dgvDnPNP["Col2", i].Value = num[0, i];
                    dgvDnPNP["Col3", i].Value = num[1, i];
                    dgvDnPNP["Col4", i].Value = num[2, i];
                    dgvDnPNP["Col5", i].Value = num[3, i];
                    dgvDnPNP["Col6", i].Value = num[4, i];
                    dgvDnPNP["Col7", i].Value = num[5, i];
                    dgvDnPNP["Col8", i].Value = num[6, i];
                    dgvDnPNP["Col9", i].Value = sum1[i];
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            this.Hide();
            menu.ShowDialog();
        }

        private void DnPNP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
