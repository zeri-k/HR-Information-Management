namespace PIM
{
    partial class DnRForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.txtJobRank = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.Col9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDnP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDnP)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(323, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 163;
            this.label5.Text = "직급";
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "",
            "총무부",
            "경리부",
            "경영기획실",
            "마케팅부",
            "영업부"});
            this.cmbDepartment.Location = new System.Drawing.Point(108, 21);
            this.cmbDepartment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(106, 20);
            this.cmbDepartment.TabIndex = 162;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(60, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 161;
            this.label4.Text = "부서";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(241, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 167;
            this.label1.Text = "AND";
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMenu.Location = new System.Drawing.Point(516, 13);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(102, 36);
            this.btnMenu.TabIndex = 166;
            this.btnMenu.Text = "메뉴";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // txtJobRank
            // 
            this.txtJobRank.Location = new System.Drawing.Point(371, 20);
            this.txtJobRank.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJobRank.Name = "txtJobRank";
            this.txtJobRank.Size = new System.Drawing.Size(36, 21);
            this.txtJobRank.TabIndex = 168;
            this.txtJobRank.TextChanged += new System.EventHandler(this.txtJobRank_TextChanged);
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label41.Location = new System.Drawing.Point(413, 23);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(25, 16);
            this.label41.TabIndex = 169;
            this.label41.Text = "급";
            // 
            // Col9
            // 
            this.Col9.HeaderText = "핸드폰번호";
            this.Col9.Name = "Col9";
            this.Col9.ReadOnly = true;
            // 
            // Col8
            // 
            this.Col8.HeaderText = "입사일";
            this.Col8.Name = "Col8";
            this.Col8.ReadOnly = true;
            // 
            // Col7
            // 
            this.Col7.HeaderText = "직무";
            this.Col7.Name = "Col7";
            this.Col7.ReadOnly = true;
            // 
            // Col6
            // 
            this.Col6.HeaderText = "직급";
            this.Col6.Name = "Col6";
            this.Col6.ReadOnly = true;
            // 
            // Col5
            // 
            this.Col5.HeaderText = "직위";
            this.Col5.Name = "Col5";
            this.Col5.ReadOnly = true;
            // 
            // Col4
            // 
            this.Col4.HeaderText = "부서";
            this.Col4.Name = "Col4";
            this.Col4.ReadOnly = true;
            // 
            // Col3
            // 
            this.Col3.HeaderText = "성명";
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "사번";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "번호";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            // 
            // dgvDnP
            // 
            this.dgvDnP.AllowUserToAddRows = false;
            this.dgvDnP.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDnP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDnP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDnP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col4,
            this.Col5,
            this.Col6,
            this.Col7,
            this.Col8,
            this.Col9});
            this.dgvDnP.Location = new System.Drawing.Point(1, 58);
            this.dgvDnP.Name = "dgvDnP";
            this.dgvDnP.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDnP.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDnP.RowTemplate.Height = 23;
            this.dgvDnP.Size = new System.Drawing.Size(945, 393);
            this.dgvDnP.TabIndex = 165;
            // 
            // DnRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 453);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.txtJobRank);
            this.Controls.Add(this.dgvDnP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbDepartment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMenu);
            this.Name = "DnRForm";
            this.Text = "대상자 검색 - 부서/직급";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DnRForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDnP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.TextBox txtJobRank;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridView dgvDnP;
    }
}