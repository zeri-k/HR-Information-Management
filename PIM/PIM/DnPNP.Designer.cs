namespace PIM
{
    partial class DnPNP
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
            this.dgvDnPNP = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDnPNP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDnPNP
            // 
            this.dgvDnPNP.AllowUserToAddRows = false;
            this.dgvDnPNP.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDnPNP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDnPNP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDnPNP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col4,
            this.Col5,
            this.Col6,
            this.Col7,
            this.Col8,
            this.Col9});
            this.dgvDnPNP.Location = new System.Drawing.Point(2, 97);
            this.dgvDnPNP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDnPNP.Name = "dgvDnPNP";
            this.dgvDnPNP.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvDnPNP.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDnPNP.RowTemplate.Height = 23;
            this.dgvDnPNP.Size = new System.Drawing.Size(945, 439);
            this.dgvDnPNP.TabIndex = 0;
            // 
            // Col1
            // 
            this.Col1.HeaderText = "구분";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "사장";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            // 
            // Col3
            // 
            this.Col3.HeaderText = "부사장";
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            // 
            // Col4
            // 
            this.Col4.HeaderText = "전무";
            this.Col4.Name = "Col4";
            this.Col4.ReadOnly = true;
            // 
            // Col5
            // 
            this.Col5.HeaderText = "부장";
            this.Col5.Name = "Col5";
            this.Col5.ReadOnly = true;
            // 
            // Col6
            // 
            this.Col6.HeaderText = "과장";
            this.Col6.Name = "Col6";
            this.Col6.ReadOnly = true;
            // 
            // Col7
            // 
            this.Col7.HeaderText = "대리";
            this.Col7.Name = "Col7";
            this.Col7.ReadOnly = true;
            // 
            // Col8
            // 
            this.Col8.HeaderText = "사원";
            this.Col8.Name = "Col8";
            this.Col8.ReadOnly = true;
            // 
            // Col9
            // 
            this.Col9.HeaderText = "합계";
            this.Col9.Name = "Col9";
            this.Col9.ReadOnly = true;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMenu.Location = new System.Drawing.Point(12, 12);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(140, 60);
            this.btnMenu.TabIndex = 3;
            this.btnMenu.Text = "메뉴";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // DnPNP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 539);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.dgvDnPNP);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "DnPNP";
            this.Text = "소속별/직위별 인원 현황";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DnPNP_FormClosed);
            this.Load += new System.EventHandler(this.DnPNP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDnPNP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDnPNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col9;
        private System.Windows.Forms.Button btnMenu;
    }
}