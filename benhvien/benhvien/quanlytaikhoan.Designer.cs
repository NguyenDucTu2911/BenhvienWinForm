namespace benhvien
{
    partial class quanlytaikhoan
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
            this.datataikhoan = new System.Windows.Forms.DataGridView();
            this.Manhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTong = new System.Windows.Forms.Label();
            this.grbthongtin = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbmanhom = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.btnHienMatKhau = new System.Windows.Forms.Button();
            this.lbltaikhoan = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.txttk = new System.Windows.Forms.TextBox();
            this.lblmk = new System.Windows.Forms.Label();
            this.btnXoa = new Guna.UI2.WinForms.Guna2Button();
            this.btnSua = new Guna.UI2.WinForms.Guna2Button();
            this.btnthem = new Guna.UI2.WinForms.Guna2Button();
            this.txttim = new System.Windows.Forms.TextBox();
            this.lblNhapMaBS = new System.Windows.Forms.Label();
            this.txttennhom = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datataikhoan)).BeginInit();
            this.grbthongtin.SuspendLayout();
            this.SuspendLayout();
            // 
            // datataikhoan
            // 
            this.datataikhoan.AllowUserToAddRows = false;
            this.datataikhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datataikhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datataikhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manhom,
            this.tennhom,
            this.hoten,
            this.chucvu,
            this.Taikhoan,
            this.Matkhau});
            this.datataikhoan.Location = new System.Drawing.Point(17, 205);
            this.datataikhoan.Margin = new System.Windows.Forms.Padding(2);
            this.datataikhoan.Name = "datataikhoan";
            this.datataikhoan.RowHeadersWidth = 51;
            this.datataikhoan.RowTemplate.Height = 24;
            this.datataikhoan.Size = new System.Drawing.Size(756, 185);
            this.datataikhoan.TabIndex = 49;
            this.datataikhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datataikhoan_CellClick_2);
            // 
            // Manhom
            // 
            this.Manhom.HeaderText = "Mã Nhóm";
            this.Manhom.Name = "Manhom";
            // 
            // tennhom
            // 
            this.tennhom.HeaderText = "Tên Nhóm";
            this.tennhom.Name = "tennhom";
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Họ Tên";
            this.hoten.Name = "hoten";
            // 
            // chucvu
            // 
            this.chucvu.HeaderText = "Chức Vụ";
            this.chucvu.Name = "chucvu";
            // 
            // Taikhoan
            // 
            this.Taikhoan.HeaderText = "Tài Khoản";
            this.Taikhoan.MinimumWidth = 6;
            this.Taikhoan.Name = "Taikhoan";
            // 
            // Matkhau
            // 
            this.Matkhau.HeaderText = "Mật khẩu";
            this.Matkhau.MinimumWidth = 6;
            this.Matkhau.Name = "Matkhau";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(249, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 25);
            this.label1.TabIndex = 45;
            this.label1.Text = "Quản Lý Thông Tin Tài Khoản";
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.BackColor = System.Drawing.Color.Transparent;
            this.lblTong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.Location = new System.Drawing.Point(652, 36);
            this.lblTong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(94, 17);
            this.lblTong.TabIndex = 47;
            this.lblTong.Text = "Số Tài Khoản";
            // 
            // grbthongtin
            // 
            this.grbthongtin.BackColor = System.Drawing.Color.Transparent;
            this.grbthongtin.Controls.Add(this.txttennhom);
            this.grbthongtin.Controls.Add(this.label6);
            this.grbthongtin.Controls.Add(this.cbbmanhom);
            this.grbthongtin.Controls.Add(this.label5);
            this.grbthongtin.Controls.Add(this.label4);
            this.grbthongtin.Controls.Add(this.txtchucvu);
            this.grbthongtin.Controls.Add(this.label3);
            this.grbthongtin.Controls.Add(this.txthoten);
            this.grbthongtin.Controls.Add(this.btnHienMatKhau);
            this.grbthongtin.Controls.Add(this.lbltaikhoan);
            this.grbthongtin.Controls.Add(this.txtmk);
            this.grbthongtin.Controls.Add(this.txttk);
            this.grbthongtin.Controls.Add(this.lblmk);
            this.grbthongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbthongtin.Location = new System.Drawing.Point(17, 50);
            this.grbthongtin.Margin = new System.Windows.Forms.Padding(2);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Padding = new System.Windows.Forms.Padding(2);
            this.grbthongtin.Size = new System.Drawing.Size(756, 120);
            this.grbthongtin.TabIndex = 48;
            this.grbthongtin.TabStop = false;
            this.grbthongtin.Text = "Thông tin tài khoản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tên Nhóm";
            // 
            // cbbmanhom
            // 
            this.cbbmanhom.FormattingEnabled = true;
            this.cbbmanhom.Location = new System.Drawing.Point(373, 29);
            this.cbbmanhom.Name = "cbbmanhom";
            this.cbbmanhom.Size = new System.Drawing.Size(93, 25);
            this.cbbmanhom.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(299, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Mã Nhóm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 79);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Chức Vụ";
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(84, 76);
            this.txtchucvu.Margin = new System.Windows.Forms.Padding(2);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(142, 23);
            this.txtchucvu.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Họ Tên";
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(84, 31);
            this.txthoten.Margin = new System.Windows.Forms.Padding(2);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(142, 23);
            this.txthoten.TabIndex = 11;
            // 
            // btnHienMatKhau
            // 
            this.btnHienMatKhau.BackgroundImage = global::benhvien.Properties.Resources.iconShow;
            this.btnHienMatKhau.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnHienMatKhau.FlatAppearance.BorderSize = 0;
            this.btnHienMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHienMatKhau.Location = new System.Drawing.Point(709, 78);
            this.btnHienMatKhau.Margin = new System.Windows.Forms.Padding(2);
            this.btnHienMatKhau.Name = "btnHienMatKhau";
            this.btnHienMatKhau.Size = new System.Drawing.Size(26, 14);
            this.btnHienMatKhau.TabIndex = 8;
            this.btnHienMatKhau.UseVisualStyleBackColor = true;
            this.btnHienMatKhau.Click += new System.EventHandler(this.btnHienMatKhau_Click_2);
            // 
            // lbltaikhoan
            // 
            this.lbltaikhoan.AutoSize = true;
            this.lbltaikhoan.Location = new System.Drawing.Point(537, 36);
            this.lbltaikhoan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltaikhoan.Name = "lbltaikhoan";
            this.lbltaikhoan.Size = new System.Drawing.Size(71, 17);
            this.lbltaikhoan.TabIndex = 4;
            this.lbltaikhoan.Text = "Tài khoản";
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(624, 75);
            this.txtmk.Margin = new System.Windows.Forms.Padding(2);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(114, 23);
            this.txtmk.TabIndex = 1;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // txttk
            // 
            this.txttk.Location = new System.Drawing.Point(624, 34);
            this.txttk.Margin = new System.Windows.Forms.Padding(2);
            this.txttk.Name = "txttk";
            this.txttk.Size = new System.Drawing.Size(114, 23);
            this.txttk.TabIndex = 0;
            // 
            // lblmk
            // 
            this.lblmk.AutoSize = true;
            this.lblmk.Location = new System.Drawing.Point(542, 77);
            this.lblmk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblmk.Name = "lblmk";
            this.lblmk.Size = new System.Drawing.Size(66, 17);
            this.lblmk.TabIndex = 4;
            this.lblmk.Text = "Mật khẩu";
            // 
            // btnXoa
            // 
            this.btnXoa.AutoRoundedCorners = true;
            this.btnXoa.BorderRadius = 15;
            this.btnXoa.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoa.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoa.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoa.FillColor = System.Drawing.Color.IndianRed;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(657, 406);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(98, 32);
            this.btnXoa.TabIndex = 51;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.AutoRoundedCorners = true;
            this.btnSua.BorderRadius = 15;
            this.btnSua.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSua.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSua.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSua.FillColor = System.Drawing.Color.IndianRed;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(540, 407);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(98, 32);
            this.btnSua.TabIndex = 52;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.AutoRoundedCorners = true;
            this.btnthem.BorderRadius = 15;
            this.btnthem.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthem.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthem.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthem.FillColor = System.Drawing.Color.IndianRed;
            this.btnthem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnthem.ForeColor = System.Drawing.Color.White;
            this.btnthem.Location = new System.Drawing.Point(424, 407);
            this.btnthem.Margin = new System.Windows.Forms.Padding(2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(98, 32);
            this.btnthem.TabIndex = 53;
            this.btnthem.Text = "Thêm";
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(124, 177);
            this.txttim.Margin = new System.Windows.Forms.Padding(2);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(162, 20);
            this.txttim.TabIndex = 54;
            this.txttim.TextChanged += new System.EventHandler(this.txttim_TextChanged_2);
            // 
            // lblNhapMaBS
            // 
            this.lblNhapMaBS.AutoSize = true;
            this.lblNhapMaBS.BackColor = System.Drawing.Color.Transparent;
            this.lblNhapMaBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapMaBS.Location = new System.Drawing.Point(20, 178);
            this.lblNhapMaBS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhapMaBS.Name = "lblNhapMaBS";
            this.lblNhapMaBS.Size = new System.Drawing.Size(100, 17);
            this.lblNhapMaBS.TabIndex = 55;
            this.lblNhapMaBS.Text = "Tìm Tài Khoản";
            // 
            // txttennhom
            // 
            this.txttennhom.FormattingEnabled = true;
            this.txttennhom.Location = new System.Drawing.Point(373, 73);
            this.txttennhom.Name = "txttennhom";
            this.txttennhom.Size = new System.Drawing.Size(93, 25);
            this.txttennhom.TabIndex = 19;
            // 
            // quanlytaikhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 456);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.lblNhapMaBS);
            this.Controls.Add(this.datataikhoan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.grbthongtin);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnthem);
            this.Name = "quanlytaikhoan";
            this.Text = "quanlytaikhoan";
            this.Load += new System.EventHandler(this.quanlytaikhoan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datataikhoan)).EndInit();
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView datataikhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.GroupBox grbthongtin;
        private System.Windows.Forms.Label lbltaikhoan;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.TextBox txttk;
        private System.Windows.Forms.Label lblmk;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnthem;
        private System.Windows.Forms.Button btnHienMatKhau;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbbmanhom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taikhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matkhau;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label lblNhapMaBS;
        private System.Windows.Forms.ComboBox txttennhom;
    }
}