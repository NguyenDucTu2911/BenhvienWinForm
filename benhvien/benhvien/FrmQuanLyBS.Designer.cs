namespace benhvien
{
    partial class FrmQuanLyBS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyBS));
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbGioiTinh = new System.Windows.Forms.ComboBox();
            this.cbbkhoa = new System.Windows.Forms.ComboBox();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblgt = new System.Windows.Forms.Label();
            this.lblsdt = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.lblho = new System.Windows.Forms.Label();
            this.khoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblkhoa = new System.Windows.Forms.Label();
            this.txtma = new System.Windows.Forms.TextBox();
            this.gt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbacsi = new System.Windows.Forms.DataGridView();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBoxdsbs = new System.Windows.Forms.GroupBox();
            this.lblma = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbacsi)).BeginInit();
            this.groupBoxdsbs.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.HeaderText = "Địa Chỉ";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.Width = 125;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(197, 128);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(155, 22);
            this.dtpNgaySinh.TabIndex = 3;
            // 
            // cbbGioiTinh
            // 
            this.cbbGioiTinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbGioiTinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbGioiTinh.FormattingEnabled = true;
            this.cbbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbGioiTinh.Location = new System.Drawing.Point(197, 87);
            this.cbbGioiTinh.Name = "cbbGioiTinh";
            this.cbbGioiTinh.Size = new System.Drawing.Size(155, 24);
            this.cbbGioiTinh.TabIndex = 2;
            // 
            // cbbkhoa
            // 
            this.cbbkhoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbkhoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbkhoa.FormattingEnabled = true;
            this.cbbkhoa.Location = new System.Drawing.Point(576, 91);
            this.cbbkhoa.Name = "cbbkhoa";
            this.cbbkhoa.Size = new System.Drawing.Size(150, 24);
            this.cbbkhoa.TabIndex = 6;
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(576, 125);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(147, 22);
            this.txtchucvu.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(489, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Chức Vụ";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(90, 128);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(69, 16);
            this.lbldiachi.TabIndex = 0;
            this.lbldiachi.Text = "Ngày Sinh";
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(576, 22);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(147, 22);
            this.txtdiachi.TabIndex = 4;
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Location = new System.Drawing.Point(489, 25);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(49, 16);
            this.lblemail.TabIndex = 0;
            this.lblemail.Text = "Địa Chỉ";
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(576, 59);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(147, 22);
            this.txtsdt.TabIndex = 5;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(389, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 32);
            this.label1.TabIndex = 49;
            this.label1.Text = "Quản Lý Bác Sĩ";
            // 
            // lblgt
            // 
            this.lblgt.AutoSize = true;
            this.lblgt.Location = new System.Drawing.Point(90, 94);
            this.lblgt.Name = "lblgt";
            this.lblgt.Size = new System.Drawing.Size(60, 16);
            this.lblgt.TabIndex = 0;
            this.lblgt.Text = "Giới Tính";
            // 
            // lblsdt
            // 
            this.lblsdt.AutoSize = true;
            this.lblsdt.Location = new System.Drawing.Point(489, 59);
            this.lblsdt.Name = "lblsdt";
            this.lblsdt.Size = new System.Drawing.Size(35, 16);
            this.lblsdt.TabIndex = 0;
            this.lblsdt.Text = "SDT";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(197, 54);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(155, 22);
            this.txthoten.TabIndex = 1;
            // 
            // lblho
            // 
            this.lblho.AutoSize = true;
            this.lblho.Location = new System.Drawing.Point(90, 59);
            this.lblho.Name = "lblho";
            this.lblho.Size = new System.Drawing.Size(72, 16);
            this.lblho.TabIndex = 0;
            this.lblho.Text = "Họ Và Tên";
            // 
            // khoa
            // 
            this.khoa.HeaderText = "SĐT";
            this.khoa.MinimumWidth = 6;
            this.khoa.Name = "khoa";
            this.khoa.Width = 125;
            // 
            // lblkhoa
            // 
            this.lblkhoa.AutoSize = true;
            this.lblkhoa.Location = new System.Drawing.Point(489, 94);
            this.lblkhoa.Name = "lblkhoa";
            this.lblkhoa.Size = new System.Drawing.Size(38, 16);
            this.lblkhoa.TabIndex = 0;
            this.lblkhoa.Text = "Khoa";
            // 
            // txtma
            // 
            this.txtma.Location = new System.Drawing.Point(197, 22);
            this.txtma.Name = "txtma";
            this.txtma.Size = new System.Drawing.Size(155, 22);
            this.txtma.TabIndex = 0;
            // 
            // gt
            // 
            this.gt.HeaderText = "Giới Tính";
            this.gt.MinimumWidth = 6;
            this.gt.Name = "gt";
            this.gt.Width = 125;
            // 
            // HOTEN
            // 
            this.HOTEN.HeaderText = "Họ Tên";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 125;
            // 
            // ma
            // 
            this.ma.HeaderText = "Mã BS";
            this.ma.MinimumWidth = 6;
            this.ma.Name = "ma";
            this.ma.Width = 125;
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
            this.dgvbacsi.Location = new System.Drawing.Point(16, 21);
            this.dgvbacsi.Name = "dgvbacsi";
            this.dgvbacsi.RowHeadersWidth = 51;
            this.dgvbacsi.RowTemplate.Height = 24;
            this.dgvbacsi.Size = new System.Drawing.Size(817, 245);
            this.dgvbacsi.TabIndex = 0;
            this.dgvbacsi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbacsi_CellClick);
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Ngày Sinh";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // groupBoxdsbs
            // 
            this.groupBoxdsbs.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxdsbs.Controls.Add(this.dgvbacsi);
            this.groupBoxdsbs.Location = new System.Drawing.Point(85, 267);
            this.groupBoxdsbs.Name = "groupBoxdsbs";
            this.groupBoxdsbs.Size = new System.Drawing.Size(850, 281);
            this.groupBoxdsbs.TabIndex = 48;
            this.groupBoxdsbs.TabStop = false;
            this.groupBoxdsbs.Text = "Danh Sách Bác Sĩ";
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Location = new System.Drawing.Point(90, 25);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(70, 16);
            this.lblma.TabIndex = 0;
            this.lblma.Text = "Mã Bác Sĩ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.cbbGioiTinh);
            this.groupBox1.Controls.Add(this.cbbkhoa);
            this.groupBox1.Controls.Add(this.txtchucvu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbldiachi);
            this.groupBox1.Controls.Add(this.txtdiachi);
            this.groupBox1.Controls.Add(this.lblemail);
            this.groupBox1.Controls.Add(this.txtsdt);
            this.groupBox1.Controls.Add(this.lblgt);
            this.groupBox1.Controls.Add(this.lblsdt);
            this.groupBox1.Controls.Add(this.txthoten);
            this.groupBox1.Controls.Add(this.lblho);
            this.groupBox1.Controls.Add(this.lblkhoa);
            this.groupBox1.Controls.Add(this.txtma);
            this.groupBox1.Controls.Add(this.lblma);
            this.groupBox1.Location = new System.Drawing.Point(85, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(850, 166);
            this.groupBox1.TabIndex = 47;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Bác Sĩ";
            // 
            // btnsua
            // 
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(512, 227);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(81, 35);
            this.btnsua.TabIndex = 51;
            this.btnsua.Text = "Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(420, 227);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(83, 34);
            this.btnxoa.TabIndex = 52;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.Image = global::benhvien.Properties.Resources.SEO_icon;
            this.btnthongke.Location = new System.Drawing.Point(616, 227);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(128, 35);
            this.btnthongke.TabIndex = 50;
            this.btnthongke.Text = "Thống Kê";
            this.btnthongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // btnthem
            // 
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(320, 227);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(83, 34);
            this.btnthem.TabIndex = 53;
            this.btnthem.Text = "Thêm";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // FrmQuanLyBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 561);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnthongke);
            this.Controls.Add(this.groupBoxdsbs);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmQuanLyBS";
            this.Text = "FrmQuanLyBS";
            this.Load += new System.EventHandler(this.FrmQuanLyBS_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbacsi)).EndInit();
            this.groupBoxdsbs.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbbGioiTinh;
        private System.Windows.Forms.ComboBox cbbkhoa;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label lblemail;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblgt;
        private System.Windows.Forms.Label lblsdt;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label lblho;
        private System.Windows.Forms.DataGridViewTextBoxColumn khoa;
        private System.Windows.Forms.Label lblkhoa;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.TextBox txtma;
        private System.Windows.Forms.DataGridViewTextBoxColumn gt;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma;
        private System.Windows.Forms.DataGridView dgvbacsi;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.GroupBox groupBoxdsbs;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}