using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Collections;

namespace PIM
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void MenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void strip_p_body_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
        }

        private void strip_f_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void strip_p_family_Click(object sender, EventArgs e)
        {
            FamilyForm familyForm = new FamilyForm();
            this.Hide();
            familyForm.ShowDialog();
        }

        private void strip_p_licence_Click(object sender, EventArgs e)
        {
            LicenceForm licenceForm = new LicenceForm();
            this.Hide();
            licenceForm.ShowDialog();
        }

        private void strip_p_career_Click(object sender, EventArgs e)
        {
            PreCompanyForm preCompanyForm = new PreCompanyForm();
            this.Hide();
            preCompanyForm.ShowDialog();
        }

        
        private void strip_i_emp_Click(object sender, EventArgs e)
        {
            AllEmpListForm allEmpListForm = new AllEmpListForm();
            this.Hide();
            allEmpListForm.ShowDialog();
        }

        private void tsmComboDepartment_TextChanged(object sender, EventArgs e)
        {
            if(tsmComboDepartment.SelectedIndex == 0)
            {
                ArrayList Departmentlist = new ArrayList();
                for(int i=1;i < tsmComboDepartment.Items.Count; i++)
                    Departmentlist.Add(tsmComboDepartment.Items[i]);
                AllDepartmentForm allDepartmentForm = new AllDepartmentForm(Departmentlist);
                this.Hide();
                allDepartmentForm.ShowDialog();
            }
            else
            {
                DepartmentForm DepartmentForm = new DepartmentForm(tsmComboDepartment.Items[tsmComboDepartment.SelectedIndex].ToString());
                this.Hide();
                DepartmentForm.ShowDialog();
            }
        }

        private void tsmComboPosition_TextChanged(object sender, EventArgs e)
        {
            if (tsmComboPosition.SelectedIndex == 0)
            {
                ArrayList Positiontlist = new ArrayList();
                for (int i = 1; i < tsmComboPosition.Items.Count; i++)
                    Positiontlist.Add(tsmComboPosition.Items[i]);
                AllPositionForm allPositionForm = new AllPositionForm(Positiontlist);
                this.Hide();
                allPositionForm.ShowDialog();
            }
            else
            {
                PositionForm positionForm = new PositionForm(tsmComboPosition.Items[tsmComboPosition.SelectedIndex].ToString());
                this.Hide();
                positionForm.ShowDialog();
            }
        }

        private void tsmResign_Click(object sender, EventArgs e)
        {
            ResignForm resignForm = new ResignForm();
            this.Hide();
            resignForm.ShowDialog();
        }

        private void strip_s_dp_Click(object sender, EventArgs e)
        {
            DnPForm dnPForm = new DnPForm();
            this.Hide();
            dnPForm.ShowDialog();
        }

        private void strip_s_dr_Click(object sender, EventArgs e)
        {
            DnRForm dnRForm = new DnRForm();
            this.Hide();
            dnRForm.ShowDialog();
        }

        private void strip_s_dpr_Click(object sender, EventArgs e)
        {
            DnPnRForm dnPnRForm = new DnPnRForm();
            this.Hide();
            dnPnRForm.ShowDialog();
        }

        private void tsmDnPNP_Click(object sender, EventArgs e)
        {
            DnPNP dnPNP = new DnPNP();
            this.Hide();
            dnPNP.ShowDialog();
        }

        private void tsmDnDNP_Click(object sender, EventArgs e)
        {
            DnDNP dnDNP = new DnDNP();
            this.Hide();
            dnDNP.ShowDialog();
        }

        private void tsmPnDNP_Click(object sender, EventArgs e)
        {
            PnDNP pnDNP = new PnDNP();
            this.Hide();
            pnDNP.ShowDialog();
        }
    }
}
