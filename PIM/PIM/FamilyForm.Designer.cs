namespace PIM
{
    partial class FamilyForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnMain = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmp_num = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbRelation = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBirthDay1 = new System.Windows.Forms.TextBox();
            this.txtBirthDay2 = new System.Windows.Forms.TextBox();
            this.txtBirthDay3 = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbHiEdu = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbCohabitation = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJob = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.dgvFamily = new System.Windows.Forms.DataGridView();
            this.Col1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamily)).BeginInit();
            this.SuspendLayout();
            // 
            // btnMain
            // 
            this.btnMain.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnMain.Location = new System.Drawing.Point(482, 479);
            this.btnMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMain.Name = "btnMain";
            this.btnMain.Size = new System.Drawing.Size(96, 54);
            this.btnMain.TabIndex = 167;
            this.btnMain.Text = "메인";
            this.btnMain.UseVisualStyleBackColor = true;
            this.btnMain.Click += new System.EventHandler(this.btnMain_Click);
            // 
            // btnDel
            // 
            this.btnDel.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnDel.Location = new System.Drawing.Point(371, 479);
            this.btnDel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(96, 54);
            this.btnDel.TabIndex = 166;
            this.btnDel.Text = "삭제";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnEdit.Location = new System.Drawing.Point(257, 479);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(96, 54);
            this.btnEdit.TabIndex = 165;
            this.btnEdit.Text = "수정";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnSearch.Location = new System.Drawing.Point(147, 479);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 54);
            this.btnSearch.TabIndex = 164;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnInsert.Location = new System.Drawing.Point(41, 479);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(96, 54);
            this.btnInsert.TabIndex = 163;
            this.btnInsert.Text = "입력";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(51, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 136;
            this.label1.Text = "사번";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(326, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 137;
            this.label2.Text = "이름";
            // 
            // txtEmp_num
            // 
            this.txtEmp_num.Location = new System.Drawing.Point(126, 34);
            this.txtEmp_num.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmp_num.Name = "txtEmp_num";
            this.txtEmp_num.Size = new System.Drawing.Size(122, 25);
            this.txtEmp_num.TabIndex = 138;
            this.txtEmp_num.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(398, 34);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 25);
            this.txtName.TabIndex = 139;
            this.txtName.TabStop = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label14.Location = new System.Drawing.Point(266, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 17);
            this.label14.TabIndex = 140;
            this.label14.Text = "2.관계";
            // 
            // cmbRelation
            // 
            this.cmbRelation.FormattingEnabled = true;
            this.cmbRelation.Location = new System.Drawing.Point(358, 102);
            this.cmbRelation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRelation.Name = "cmbRelation";
            this.cmbRelation.Size = new System.Drawing.Size(121, 23);
            this.cmbRelation.TabIndex = 141;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(507, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(95, 17);
            this.label10.TabIndex = 142;
            this.label10.Text = "3.생년월일";
            // 
            // txtBirthDay1
            // 
            this.txtBirthDay1.Location = new System.Drawing.Point(606, 105);
            this.txtBirthDay1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirthDay1.Name = "txtBirthDay1";
            this.txtBirthDay1.Size = new System.Drawing.Size(53, 25);
            this.txtBirthDay1.TabIndex = 143;
            // 
            // txtBirthDay2
            // 
            this.txtBirthDay2.Location = new System.Drawing.Point(686, 105);
            this.txtBirthDay2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirthDay2.Name = "txtBirthDay2";
            this.txtBirthDay2.Size = new System.Drawing.Size(41, 25);
            this.txtBirthDay2.TabIndex = 144;
            // 
            // txtBirthDay3
            // 
            this.txtBirthDay3.Location = new System.Drawing.Point(753, 105);
            this.txtBirthDay3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBirthDay3.Name = "txtBirthDay3";
            this.txtBirthDay3.Size = new System.Drawing.Size(41, 25);
            this.txtBirthDay3.TabIndex = 145;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(665, 108);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(15, 15);
            this.label30.TabIndex = 146;
            this.label30.Text = "-";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(731, 108);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(15, 15);
            this.label31.TabIndex = 147;
            this.label31.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(25, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 148;
            this.label3.Text = "1.가족성명";
            // 
            // txtFName
            // 
            this.txtFName.Location = new System.Drawing.Point(123, 102);
            this.txtFName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFName.Name = "txtFName";
            this.txtFName.Size = new System.Drawing.Size(122, 25);
            this.txtFName.TabIndex = 149;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(25, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 150;
            this.label4.Text = "4.학력";
            // 
            // cmbHiEdu
            // 
            this.cmbHiEdu.FormattingEnabled = true;
            this.cmbHiEdu.Location = new System.Drawing.Point(122, 150);
            this.cmbHiEdu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbHiEdu.Name = "cmbHiEdu";
            this.cmbHiEdu.Size = new System.Drawing.Size(121, 23);
            this.cmbHiEdu.TabIndex = 151;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(266, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 17);
            this.label5.TabIndex = 152;
            this.label5.Text = "5.동거여부";
            // 
            // cmbCohabitation
            // 
            this.cmbCohabitation.FormattingEnabled = true;
            this.cmbCohabitation.Location = new System.Drawing.Point(358, 150);
            this.cmbCohabitation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCohabitation.Name = "cmbCohabitation";
            this.cmbCohabitation.Size = new System.Drawing.Size(121, 23);
            this.cmbCohabitation.TabIndex = 153;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(507, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 154;
            this.label6.Text = "5.직업";
            // 
            // txtJob
            // 
            this.txtJob.Location = new System.Drawing.Point(606, 150);
            this.txtJob.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtJob.Name = "txtJob";
            this.txtJob.Size = new System.Drawing.Size(122, 25);
            this.txtJob.TabIndex = 155;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnExit.Location = new System.Drawing.Point(585, 479);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(96, 54);
            this.btnExit.TabIndex = 168;
            this.btnExit.Text = "종료";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // dgvFamily
            // 
            this.dgvFamily.AllowUserToAddRows = false;
            this.dgvFamily.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFamily.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFamily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFamily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Col1,
            this.Col2,
            this.Col3,
            this.Col4,
            this.Col5,
            this.Col6,
            this.Col7});
            this.dgvFamily.Location = new System.Drawing.Point(30, 194);
            this.dgvFamily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFamily.Name = "dgvFamily";
            this.dgvFamily.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dgvFamily.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvFamily.RowTemplate.Height = 23;
            this.dgvFamily.Size = new System.Drawing.Size(849, 264);
            this.dgvFamily.TabIndex = 169;
            this.dgvFamily.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFamliy_CellClick);
            // 
            // Col1
            // 
            this.Col1.HeaderText = "번호";
            this.Col1.Name = "Col1";
            this.Col1.ReadOnly = true;
            // 
            // Col2
            // 
            this.Col2.HeaderText = "가족성명";
            this.Col2.Name = "Col2";
            this.Col2.ReadOnly = true;
            // 
            // Col3
            // 
            this.Col3.HeaderText = "관계";
            this.Col3.Name = "Col3";
            this.Col3.ReadOnly = true;
            // 
            // Col4
            // 
            this.Col4.HeaderText = "생년월일";
            this.Col4.Name = "Col4";
            this.Col4.ReadOnly = true;
            // 
            // Col5
            // 
            this.Col5.HeaderText = "학력";
            this.Col5.Name = "Col5";
            this.Col5.ReadOnly = true;
            // 
            // Col6
            // 
            this.Col6.HeaderText = "동거여부";
            this.Col6.Name = "Col6";
            this.Col6.ReadOnly = true;
            // 
            // Col7
            // 
            this.Col7.HeaderText = "직업";
            this.Col7.Name = "Col7";
            this.Col7.ReadOnly = true;
            // 
            // FamilyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 562);
            this.Controls.Add(this.dgvFamily);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnMain);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCohabitation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbHiEdu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txtBirthDay3);
            this.Controls.Add(this.txtBirthDay2);
            this.Controls.Add(this.txtBirthDay1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cmbRelation);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtEmp_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FamilyForm";
            this.Text = "가족사항";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FamilyForm_FormClosed);
            this.Load += new System.EventHandler(this.FamilyForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFamily)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnMain;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmp_num;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbRelation;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBirthDay1;
        private System.Windows.Forms.TextBox txtBirthDay2;
        private System.Windows.Forms.TextBox txtBirthDay3;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbHiEdu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbCohabitation;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJob;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.DataGridView dgvFamily;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col7;
    }
}