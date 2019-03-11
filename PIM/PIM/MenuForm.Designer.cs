namespace PIM
{
    partial class MenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.strip_File = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_f_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_Person_r = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_p_body = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_p_family = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_p_licence = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_p_career = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_Information = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEmp = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDepartment = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmComboDepartment = new System.Windows.Forms.ToolStripComboBox();
            this.tsmPosition = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmComboPosition = new System.Windows.Forms.ToolStripComboBox();
            this.tsmResign = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_serch = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_s_dp = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_s_dr = new System.Windows.Forms.ToolStripMenuItem();
            this.strip_s_dpr = new System.Windows.Forms.ToolStripMenuItem();
            this.인사통계ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDnPNP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDnDNP = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmPnPNP = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("맑은 고딕", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_File,
            this.strip_Person_r,
            this.strip_Information,
            this.strip_serch,
            this.인사통계ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(914, 31);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // strip_File
            // 
            this.strip_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_f_Exit});
            this.strip_File.Name = "strip_File";
            this.strip_File.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.F)));
            this.strip_File.Size = new System.Drawing.Size(77, 27);
            this.strip_File.Text = "파일(&F)";
            // 
            // strip_f_Exit
            // 
            this.strip_f_Exit.Name = "strip_f_Exit";
            this.strip_f_Exit.Size = new System.Drawing.Size(120, 28);
            this.strip_f_Exit.Text = "종료";
            this.strip_f_Exit.Click += new System.EventHandler(this.strip_f_Exit_Click);
            // 
            // strip_Person_r
            // 
            this.strip_Person_r.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_p_body,
            this.strip_p_family,
            this.strip_p_licence,
            this.strip_p_career});
            this.strip_Person_r.Name = "strip_Person_r";
            this.strip_Person_r.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.P)));
            this.strip_Person_r.Size = new System.Drawing.Size(112, 27);
            this.strip_Person_r.Text = "인사등록(&P)";
            // 
            // strip_p_body
            // 
            this.strip_p_body.Name = "strip_p_body";
            this.strip_p_body.Size = new System.Drawing.Size(205, 28);
            this.strip_p_body.Text = "개인신상정보";
            this.strip_p_body.Click += new System.EventHandler(this.strip_p_body_Click);
            // 
            // strip_p_family
            // 
            this.strip_p_family.Name = "strip_p_family";
            this.strip_p_family.Size = new System.Drawing.Size(205, 28);
            this.strip_p_family.Text = "가족사항";
            this.strip_p_family.Click += new System.EventHandler(this.strip_p_family_Click);
            // 
            // strip_p_licence
            // 
            this.strip_p_licence.Name = "strip_p_licence";
            this.strip_p_licence.Size = new System.Drawing.Size(205, 28);
            this.strip_p_licence.Text = "자격및면허사항";
            this.strip_p_licence.Click += new System.EventHandler(this.strip_p_licence_Click);
            // 
            // strip_p_career
            // 
            this.strip_p_career.Name = "strip_p_career";
            this.strip_p_career.Size = new System.Drawing.Size(205, 28);
            this.strip_p_career.Text = "입사전경력사항";
            this.strip_p_career.Click += new System.EventHandler(this.strip_p_career_Click);
            // 
            // strip_Information
            // 
            this.strip_Information.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEmp,
            this.tsmDepartment,
            this.tsmPosition,
            this.tsmResign});
            this.strip_Information.Name = "strip_Information";
            this.strip_Information.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.I)));
            this.strip_Information.Size = new System.Drawing.Size(107, 27);
            this.strip_Information.Text = "인사정보(&I)";
            // 
            // tsmEmp
            // 
            this.tsmEmp.Name = "tsmEmp";
            this.tsmEmp.Size = new System.Drawing.Size(205, 28);
            this.tsmEmp.Text = "전체사원대장";
            this.tsmEmp.Click += new System.EventHandler(this.strip_i_emp_Click);
            // 
            // tsmDepartment
            // 
            this.tsmDepartment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmComboDepartment});
            this.tsmDepartment.Name = "tsmDepartment";
            this.tsmDepartment.Size = new System.Drawing.Size(205, 28);
            this.tsmDepartment.Text = "부서별사원대장";
            // 
            // tsmComboDepartment
            // 
            this.tsmComboDepartment.Items.AddRange(new object[] {
            "전체부서",
            "총무부",
            "경리부",
            "경영기획실",
            "마케팅부",
            "영업부"});
            this.tsmComboDepartment.Name = "tsmComboDepartment";
            this.tsmComboDepartment.Size = new System.Drawing.Size(180, 28);
            this.tsmComboDepartment.Text = "선택";
            this.tsmComboDepartment.TextChanged += new System.EventHandler(this.tsmComboDepartment_TextChanged);
            // 
            // tsmPosition
            // 
            this.tsmPosition.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmComboPosition});
            this.tsmPosition.Name = "tsmPosition";
            this.tsmPosition.Size = new System.Drawing.Size(205, 28);
            this.tsmPosition.Text = "직위별사원대장";
            // 
            // tsmComboPosition
            // 
            this.tsmComboPosition.Items.AddRange(new object[] {
            "전체 직위",
            "사장",
            "부사장",
            "전무",
            "부장",
            "과장",
            "대리",
            "사원"});
            this.tsmComboPosition.Name = "tsmComboPosition";
            this.tsmComboPosition.Size = new System.Drawing.Size(121, 28);
            this.tsmComboPosition.Text = "선택";
            this.tsmComboPosition.TextChanged += new System.EventHandler(this.tsmComboPosition_TextChanged);
            // 
            // tsmResign
            // 
            this.tsmResign.Name = "tsmResign";
            this.tsmResign.Size = new System.Drawing.Size(205, 28);
            this.tsmResign.Text = "퇴직사원대장";
            this.tsmResign.Click += new System.EventHandler(this.tsmResign_Click);
            // 
            // strip_serch
            // 
            this.strip_serch.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strip_s_dp,
            this.strip_s_dr,
            this.strip_s_dpr});
            this.strip_serch.Name = "strip_serch";
            this.strip_serch.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.S)));
            this.strip_serch.Size = new System.Drawing.Size(129, 27);
            this.strip_serch.Text = "대상자검색(&S)";
            // 
            // strip_s_dp
            // 
            this.strip_s_dp.Name = "strip_s_dp";
            this.strip_s_dp.Size = new System.Drawing.Size(202, 28);
            this.strip_s_dp.Text = "부서/직위";
            this.strip_s_dp.Click += new System.EventHandler(this.strip_s_dp_Click);
            // 
            // strip_s_dr
            // 
            this.strip_s_dr.Name = "strip_s_dr";
            this.strip_s_dr.Size = new System.Drawing.Size(202, 28);
            this.strip_s_dr.Text = "부서/직급";
            this.strip_s_dr.Click += new System.EventHandler(this.strip_s_dr_Click);
            // 
            // strip_s_dpr
            // 
            this.strip_s_dpr.Name = "strip_s_dpr";
            this.strip_s_dpr.Size = new System.Drawing.Size(202, 28);
            this.strip_s_dpr.Text = "부서/직위/직급";
            this.strip_s_dpr.Click += new System.EventHandler(this.strip_s_dpr_Click);
            // 
            // 인사통계ToolStripMenuItem
            // 
            this.인사통계ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmDnPNP,
            this.tsmDnDNP,
            this.tsmPnPNP});
            this.인사통계ToolStripMenuItem.Name = "인사통계ToolStripMenuItem";
            this.인사통계ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.T)));
            this.인사통계ToolStripMenuItem.Size = new System.Drawing.Size(112, 27);
            this.인사통계ToolStripMenuItem.Text = "인사통계(&T)";
            // 
            // tsmDnPNP
            // 
            this.tsmDnPNP.Name = "tsmDnPNP";
            this.tsmDnPNP.Size = new System.Drawing.Size(269, 28);
            this.tsmDnPNP.Text = "소속별/직위별 인원현황";
            this.tsmDnPNP.Click += new System.EventHandler(this.tsmDnPNP_Click);
            // 
            // tsmDnDNP
            // 
            this.tsmDnDNP.Name = "tsmDnDNP";
            this.tsmDnDNP.Size = new System.Drawing.Size(269, 28);
            this.tsmDnDNP.Text = "소속별/근속별 인원현황";
            this.tsmDnDNP.Click += new System.EventHandler(this.tsmDnDNP_Click);
            // 
            // tsmPnPNP
            // 
            this.tsmPnPNP.Name = "tsmPnPNP";
            this.tsmPnPNP.Size = new System.Drawing.Size(269, 28);
            this.tsmPnPNP.Text = "직위별/근속별 인원현황";
            this.tsmPnPNP.Click += new System.EventHandler(this.tsmPnDNP_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuForm";
            this.Text = "인사정보관리";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuForm_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem strip_File;
        private System.Windows.Forms.ToolStripMenuItem strip_f_Exit;
        private System.Windows.Forms.ToolStripMenuItem strip_Person_r;
        private System.Windows.Forms.ToolStripMenuItem strip_p_body;
        private System.Windows.Forms.ToolStripMenuItem strip_p_family;
        private System.Windows.Forms.ToolStripMenuItem strip_p_licence;
        private System.Windows.Forms.ToolStripMenuItem strip_p_career;
        private System.Windows.Forms.ToolStripMenuItem strip_Information;
        private System.Windows.Forms.ToolStripMenuItem tsmEmp;
        private System.Windows.Forms.ToolStripMenuItem tsmDepartment;
        private System.Windows.Forms.ToolStripComboBox tsmComboDepartment;
        private System.Windows.Forms.ToolStripMenuItem tsmResign;
        private System.Windows.Forms.ToolStripMenuItem strip_serch;
        private System.Windows.Forms.ToolStripMenuItem strip_s_dp;
        private System.Windows.Forms.ToolStripMenuItem strip_s_dr;
        private System.Windows.Forms.ToolStripMenuItem strip_s_dpr;
        private System.Windows.Forms.ToolStripMenuItem 인사통계ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmPosition;
        private System.Windows.Forms.ToolStripComboBox tsmComboPosition;
        private System.Windows.Forms.ToolStripMenuItem tsmDnPNP;
        private System.Windows.Forms.ToolStripMenuItem tsmDnDNP;
        private System.Windows.Forms.ToolStripMenuItem tsmPnPNP;
    }
}