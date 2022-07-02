namespace benhvien
{
    partial class FrmDonThuoc
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
            this.components = new System.ComponentModel.Container();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbbGioitinh = new System.Windows.Forms.ComboBox();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtmabenh = new System.Windows.Forms.TextBox();
            this.lblma = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.cbbMaThuoc = new System.Windows.Forms.ComboBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbbMoilan = new System.Windows.Forms.ComboBox();
            this.cbbNgayLan = new System.Windows.Forms.ComboBox();
            this.txtDonThuoc_MaBacSi = new System.Windows.Forms.TextBox();
            this.txtDonThuoc_TenBacSi = new System.Windows.Forms.TextBox();
            this.txtDonThuoc_SoLuong = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbbTenThuoc = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbbNhomThuoc = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDonThuoc_ThoiDiemSuDung = new System.Windows.Forms.TextBox();
            this.txtDonThuoc_LoiDan = new System.Windows.Forms.TextBox();
            this.dtPicker_GioTaoDonThuoc = new System.Windows.Forms.DateTimePicker();
            this.dateTimeNgayKe = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaDonThuoc = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvDSThuoc = new System.Windows.Forms.DataGridView();
            this.madonthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nhomthuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThoiDiemSuDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnTroVe = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThuoc)).BeginInit();
            this.guna2GroupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.cbbGioitinh);
            this.guna2GroupBox1.Controls.Add(this.lblgioitinh);
            this.guna2GroupBox1.Controls.Add(this.dtpNgaySinh);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.txthoten);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.txtmabenh);
            this.guna2GroupBox1.Controls.Add(this.lblma);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 0);
            this.guna2GroupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(747, 137);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Thông Tin Bệnh Nhân";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbGioitinh
            // 
            this.cbbGioitinh.Enabled = false;
            this.cbbGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGioitinh.FormattingEnabled = true;
            this.cbbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbGioitinh.Location = new System.Drawing.Point(491, 98);
            this.cbbGioitinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbGioitinh.Name = "cbbGioitinh";
            this.cbbGioitinh.Size = new System.Drawing.Size(119, 25);
            this.cbbGioitinh.TabIndex = 14;
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Location = new System.Drawing.Point(377, 103);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(68, 20);
            this.lblgioitinh.TabIndex = 13;
            this.lblgioitinh.Text = "Giới Tính";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(137, 98);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(119, 27);
            this.dtpNgaySinh.TabIndex = 12;
            this.dtpNgaySinh.Value = new System.DateTime(2021, 10, 22, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ngày Sinh ";
            // 
            // txthoten
            // 
            this.txthoten.Enabled = false;
            this.txthoten.Location = new System.Drawing.Point(491, 54);
            this.txthoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(196, 27);
            this.txthoten.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(377, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(58, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "Họ tên ";
            // 
            // txtmabenh
            // 
            this.txtmabenh.Enabled = false;
            this.txtmabenh.Location = new System.Drawing.Point(137, 50);
            this.txtmabenh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmabenh.Name = "txtmabenh";
            this.txtmabenh.Size = new System.Drawing.Size(119, 27);
            this.txtmabenh.TabIndex = 2;
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Location = new System.Drawing.Point(40, 57);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(54, 20);
            this.lblma.TabIndex = 1;
            this.lblma.Text = "Mã BN";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.cbbMaThuoc);
            this.guna2GroupBox2.Controls.Add(this.btnDelete);
            this.guna2GroupBox2.Controls.Add(this.btnAdd);
            this.guna2GroupBox2.Controls.Add(this.cbbMoilan);
            this.guna2GroupBox2.Controls.Add(this.cbbNgayLan);
            this.guna2GroupBox2.Controls.Add(this.txtDonThuoc_MaBacSi);
            this.guna2GroupBox2.Controls.Add(this.txtDonThuoc_TenBacSi);
            this.guna2GroupBox2.Controls.Add(this.txtDonThuoc_SoLuong);
            this.guna2GroupBox2.Controls.Add(this.label16);
            this.guna2GroupBox2.Controls.Add(this.label13);
            this.guna2GroupBox2.Controls.Add(this.cbbTenThuoc);
            this.guna2GroupBox2.Controls.Add(this.label12);
            this.guna2GroupBox2.Controls.Add(this.cbbNhomThuoc);
            this.guna2GroupBox2.Controls.Add(this.label8);
            this.guna2GroupBox2.Controls.Add(this.label7);
            this.guna2GroupBox2.Controls.Add(this.label11);
            this.guna2GroupBox2.Controls.Add(this.label10);
            this.guna2GroupBox2.Controls.Add(this.txtDonThuoc_ThoiDiemSuDung);
            this.guna2GroupBox2.Controls.Add(this.txtDonThuoc_LoiDan);
            this.guna2GroupBox2.Controls.Add(this.dtPicker_GioTaoDonThuoc);
            this.guna2GroupBox2.Controls.Add(this.dateTimeNgayKe);
            this.guna2GroupBox2.Controls.Add(this.label6);
            this.guna2GroupBox2.Controls.Add(this.label5);
            this.guna2GroupBox2.Controls.Add(this.label4);
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.Controls.Add(this.label1);
            this.guna2GroupBox2.Controls.Add(this.txtMaDonThuoc);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(3, 143);
            this.guna2GroupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.Size = new System.Drawing.Size(747, 347);
            this.guna2GroupBox2.TabIndex = 1;
            this.guna2GroupBox2.Text = "Thông Tin Đơn Thuốc";
            this.guna2GroupBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbbMaThuoc
            // 
            this.cbbMaThuoc.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaThuoc.FormattingEnabled = true;
            this.cbbMaThuoc.Location = new System.Drawing.Point(156, 207);
            this.cbbMaThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaThuoc.Name = "cbbMaThuoc";
            this.cbbMaThuoc.Size = new System.Drawing.Size(99, 25);
            this.cbbMaThuoc.TabIndex = 65;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightGray;
            this.btnDelete.Image = global::benhvien.Properties.Resources.icons8_delete_30;
            this.btnDelete.Location = new System.Drawing.Point(635, 290);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(69, 43);
            this.btnDelete.TabIndex = 64;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGray;
            this.btnAdd.BackgroundImage = global::benhvien.Properties.Resources.icons8_add_30;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAdd.CausesValidation = false;
            this.btnAdd.Image = global::benhvien.Properties.Resources.icons8_add_30;
            this.btnAdd.Location = new System.Drawing.Point(557, 290);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(69, 43);
            this.btnAdd.TabIndex = 63;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbbMoilan
            // 
            this.cbbMoilan.FormattingEnabled = true;
            this.cbbMoilan.Location = new System.Drawing.Point(557, 215);
            this.cbbMoilan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMoilan.Name = "cbbMoilan";
            this.cbbMoilan.Size = new System.Drawing.Size(140, 28);
            this.cbbMoilan.TabIndex = 62;
            // 
            // cbbNgayLan
            // 
            this.cbbNgayLan.FormattingEnabled = true;
            this.cbbNgayLan.Location = new System.Drawing.Point(556, 174);
            this.cbbNgayLan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNgayLan.Name = "cbbNgayLan";
            this.cbbNgayLan.Size = new System.Drawing.Size(141, 28);
            this.cbbNgayLan.TabIndex = 61;
            // 
            // txtDonThuoc_MaBacSi
            // 
            this.txtDonThuoc_MaBacSi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDonThuoc_MaBacSi.Enabled = false;
            this.txtDonThuoc_MaBacSi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonThuoc_MaBacSi.Location = new System.Drawing.Point(556, 57);
            this.txtDonThuoc_MaBacSi.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtDonThuoc_MaBacSi.Name = "txtDonThuoc_MaBacSi";
            this.txtDonThuoc_MaBacSi.ReadOnly = true;
            this.txtDonThuoc_MaBacSi.Size = new System.Drawing.Size(91, 26);
            this.txtDonThuoc_MaBacSi.TabIndex = 58;
            // 
            // txtDonThuoc_TenBacSi
            // 
            this.txtDonThuoc_TenBacSi.BackColor = System.Drawing.SystemColors.Window;
            this.txtDonThuoc_TenBacSi.Enabled = false;
            this.txtDonThuoc_TenBacSi.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonThuoc_TenBacSi.Location = new System.Drawing.Point(556, 94);
            this.txtDonThuoc_TenBacSi.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtDonThuoc_TenBacSi.Name = "txtDonThuoc_TenBacSi";
            this.txtDonThuoc_TenBacSi.ReadOnly = true;
            this.txtDonThuoc_TenBacSi.Size = new System.Drawing.Size(164, 26);
            this.txtDonThuoc_TenBacSi.TabIndex = 60;
            // 
            // txtDonThuoc_SoLuong
            // 
            this.txtDonThuoc_SoLuong.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonThuoc_SoLuong.Location = new System.Drawing.Point(556, 135);
            this.txtDonThuoc_SoLuong.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtDonThuoc_SoLuong.MaxLength = 3;
            this.txtDonThuoc_SoLuong.Name = "txtDonThuoc_SoLuong";
            this.txtDonThuoc_SoLuong.Size = new System.Drawing.Size(71, 26);
            this.txtDonThuoc_SoLuong.TabIndex = 54;
            this.txtDonThuoc_SoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonThuoc_SoLuong_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(460, 64);
            this.label16.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(71, 18);
            this.label16.TabIndex = 30;
            this.label16.Text = "Mã Bác sĩ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(460, 103);
            this.label13.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 18);
            this.label13.TabIndex = 29;
            this.label13.Text = "Bác sĩ";
            // 
            // cbbTenThuoc
            // 
            this.cbbTenThuoc.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenThuoc.FormattingEnabled = true;
            this.cbbTenThuoc.Location = new System.Drawing.Point(261, 207);
            this.cbbTenThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTenThuoc.Name = "cbbTenThuoc";
            this.cbbTenThuoc.Size = new System.Drawing.Size(159, 25);
            this.cbbTenThuoc.TabIndex = 53;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(460, 140);
            this.label12.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 18);
            this.label12.TabIndex = 28;
            this.label12.Text = "Số lượng";
            // 
            // cbbNhomThuoc
            // 
            this.cbbNhomThuoc.FormattingEnabled = true;
            this.cbbNhomThuoc.Location = new System.Drawing.Point(156, 171);
            this.cbbNhomThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNhomThuoc.Name = "cbbNhomThuoc";
            this.cbbNhomThuoc.Size = new System.Drawing.Size(263, 28);
            this.cbbNhomThuoc.TabIndex = 52;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(460, 180);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Liều";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 18);
            this.label7.TabIndex = 51;
            this.label7.Text = "Thời điểm sử dụng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(460, 224);
            this.label11.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 18);
            this.label11.TabIndex = 26;
            this.label11.Text = "Ngày";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(84, 303);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 18);
            this.label10.TabIndex = 50;
            this.label10.Text = "Lời dặn";
            // 
            // txtDonThuoc_ThoiDiemSuDung
            // 
            this.txtDonThuoc_ThoiDiemSuDung.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonThuoc_ThoiDiemSuDung.Location = new System.Drawing.Point(156, 246);
            this.txtDonThuoc_ThoiDiemSuDung.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtDonThuoc_ThoiDiemSuDung.Multiline = true;
            this.txtDonThuoc_ThoiDiemSuDung.Name = "txtDonThuoc_ThoiDiemSuDung";
            this.txtDonThuoc_ThoiDiemSuDung.Size = new System.Drawing.Size(263, 38);
            this.txtDonThuoc_ThoiDiemSuDung.TabIndex = 48;
            // 
            // txtDonThuoc_LoiDan
            // 
            this.txtDonThuoc_LoiDan.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonThuoc_LoiDan.Location = new System.Drawing.Point(156, 290);
            this.txtDonThuoc_LoiDan.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.txtDonThuoc_LoiDan.Multiline = true;
            this.txtDonThuoc_LoiDan.Name = "txtDonThuoc_LoiDan";
            this.txtDonThuoc_LoiDan.Size = new System.Drawing.Size(383, 43);
            this.txtDonThuoc_LoiDan.TabIndex = 49;
            // 
            // dtPicker_GioTaoDonThuoc
            // 
            this.dtPicker_GioTaoDonThuoc.CustomFormat = "hh : mm";
            this.dtPicker_GioTaoDonThuoc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker_GioTaoDonThuoc.Location = new System.Drawing.Point(156, 134);
            this.dtPicker_GioTaoDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPicker_GioTaoDonThuoc.Name = "dtPicker_GioTaoDonThuoc";
            this.dtPicker_GioTaoDonThuoc.ShowUpDown = true;
            this.dtPicker_GioTaoDonThuoc.Size = new System.Drawing.Size(81, 27);
            this.dtPicker_GioTaoDonThuoc.TabIndex = 42;
            this.dtPicker_GioTaoDonThuoc.Value = new System.DateTime(2011, 12, 1, 0, 0, 0, 0);
            // 
            // dateTimeNgayKe
            // 
            this.dateTimeNgayKe.CustomFormat = "dd/MM/yyyy";
            this.dateTimeNgayKe.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimeNgayKe.Location = new System.Drawing.Point(156, 94);
            this.dateTimeNgayKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimeNgayKe.Name = "dateTimeNgayKe";
            this.dateTimeNgayKe.Size = new System.Drawing.Size(113, 27);
            this.dateTimeNgayKe.TabIndex = 2;
            this.dateTimeNgayKe.ValueChanged += new System.EventHandler(this.dateTimeNgayKe_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tên Thuốc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nhóm Thuốc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(75, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Giờ Tạo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ngày Kê";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã Đơn Thuốc";
            // 
            // txtMaDonThuoc
            // 
            this.txtMaDonThuoc.Location = new System.Drawing.Point(156, 50);
            this.txtMaDonThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaDonThuoc.Name = "txtMaDonThuoc";
            this.txtMaDonThuoc.Size = new System.Drawing.Size(113, 27);
            this.txtMaDonThuoc.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dgvDSThuoc
            // 
            this.dgvDSThuoc.AllowUserToAddRows = false;
            this.dgvDSThuoc.AllowUserToDeleteRows = false;
            this.dgvDSThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.madonthuoc,
            this.nhomthuoc,
            this.TenThuoc,
            this.SoLuong,
            this.ThoiDiemSuDung});
            this.dgvDSThuoc.Location = new System.Drawing.Point(3, 43);
            this.dgvDSThuoc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDSThuoc.Name = "dgvDSThuoc";
            this.dgvDSThuoc.RowHeadersWidth = 51;
            this.dgvDSThuoc.RowTemplate.Height = 24;
            this.dgvDSThuoc.Size = new System.Drawing.Size(741, 134);
            this.dgvDSThuoc.TabIndex = 3;
            // 
            // madonthuoc
            // 
            this.madonthuoc.HeaderText = "Mã DT";
            this.madonthuoc.MinimumWidth = 6;
            this.madonthuoc.Name = "madonthuoc";
            this.madonthuoc.Width = 125;
            // 
            // nhomthuoc
            // 
            this.nhomthuoc.HeaderText = "Nhóm Thuốc";
            this.nhomthuoc.MinimumWidth = 6;
            this.nhomthuoc.Name = "nhomthuoc";
            this.nhomthuoc.Width = 125;
            // 
            // TenThuoc
            // 
            this.TenThuoc.DataPropertyName = "TenThuoc";
            this.TenThuoc.HeaderText = "Tên thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 125;
            // 
            // ThoiDiemSuDung
            // 
            this.ThoiDiemSuDung.DataPropertyName = "ThoiDiemSuDung";
            this.ThoiDiemSuDung.HeaderText = "Thời điểm sử dụng";
            this.ThoiDiemSuDung.MinimumWidth = 8;
            this.ThoiDiemSuDung.Name = "ThoiDiemSuDung";
            this.ThoiDiemSuDung.Width = 170;
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.dgvDSThuoc);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox3.Location = new System.Drawing.Point(3, 496);
            this.guna2GroupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.Size = new System.Drawing.Size(747, 180);
            this.guna2GroupBox3.TabIndex = 3;
            this.guna2GroupBox3.Text = "Danh Sách Thuốc";
            this.guna2GroupBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnluu
            // 
            this.btnluu.BackColor = System.Drawing.Color.LightGray;
            this.btnluu.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnluu.Image = global::benhvien.Properties.Resources.icons8_save_30;
            this.btnluu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnluu.Location = new System.Drawing.Point(404, 682);
            this.btnluu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(99, 42);
            this.btnluu.TabIndex = 5;
            this.btnluu.Text = "    Lưu";
            this.btnluu.UseVisualStyleBackColor = false;
            this.btnluu.Click += new System.EventHandler(this.btn_luu);
            // 
            // btnTroVe
            // 
            this.btnTroVe.BackColor = System.Drawing.Color.LightGray;
            this.btnTroVe.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTroVe.Image = global::benhvien.Properties.Resources.icons8_back_32;
            this.btnTroVe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTroVe.Location = new System.Drawing.Point(292, 682);
            this.btnTroVe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTroVe.Name = "btnTroVe";
            this.btnTroVe.Size = new System.Drawing.Size(99, 42);
            this.btnTroVe.TabIndex = 4;
            this.btnTroVe.Text = "Trở Về";
            this.btnTroVe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTroVe.UseVisualStyleBackColor = false;
            this.btnTroVe.Click += new System.EventHandler(this.btnTroVe_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.Color.LightGray;
            this.btnDong.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Image = global::benhvien.Properties.Resources.icons8_close_30;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(619, 682);
            this.btnDong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(99, 42);
            this.btnDong.TabIndex = 4;
            this.btnDong.Text = "     Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.Color.LightGray;
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = global::benhvien.Properties.Resources.icons8_print_30;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(513, 682);
            this.btnIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(99, 42);
            this.btnIn.TabIndex = 4;
            this.btnIn.Text = "  In";
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 736);
            this.panel1.TabIndex = 15;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(749, 736);
            this.crystalReportViewer1.TabIndex = 66;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.crystalReportViewer1.Visible = false;
            // 
            // FrmDonThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(749, 736);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnluu);
            this.Controls.Add(this.btnTroVe);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmDonThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đơn Thuốc Bệnh Nhân";
            this.Load += new System.EventHandler(this.FrmDonThuoc_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSThuoc)).EndInit();
            this.guna2GroupBox3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.TextBox txtmabenh;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbbGioitinh;
        private System.Windows.Forms.Label lblgioitinh;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.DateTimePicker dtPicker_GioTaoDonThuoc;
        private System.Windows.Forms.DateTimePicker dateTimeNgayKe;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaDonThuoc;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtDonThuoc_ThoiDiemSuDung;
        private System.Windows.Forms.TextBox txtDonThuoc_LoiDan;
        private System.Windows.Forms.ComboBox cbbTenThuoc;
        private System.Windows.Forms.ComboBox cbbNhomThuoc;
        private System.Windows.Forms.ComboBox cbbMoilan;
        private System.Windows.Forms.ComboBox cbbNgayLan;
        private System.Windows.Forms.TextBox txtDonThuoc_MaBacSi;
        private System.Windows.Forms.TextBox txtDonThuoc_TenBacSi;
        private System.Windows.Forms.TextBox txtDonThuoc_SoLuong;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvDSThuoc;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTroVe;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.ComboBox cbbMaThuoc;
        private System.Windows.Forms.Panel panel1;
        public CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn madonthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nhomthuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenThuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThoiDiemSuDung;
    }
}