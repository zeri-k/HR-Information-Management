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
    public partial class SameNameForm : Form
    {
        private string name;
        public SameNameForm()
        {
            InitializeComponent();
        }
        public SameNameForm(string name)
        {
            InitializeComponent();
            this.name = name;
        }
        string connectionString = "provider=Microsoft.JET.OLEDB.4.0;"
                                        + "data source = "
                                        + Application.StartupPath
                                        + @"..\..\..\pim.mdb";
        private OleDbCommand myCommand = new OleDbCommand();
        private void SameNameForm_Load(object sender, EventArgs e)
        {
            try
            {
                

                string commandString = "select emp_num, emp_name, sex, jobposition, department, cellphone1, cellphone2, cellphone3 " +
                    "from pers_info where emp_name='" + this.name + "'";
                OleDbConnection myConnection = new OleDbConnection(connectionString);
                
                myCommand.Connection = myConnection;
                myCommand.CommandText = commandString;

                myConnection.Open();
                OleDbDataReader myReader;
                myReader = myCommand.ExecuteReader();
                int i = 0;
                dgvSameName.Rows.Clear();
                while (myReader.Read())
                {
                    dgvSameName.Rows.Add();
                    dgvSameName["Col1", i].Value = i + 1;
                    dgvSameName["Col2", i].Value = myReader.GetInt32(0);
                    dgvSameName["Col3", i].Value = myReader.GetString(1);
                    dgvSameName["Col4", i].Value = myReader.GetString(2);
                    dgvSameName["Col5", i].Value = myReader.GetString(3);
                    dgvSameName["Col6", i].Value = myReader.GetString(4);
                    dgvSameName["Col7", i].Value = myReader.GetInt32(5).ToString("000") + "-" + myReader.GetInt32(6).ToString() + "-" + myReader.GetInt32(7).ToString();

                    i++;

                }
                myReader.Close();
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
        public int passemp;
        private void dgvSameName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string commandString = "select emp_num, emp_name, sex, jobposition, department, cellphone1, cellphone2, cellphone3 " +
                    "from pers_info where emp_name='" + this.name + "'";

            OleDbDataAdapter DBAdapter = new OleDbDataAdapter(commandString, connectionString);

            DataSet DS = new DataSet();
            DBAdapter.Fill(DS, "pers_info");

            DataTable pers_infoTable = DS.Tables["pers_info"];

            DataRow currRow = pers_infoTable.Rows[e.RowIndex];
            passemp = (int)currRow["emp_num"];

            this.Close();
        }
    }
}
