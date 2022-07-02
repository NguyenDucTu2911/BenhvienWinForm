namespace benhvien
{
    partial class Frmbacsi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmbacsi));
            this.lblTong = new System.Windows.Forms.Label();
            this.comboBoxthomhke = new System.Windows.Forms.ComboBox();
            this.checkBoxbs = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.grbbacsi = new System.Windows.Forms.GroupBox();
            this.lblNhapMaBS = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.btnTimBS = new System.Windows.Forms.Button();
            this.dgvbacsi = new System.Windows.Forms.DataGridView();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.grbbacsi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbacsi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.BackColor = System.Drawing.Color.Transparent;
            this.lblTong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTong.Location = new System.Drawing.Point(39, 90);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(96, 23);
            this.lblTong.TabIndex = 29;
            this.lblTong.Text = "Số Bác Sĩ:";
            // 
            // comboBoxthomhke
            // 
            this.comboBoxthomhke.FormattingEnabled = true;
            this.comboBoxthomhke.Location = new System.Drawing.Point(42, 71);
            this.comboBoxthomhke.Name = "comboBoxthomhke";
            this.comboBoxthomhke.Size = new System.Drawing.Size(164, 26);
            this.comboBoxthomhke.TabIndex = 21;
            // 
            // checkBoxbs
            // 
            this.checkBoxbs.AutoSize = true;
            this.checkBoxbs.Location = new System.Drawing.Point(16, 38);
            this.checkBoxbs.Name = "checkBoxbs";
            this.checkBoxbs.Size = new System.Drawing.Size(171, 22);
            this.checkBoxbs.TabIndex = 20;
            this.checkBoxbs.Text = "Thống Kê Theo Khoa";
            this.checkBoxbs.UseVisualStyleBackColor = true;
            this.checkBoxbs.CheckedChanged += new System.EventHandler(this.checkBoxbs_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.comboBoxthomhke);
            this.groupBox1.Controls.Add(this.checkBoxbs);
            this.groupBox1.Controls.Add(this.btnthongke);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(549, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 116);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê bác sĩ";
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(360, 62);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(121, 43);
            this.btnIn.TabIndex = 22;
            this.btnIn.Text = "Export";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.Image = ((System.Drawing.Image)(resources.GetObject("btnthongke.Image")));
            this.btnthongke.Location = new System.Drawing.Point(212, 62);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(140, 43);
            this.btnthongke.TabIndex = 19;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // grbbacsi
            // 
            this.grbbacsi.BackColor = System.Drawing.Color.Transparent;
            this.grbbacsi.Controls.Add(this.lblTong);
            this.grbbacsi.Controls.Add(this.lblNhapMaBS);
            this.grbbacsi.Controls.Add(this.txtTim);
            this.grbbacsi.Controls.Add(this.btnTimBS);
            this.grbbacsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbacsi.Location = new System.Drawing.Point(13, 16);
            this.grbbacsi.Name = "grbbacsi";
            this.grbbacsi.Size = new System.Drawing.Size(488, 116);
            this.grbbacsi.TabIndex = 26;
            this.grbbacsi.TabStop = false;
            this.grbbacsi.Text = "Tìm kiếm thông tin bác sĩ";
            // 
            // lblNhapMaBS
            // 
            this.lblNhapMaBS.AutoSize = true;
            this.lblNhapMaBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapMaBS.Location = new System.Drawing.Point(16, 46);
            this.lblNhapMaBS.Name = "lblNhapMaBS";
            this.lblNhapMaBS.Size = new System.Drawing.Size(119, 20);
            this.lblNhapMaBS.TabIndex = 17;
            this.lblNhapMaBS.Text = "Họ Tên Bác Sĩ";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(148, 46);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(210, 24);
            this.txtTim.TabIndex = 0;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // btnTimBS
            // 
            this.btnTimBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimBS.Image = ((System.Drawing.Image)(resources.GetObject("btnTimBS.Image")));
            this.btnTimBS.Location = new System.Drawing.Point(382, 41);
            this.btnTimBS.Name = "btnTimBS";
            this.btnTimBS.Size = new System.Drawing.Size(93, 34);
            this.btnTimBS.TabIndex = 19;
            this.btnTimBS.Text = "Tìm";
            this.btnTimBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimBS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimBS.UseVisualStyleBackColor = true;
            this.btnTimBS.Click += new System.EventHandler(this.btnTimBS_Click);
            // 
            // dgvbacsi
            // 
            this.dgvbacsi.AllowUserToAddRows = false;
            this.dgvbacsi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbacsi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma,
            this.HOTEN,
            this.gt,
            this.diachi,
            this.email,
            this.khoa,
            this.chucvu,
            this.sdt});
            this.dgvbacsi.Location = new System.Drawing.Point(12, 155);
            this.dgvbacsi.Name = "dgvbacsi";
            this.dgvbacsi.RowHeadersWidth = 51;
            this.dgvbacsi.RowTemplate.Height = 24;
            this.dgvbacsi.Size = new System.Drawing.Size(1023, 422);
            this.dgvbacsi.TabIndex = 23;
            // 
            // ma
            // 
            this.ma.HeaderText = "Mã BS";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            this.ma.Width = 125;
            // 
            // HOTEN
            // 
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 125;
            // 
            // gt
            // 
            this.gt.HeaderText = "Giới Tính";
            this.gt.MinimumWidth = 6;
            this.gt.Name = "gt";
            this.gt.Width = 125;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Ngày Sinh";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // email
            // 
            this.email.HeaderText = "Địa Chỉ";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // khoa
            // 
            this.khoa.HeaderText = "SĐT";
            this.khoa.MinimumWidth = 6;
            this.khoa.Name = "khoa";
            this.khoa.Width = 125;
            // 
            // chucvu
            // 
            this.chucvu.HeaderText = "Khoa";
            this.chucvu.MinimumWidth = 6;
            this.chucvu.Name = "chucvu";
            this.chucvu.Width = 125;
            // 
            // sdt
            // 
            this.sdt.HeaderText = "Chức Vụ";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // Frmbacsi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 589);
            this.Controls.Add(this.dgvbacsi);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbbacsi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmbacsi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Bác Sĩ";
            this.Load += new System.EventHandler(this.Frmbacsi_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grbbacsi.ResumeLayout(false);
            this.grbbacsi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbacsi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ComboBox comboBoxthomhke;
        private System.Windows.Forms.CheckBox checkBoxbs;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grbbacsi;
        private System.Windows.Forms.Label lblNhapMaBS;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTimBS;
        private System.Windows.Forms.DataGridView dgvbacsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn gt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}