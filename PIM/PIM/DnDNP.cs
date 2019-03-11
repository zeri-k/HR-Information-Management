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
    public partial class DnDNP : Form
    {
        string[] depart = { "총계", "총무부", "경리부", "경영기획실", "마케팅부", "영업부" };
        int[] date = { 365, 365 * 3, 365 * 5, 365 * 10, 365 * 15, 365 * 20, 365 * 20 };
        public DnDNP()
        {
            InitializeComponent();
        }
        string connectionString = "provider=Microsoft.JET.OLEDB.4.0;"
                                        + "data source = "
                                        + Application.StartupPath
                                        + @"..\..\..\pim.mdb";
        private OleDbCommand myCommand = new OleDbCommand();
        private void DnDNP_Load(object sender, EventArgs e)
        {
            int[,] num = new int[8, 6];
            int sum = 0;
            int[] sum1 = new int[6];

            try
            {

                string commandString = "select department, join_day1, join_day2, join_day3 from pers_info";
                OleDbConnection myConnection = new OleDbConnection(connectionString);

                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();


                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        num[i, j] = 0;
                        sum1[j] = 0;
                    }
                }
                string now = DateTime.Now.ToString("d");
                TimeSpan day;
                OleDbDataReader myReader;
                myReader = myCommand.ExecuteReader();
                while (myReader.Read())
                {
                    day = DateTime.Parse(now) - DateTime.Parse(myReader.GetInt32(1).ToString("0000") + "-" +
                        myReader.GetInt32(2).ToString("00") + "-" + myReader.GetInt32(3).ToString("00"));
                    if (date[6] <= day.Days)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (depart[j] == myReader.GetString(0))
                            {
                                num[6, j]++;
                            }
                        }
                    }
                    else if (date[5] <= day.Days && day.Days < date[6])
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (depart[j] == myReader.GetString(0))
                            {
                                num[5, j]++;
                            }
                        }
                    }
                    else if (date[4] <= day.Days && day.Days < date[5])
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (depart[j] == myReader.GetString(0))
                            {
                                num[4, j]++;
                            }
                        }
                    }
                    else if (date[3] <= day.Days && day.Days < date[4])
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (depart[j] == myReader.GetString(0))
                            {
                                num[3, j]++;
                            }
                        }
                    }
                    else if (date[2] <= day.Days && day.Days < date[3])
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (depart[j] == myReader.GetString(0))
                            {
                                num[2, j]++;
                            }
                        }
                    }
                    else if (date[1] <= day.Days && day.Days < date[2])
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (depart[j] == myReader.GetString(0))
                            {
                                num[1, j]++;
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (depart[j] == myReader.GetString(0))
                            {
                                num[0, j]++;
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

        private void DnDNP_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
