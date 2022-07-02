namespace benhvien
{
    partial class FrmQuanLyBN
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
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyBN));
            this.txtGhChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbllido = new System.Windows.Forms.Label();
            this.grbghichu = new System.Windows.Forms.GroupBox();
            this.btnthongke = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbbPhongKham = new System.Windows.Forms.ComboBox();
            this.dtpGiaTriBHYT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbGioitinh = new System.Windows.Forms.ComboBox();
            this.cbbDoiTuong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblquoctich = new System.Windows.Forms.Label();
            this.lblsobhyt = new System.Windows.Forms.Label();
            this.lbldantoc = new System.Windows.Forms.Label();
            this.dgvbenhnhan2 = new System.Windows.Forms.DataGridView();
            this.dgvma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvgt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoctich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doituong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobhyt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phongkham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbldiachi = new System.Windows.Forms.Label();
            this.txtquoctich = new System.Windows.Forms.TextBox();
            this.txtbhyt = new System.Windows.Forms.TextBox();
            this.txtdantoc = new System.Windows.Forms.TextBox();
            this.txtdiachi = new System.Windows.Forms.TextBox();
            this.lbldoituong = new System.Windows.Forms.Label();
            this.txtnghe = new System.Windows.Forms.TextBox();
            this.txthoten = new System.Windows.Forms.TextBox();
            this.lblnghenghiep = new System.Windows.Forms.Label();
            this.txtmabenh = new System.Windows.Forms.TextBox();
            this.lblma = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grbbenhan = new System.Windows.Forms.GroupBox();
            this.grbghichu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbenhnhan2)).BeginInit();
            this.grbbenhan.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtGhChu
            // 
            this.txtGhChu.Location = new System.Drawing.Point(15, 41);
            this.txtGhChu.Multiline = true;
            this.txtGhChu.Name = "txtGhChu";
            this.txtGhChu.Size = new System.Drawing.Size(362, 70);
            this.txtGhChu.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(592, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phòng Khám";
            // 
            // lbllido
            // 
            this.lbllido.AutoSize = true;
            this.lbllido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllido.Location = new System.Drawing.Point(12, 21);
            this.lbllido.Name = "lbllido";
            this.lbllido.Size = new System.Drawing.Size(90, 18);
            this.lbllido.TabIndex = 0;
            this.lbllido.Text = "Lý Do Khám";
            // 
            // grbghichu
            // 
            this.grbghichu.BackColor = System.Drawing.Color.Transparent;
            this.grbghichu.Controls.Add(this.btnthongke);
            this.grbghichu.Controls.Add(this.txtGhChu);
            this.grbghichu.Controls.Add(this.btnXoa);
            this.grbghichu.Controls.Add(this.btnSua);
            this.grbghichu.Controls.Add(this.btnThem);
            this.grbghichu.Controls.Add(this.label1);
            this.grbghichu.Controls.Add(this.cbbPhongKham);
            this.grbghichu.Controls.Add(this.lbllido);
            this.grbghichu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbghichu.Location = new System.Drawing.Point(24, 244);
            this.grbghichu.Name = "grbghichu";
            this.grbghichu.Size = new System.Drawing.Size(969, 129);
            this.grbghichu.TabIndex = 33;
            this.grbghichu.TabStop = false;
            this.grbghichu.Text = "Ghi Chú";
            
            // 
            // btnthongke
            // 
            this.btnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.Image = global::benhvien.Properties.Resources.SEO_icon;
            this.btnthongke.Location = new System.Drawing.Point(821, 76);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(126, 35);
            this.btnthongke.TabIndex = 51;
            this.btnthongke.Text = "Thống Kê";
            this.btnthongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(697, 76);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(103, 35);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(559, 76);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(111, 34);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(432, 76);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 35);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbbPhongKham
            // 
            this.cbbPhongKham.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbPhongKham.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbPhongKham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbPhongKham.FormattingEnabled = true;
            this.cbbPhongKham.Items.AddRange(new object[] {
            "Đa Khoa\t",
            "Khoa Nội",
            "Khám Răng Hàm Mặt",
            "Khám Mắt",
            "Thận, Tiểu, Đường",
            "Khảm Sản"});
            this.cbbPhongKham.Location = new System.Drawing.Point(732, 20);
            this.cbbPhongKham.Name = "cbbPhongKham";
            this.cbbPhongKham.Size = new System.Drawing.Size(175, 26);
            this.cbbPhongKham.TabIndex = 0;
            // 
            // dtpGiaTriBHYT
            // 
            this.dtpGiaTriBHYT.CustomFormat = "dd/MM/yyyy";
            this.dtpGiaTriBHYT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGiaTriBHYT.Location = new System.Drawing.Point(731, 192);
            this.dtpGiaTriBHYT.Name = "dtpGiaTriBHYT";
            this.dtpGiaTriBHYT.Size = new System.Drawing.Size(176, 24);
            this.dtpGiaTriBHYT.TabIndex = 10;
            this.dtpGiaTriBHYT.Value = new System.DateTime(2021, 10, 22, 0, 0, 0, 0);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(731, 28);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(176, 24);
            this.dtpNgaySinh.TabIndex = 10;
            this.dtpNgaySinh.Value = new System.DateTime(2021, 10, 22, 0, 0, 0, 0);
            // 
            // cbbGioitinh
            // 
            this.cbbGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGioitinh.FormattingEnabled = true;
            this.cbbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbGioitinh.Location = new System.Drawing.Point(172, 94);
            this.cbbGioitinh.Name = "cbbGioitinh";
            this.cbbGioitinh.Size = new System.Drawing.Size(118, 25);
            this.cbbGioitinh.TabIndex = 2;
            // 
            // cbbDoiTuong
            // 
            this.cbbDoiTuong.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbDoiTuong.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbDoiTuong.FormattingEnabled = true;
            this.cbbDoiTuong.Items.AddRange(new object[] {
            "Miễn Phí",
            "BHYT",
            "Thu Phí",
            "Khác"});
            this.cbbDoiTuong.Location = new System.Drawing.Point(731, 105);
            this.cbbDoiTuong.Name = "cbbDoiTuong";
            this.cbbDoiTuong.Size = new System.Drawing.Size(175, 26);
            this.cbbDoiTuong.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(532, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gía Trị BHYT Đến Ngày";
            // 
            // lblquoctich
            // 
            this.lblquoctich.AutoSize = true;
            this.lblquoctich.Location = new System.Drawing.Point(25, 198);
            this.lblquoctich.Name = "lblquoctich";
            this.lblquoctich.Size = new System.Drawing.Size(77, 18);
            this.lblquoctich.TabIndex = 0;
            this.lblquoctich.Text = "Quốc Tịch";
            // 
            // lblsobhyt
            // 
            this.lblsobhyt.AutoSize = true;
            this.lblsobhyt.Location = new System.Drawing.Point(593, 152);
            this.lblsobhyt.Name = "lblsobhyt";
            this.lblsobhyt.Size = new System.Drawing.Size(70, 18);
            this.lblsobhyt.TabIndex = 0;
            this.lblsobhyt.Text = "Số BHYT";
            // 
            // lbldantoc
            // 
            this.lbldantoc.AutoSize = true;
            this.lbldantoc.Location = new System.Drawing.Point(25, 160);
            this.lbldantoc.Name = "lbldantoc";
            this.lbldantoc.Size = new System.Drawing.Size(60, 18);
            this.lbldantoc.TabIndex = 0;
            this.lbldantoc.Text = "Dân tộc";
            // 
            // dgvbenhnhan2
            // 
            this.dgvbenhnhan2.AllowUserToAddRows = false;
            this.dgvbenhnhan2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbenhnhan2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvma,
            this.dgvho,
            this.dgvgt,
            this.diachi,
            this.dgvdan,
            this.quoctich,
            this.dgvngay,
            this.dgvnghe,
            this.doituong,
            this.sobhyt,
            this.gia,
            this.phongkham,
            this.GHICHU});
            this.dgvbenhnhan2.Location = new System.Drawing.Point(24, 379);
            this.dgvbenhnhan2.Name = "dgvbenhnhan2";
            this.dgvbenhnhan2.RowHeadersWidth = 51;
            this.dgvbenhnhan2.RowTemplate.Height = 24;
            this.dgvbenhnhan2.Size = new System.Drawing.Size(969, 172);
            this.dgvbenhnhan2.TabIndex = 31;
            this.dgvbenhnhan2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvbenhnhan2_CellClick);
            // 
            // dgvma
            // 
            this.dgvma.HeaderText = "Mã bệnh nhân";
            this.dgvma.MinimumWidth = 6;
            this.dgvma.Name = "dgvma";
            this.dgvma.Width = 125;
            // 
            // dgvho
            // 
            this.dgvho.HeaderText = "Họ Tên";
            this.dgvho.MinimumWidth = 6;
            this.dgvho.Name = "dgvho";
            this.dgvho.Width = 125;
            // 
            // dgvgt
            // 
            this.dgvgt.HeaderText = "Ngày Sinh";
            this.dgvgt.MinimumWidth = 6;
            this.dgvgt.Name = "dgvgt";
            this.dgvgt.Width = 125;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Giới Tính";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // dgvdan
            // 
            this.dgvdan.HeaderText = "Địa Chỉ";
            this.dgvdan.MinimumWidth = 6;
            this.dgvdan.Name = "dgvdan";
            this.dgvdan.Width = 125;
            // 
            // quoctich
            // 
            this.quoctich.HeaderText = "Dân Tộc";
            this.quoctich.MinimumWidth = 6;
            this.quoctich.Name = "quoctich";
            this.quoctich.Width = 125;
            // 
            // dgvngay
            // 
            this.dgvngay.HeaderText = "Quốc Tịch";
            this.dgvngay.MinimumWidth = 6;
            this.dgvngay.Name = "dgvngay";
            this.dgvngay.Width = 125;
            // 
            // dgvnghe
            // 
            this.dgvnghe.HeaderText = "Nghề nghiệp";
            this.dgvnghe.MinimumWidth = 6;
            this.dgvnghe.Name = "dgvnghe";
            this.dgvnghe.Width = 125;
            // 
            // doituong
            // 
            this.doituong.HeaderText = "Đối Tượng";
            this.doituong.MinimumWidth = 6;
            this.doituong.Name = "doituong";
            this.doituong.Width = 125;
            // 
            // sobhyt
            // 
            this.sobhyt.HeaderText = "Số BHYT";
            this.sobhyt.MinimumWidth = 6;
            this.sobhyt.Name = "sobhyt";
            this.sobhyt.Width = 125;
            // 
            // gia
            // 
            this.gia.HeaderText = "Gía Trị BHYT";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.Width = 125;
            // 
            // phongkham
            // 
            this.phongkham.HeaderText = "Phòng Khám";
            this.phongkham.MinimumWidth = 6;
            this.phongkham.Name = "phongkham";
            this.phongkham.Width = 125;
            // 
            // GHICHU
            // 
            this.GHICHU.HeaderText = "Ghi Chú";
            this.GHICHU.MinimumWidth = 6;
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Width = 125;
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(25, 126);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(56, 18);
            this.lbldiachi.TabIndex = 0;
            this.lbldiachi.Text = "Địa Chỉ";
            // 
            // txtquoctich
            // 
            this.txtquoctich.Location = new System.Drawing.Point(172, 195);
            this.txtquoctich.Name = "txtquoctich";
            this.txtquoctich.Size = new System.Drawing.Size(218, 24);
            this.txtquoctich.TabIndex = 5;
            // 
            // txtbhyt
            // 
            this.txtbhyt.Location = new System.Drawing.Point(732, 146);
            this.txtbhyt.Name = "txtbhyt";
            this.txtbhyt.Size = new System.Drawing.Size(175, 24);
            this.txtbhyt.TabIndex = 9;
            // 
            // txtdantoc
            // 
            this.txtdantoc.Location = new System.Drawing.Point(172, 160);
            this.txtdantoc.Name = "txtdantoc";
            this.txtdantoc.Size = new System.Drawing.Size(218, 24);
            this.txtdantoc.TabIndex = 4;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(172, 126);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(218, 24);
            this.txtdiachi.TabIndex = 3;
            // 
            // lbldoituong
            // 
            this.lbldoituong.AutoSize = true;
            this.lbldoituong.Location = new System.Drawing.Point(593, 113);
            this.lbldoituong.Name = "lbldoituong";
            this.lbldoituong.Size = new System.Drawing.Size(77, 18);
            this.lbldoituong.TabIndex = 0;
            this.lbldoituong.Text = "Đối Tượng";
            // 
            // txtnghe
            // 
            this.txtnghe.Location = new System.Drawing.Point(731, 64);
            this.txtnghe.Name = "txtnghe";
            this.txtnghe.Size = new System.Drawing.Size(176, 24);
            this.txtnghe.TabIndex = 7;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(172, 60);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(218, 24);
            this.txthoten.TabIndex = 1;
            // 
            // lblnghenghiep
            // 
            this.lblnghenghiep.AutoSize = true;
            this.lblnghenghiep.Location = new System.Drawing.Point(593, 70);
            this.lblnghenghiep.Name = "lblnghenghiep";
            this.lblnghenghiep.Size = new System.Drawing.Size(93, 18);
            this.lblnghenghiep.TabIndex = 0;
            this.lblnghenghiep.Text = "Nghề Nghiệp";
            // 
            // txtmabenh
            // 
            this.txtmabenh.Location = new System.Drawing.Point(172, 27);
            this.txtmabenh.Name = "txtmabenh";
            this.txtmabenh.Size = new System.Drawing.Size(118, 24);
            this.txtmabenh.TabIndex = 0;
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Location = new System.Drawing.Point(25, 32);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(54, 18);
            this.lblma.TabIndex = 0;
            this.lblma.Text = "Mã BN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(25, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Họ tên ";
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Location = new System.Drawing.Point(25, 94);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(67, 18);
            this.lblgioitinh.TabIndex = 0;
            this.lblgioitinh.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Sinh ";
            // 
            // grbbenhan
            // 
            this.grbbenhan.BackColor = System.Drawing.Color.Transparent;
            this.grbbenhan.Controls.Add(this.dtpGiaTriBHYT);
            this.grbbenhan.Controls.Add(this.dtpNgaySinh);
            this.grbbenhan.Controls.Add(this.cbbGioitinh);
            this.grbbenhan.Controls.Add(this.cbbDoiTuong);
            this.grbbenhan.Controls.Add(this.label3);
            this.grbbenhan.Controls.Add(this.lblquoctich);
            this.grbbenhan.Controls.Add(this.lblsobhyt);
            this.grbbenhan.Controls.Add(this.lbldantoc);
            this.grbbenhan.Controls.Add(this.lbldiachi);
            this.grbbenhan.Controls.Add(this.txtquoctich);
            this.grbbenhan.Controls.Add(this.txtbhyt);
            this.grbbenhan.Controls.Add(this.txtdantoc);
            this.grbbenhan.Controls.Add(this.txtdiachi);
            this.grbbenhan.Controls.Add(this.lbldoituong);
            this.grbbenhan.Controls.Add(this.txtnghe);
            this.grbbenhan.Controls.Add(this.txthoten);
            this.grbbenhan.Controls.Add(this.lblnghenghiep);
            this.grbbenhan.Controls.Add(this.txtmabenh);
            this.grbbenhan.Controls.Add(this.lblma);
            this.grbbenhan.Controls.Add(this.label9);
            this.grbbenhan.Controls.Add(this.lblgioitinh);
            this.grbbenhan.Controls.Add(this.label2);
            this.grbbenhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbenhan.Location = new System.Drawing.Point(24, 12);
            this.grbbenhan.Name = "grbbenhan";
            this.grbbenhan.Size = new System.Drawing.Size(969, 226);
            this.grbbenhan.TabIndex = 32;
            this.grbbenhan.TabStop = false;
            this.grbbenhan.Text = "Thông Tin Bệnh Nhân";
            // FrmQuanLyBN
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1054, 561);
            this.Controls.Add(this.grbghichu);
            this.Controls.Add(this.dgvbenhnhan2);
            this.Controls.Add(this.grbbenhan);
            this.Name = "FrmQuanLyBN";
            this.Text = "FrmQuanLyBN";
            this.Load += new System.EventHandler(this.FrmQuanLyBN_Load);
            this.grbghichu.ResumeLayout(false);
            this.grbghichu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbenhnhan2)).EndInit();
            this.grbbenhan.ResumeLayout(false);
            this.grbbenhan.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.TextBox txtGhChu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbllido;
        private System.Windows.Forms.GroupBox grbghichu;
        private System.Windows.Forms.ComboBox cbbPhongKham;
        private System.Windows.Forms.DateTimePicker dtpGiaTriBHYT;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbbGioitinh;
        private System.Windows.Forms.ComboBox cbbDoiTuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblquoctich;
        private System.Windows.Forms.Label lblsobhyt;
        private System.Windows.Forms.Label lbldantoc;
        private System.Windows.Forms.DataGridView dgvbenhnhan2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvma;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvho;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvgt;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdan;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoctich;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn doituong;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobhyt;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongkham;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
        private System.Windows.Forms.Label lbldiachi;
        private System.Windows.Forms.TextBox txtquoctich;
        private System.Windows.Forms.TextBox txtbhyt;
        private System.Windows.Forms.TextBox txtdantoc;
        private System.Windows.Forms.TextBox txtdiachi;
        private System.Windows.Forms.Label lbldoituong;
        private System.Windows.Forms.TextBox txtnghe;
        private System.Windows.Forms.TextBox txthoten;
        private System.Windows.Forms.Label lblnghenghiep;
        private System.Windows.Forms.TextBox txtmabenh;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbbenhan;
        private System.Windows.Forms.Button btnthongke;
    }
}