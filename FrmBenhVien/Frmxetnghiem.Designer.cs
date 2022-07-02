namespace benhvien
{
    partial class Frmxetnghiem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmxetnghiem));
            this.printDialog2 = new System.Windows.Forms.PrintDialog();
            this.printDocument2 = new System.Drawing.Printing.PrintDocument();
            this.cbbYeuCauXN = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextYauCau = new System.Windows.Forms.RichTextBox();
            this.richTextChuanDaon = new System.Windows.Forms.RichTextBox();
            this.groupBoxxeinghiem = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnxuat = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.grnkham = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbbTenBS = new System.Windows.Forms.ComboBox();
            this.cbbMaBS = new System.Windows.Forms.ComboBox();
            this.txtSODK = new System.Windows.Forms.TextBox();
            this.lbltiensu = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMaBN = new System.Windows.Forms.TextBox();
            this.cbbGioitinh = new System.Windows.Forms.ComboBox();
            this.lblgioitinh = new System.Windows.Forms.Label();
            this.lblma = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvXetNghiem = new System.Windows.Forms.DataGridView();
            this.sodk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mabn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotenbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENBS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YEUCAUXETNGIEM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chuandoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeucau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txttim = new System.Windows.Forms.TextBox();
            this.lbltim = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBoxxeinghiem.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbenhnhan2)).BeginInit();
            this.grnkham.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXetNghiem)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // printDialog2
            // 
            this.printDialog2.UseEXDialog = true;
            // 
            // cbbYeuCauXN
            // 
            this.cbbYeuCauXN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cbbYeuCauXN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.cbbYeuCauXN.FormattingEnabled = true;
            this.cbbYeuCauXN.Items.AddRange(new object[] {
            "Siêu âm",
            "Chụp-X-QUANG",
            "Xét Nghiệm Máu",
            "Xét Nghiệm Nước Tiểu"});
            this.cbbYeuCauXN.Location = new System.Drawing.Point(29, 78);
            this.cbbYeuCauXN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbYeuCauXN.Name = "cbbYeuCauXN";
            this.cbbYeuCauXN.Size = new System.Drawing.Size(280, 24);
            this.cbbYeuCauXN.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yêu Cầu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chuẩn Đoán";
            // 
            // richTextYauCau
            // 
            this.richTextYauCau.Location = new System.Drawing.Point(507, 78);
            this.richTextYauCau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextYauCau.Name = "richTextYauCau";
            this.richTextYauCau.Size = new System.Drawing.Size(476, 43);
            this.richTextYauCau.TabIndex = 1;
            this.richTextYauCau.Text = "";
            // 
            // richTextChuanDaon
            // 
            this.richTextChuanDaon.Location = new System.Drawing.Point(507, 21);
            this.richTextChuanDaon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.richTextChuanDaon.Name = "richTextChuanDaon";
            this.richTextChuanDaon.Size = new System.Drawing.Size(476, 43);
            this.richTextChuanDaon.TabIndex = 0;
            this.richTextChuanDaon.Text = "";
            // 
            // groupBoxxeinghiem
            // 
            this.groupBoxxeinghiem.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxxeinghiem.Controls.Add(this.label4);
            this.groupBoxxeinghiem.Controls.Add(this.cbbYeuCauXN);
            this.groupBoxxeinghiem.Controls.Add(this.richTextChuanDaon);
            this.groupBoxxeinghiem.Controls.Add(this.label2);
            this.groupBoxxeinghiem.Controls.Add(this.label1);
            this.groupBoxxeinghiem.Controls.Add(this.richTextYauCau);
            this.groupBoxxeinghiem.Location = new System.Drawing.Point(12, 129);
            this.groupBoxxeinghiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxxeinghiem.Name = "groupBoxxeinghiem";
            this.groupBoxxeinghiem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxxeinghiem.Size = new System.Drawing.Size(993, 143);
            this.groupBoxxeinghiem.TabIndex = 49;
            this.groupBoxxeinghiem.TabStop = false;
            this.groupBoxxeinghiem.Text = "Yêu Cầu Xét Nghiệm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(25, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(284, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Lựa Chọn Hình Thức Xét Nghiệm";
            // 
            // btnxuat
            // 
            this.btnxuat.BackColor = System.Drawing.Color.LightGray;
            this.btnxuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuat.Image = global::benhvien.Properties.Resources.icons8_print_30;
            this.btnxuat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnxuat.Location = new System.Drawing.Point(813, 532);
            this.btnxuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxuat.Name = "btnxuat";
            this.btnxuat.Size = new System.Drawing.Size(196, 33);
            this.btnxuat.TabIndex = 55;
            this.btnxuat.Text = "In Phiếu Xét Nghiệm";
            this.btnxuat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxuat.UseVisualStyleBackColor = false;
            this.btnxuat.Click += new System.EventHandler(this.btnxuat_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.LightGray;
            this.btnsua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.Image = ((System.Drawing.Image)(resources.GetObject("btnsua.Image")));
            this.btnsua.Location = new System.Drawing.Point(680, 532);
            this.btnsua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(127, 33);
            this.btnsua.TabIndex = 56;
            this.btnsua.Text = "Chỉnh Sửa";
            this.btnsua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click_1);
            // 
            // btnthem
            // 
            this.btnthem.BackColor = System.Drawing.Color.LightGray;
            this.btnthem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthem.Image = ((System.Drawing.Image)(resources.GetObject("btnthem.Image")));
            this.btnthem.Location = new System.Drawing.Point(463, 532);
            this.btnthem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(104, 32);
            this.btnthem.TabIndex = 58;
            this.btnthem.Text = "Thêm XN";
            this.btnthem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthem.UseVisualStyleBackColor = false;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click_1);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.LightGray;
            this.btnxoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.Image = ((System.Drawing.Image)(resources.GetObject("btnxoa.Image")));
            this.btnxoa.Location = new System.Drawing.Point(584, 532);
            this.btnxoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(83, 32);
            this.btnxoa.TabIndex = 57;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnxoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click_1);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvbenhnhan2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 316);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(491, 210);
            this.groupBox2.TabIndex = 59;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Bệnh Nhân";
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
            this.dgvbenhnhan2.Location = new System.Drawing.Point(13, 21);
            this.dgvbenhnhan2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvbenhnhan2.Name = "dgvbenhnhan2";
            this.dgvbenhnhan2.RowHeadersWidth = 51;
            this.dgvbenhnhan2.RowTemplate.Height = 24;
            this.dgvbenhnhan2.Size = new System.Drawing.Size(477, 180);
            this.dgvbenhnhan2.TabIndex = 33;
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
            // grnkham
            // 
            this.grnkham.BackColor = System.Drawing.Color.Transparent;
            this.grnkham.Controls.Add(this.label5);
            this.grnkham.Controls.Add(this.cbbTenBS);
            this.grnkham.Controls.Add(this.cbbMaBS);
            this.grnkham.Controls.Add(this.txtSODK);
            this.grnkham.Controls.Add(this.lbltiensu);
            this.grnkham.Location = new System.Drawing.Point(15, 12);
            this.grnkham.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grnkham.Name = "grnkham";
            this.grnkham.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grnkham.Size = new System.Drawing.Size(359, 112);
            this.grnkham.TabIndex = 50;
            this.grnkham.TabStop = false;
            this.grnkham.Text = "Xét Nghiệm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 53;
            this.label5.Text = "Tên BS";
            // 
            // cbbTenBS
            // 
            this.cbbTenBS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTenBS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTenBS.FormattingEnabled = true;
            this.cbbTenBS.Location = new System.Drawing.Point(213, 71);
            this.cbbTenBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTenBS.Name = "cbbTenBS";
            this.cbbTenBS.Size = new System.Drawing.Size(121, 24);
            this.cbbTenBS.TabIndex = 51;
            // 
            // cbbMaBS
            // 
            this.cbbMaBS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMaBS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMaBS.Enabled = false;
            this.cbbMaBS.FormattingEnabled = true;
            this.cbbMaBS.Location = new System.Drawing.Point(103, 70);
            this.cbbMaBS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaBS.Name = "cbbMaBS";
            this.cbbMaBS.Size = new System.Drawing.Size(92, 24);
            this.cbbMaBS.TabIndex = 52;
            // 
            // txtSODK
            // 
            this.txtSODK.Location = new System.Drawing.Point(103, 33);
            this.txtSODK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSODK.Name = "txtSODK";
            this.txtSODK.Size = new System.Drawing.Size(92, 22);
            this.txtSODK.TabIndex = 3;
            // 
            // lbltiensu
            // 
            this.lbltiensu.AutoSize = true;
            this.lbltiensu.Location = new System.Drawing.Point(12, 33);
            this.lbltiensu.Name = "lbltiensu";
            this.lbltiensu.Size = new System.Drawing.Size(85, 17);
            this.lbltiensu.TabIndex = 2;
            this.lbltiensu.Text = "Mã Đăng Ký";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMaBN);
            this.groupBox1.Controls.Add(this.cbbGioitinh);
            this.groupBox1.Controls.Add(this.lblgioitinh);
            this.groupBox1.Controls.Add(this.lblma);
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Location = new System.Drawing.Point(379, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(627, 111);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Bệnh Nhân";
            // 
            // txtMaBN
            // 
            this.txtMaBN.Enabled = false;
            this.txtMaBN.Location = new System.Drawing.Point(92, 26);
            this.txtMaBN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMaBN.Name = "txtMaBN";
            this.txtMaBN.Size = new System.Drawing.Size(119, 22);
            this.txtMaBN.TabIndex = 34;
            // 
            // cbbGioitinh
            // 
            this.cbbGioitinh.Enabled = false;
            this.cbbGioitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbGioitinh.FormattingEnabled = true;
            this.cbbGioitinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbbGioitinh.Location = new System.Drawing.Point(427, 17);
            this.cbbGioitinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbGioitinh.Name = "cbbGioitinh";
            this.cbbGioitinh.Size = new System.Drawing.Size(80, 26);
            this.cbbGioitinh.TabIndex = 40;
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Location = new System.Drawing.Point(341, 27);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(65, 17);
            this.lblgioitinh.TabIndex = 39;
            this.lblgioitinh.Text = "Giới Tính";
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Location = new System.Drawing.Point(11, 30);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(50, 17);
            this.lblma.TabIndex = 33;
            this.lblma.Text = "Mã BN";
            // 
            // txtHoten
            // 
            this.txtHoten.Enabled = false;
            this.txtHoten.Location = new System.Drawing.Point(92, 63);
            this.txtHoten.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(163, 22);
            this.txtHoten.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Ngày Sinh ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 17);
            this.label9.TabIndex = 35;
            this.label9.Text = "Họ tên ";
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Enabled = false;
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(427, 58);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(119, 22);
            this.dtpNgaySinh.TabIndex = 38;
            this.dtpNgaySinh.Value = new System.DateTime(2021, 10, 22, 0, 0, 0, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvXetNghiem);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(509, 316);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(496, 210);
            this.groupBox3.TabIndex = 60;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh Sách Xét Nghiệm";
            // 
            // dgvXetNghiem
            // 
            this.dgvXetNghiem.AllowUserToAddRows = false;
            this.dgvXetNghiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvXetNghiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.sodk,
            this.Mabn,
            this.hotenbn,
            this.gioitinh,
            this.ngaysinh,
            this.MaBS,
            this.HOTENBS,
            this.YEUCAUXETNGIEM,
            this.chuandoan,
            this.yeucau});
            this.dgvXetNghiem.Location = new System.Drawing.Point(9, 21);
            this.dgvXetNghiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvXetNghiem.Name = "dgvXetNghiem";
            this.dgvXetNghiem.RowHeadersWidth = 51;
            this.dgvXetNghiem.RowTemplate.Height = 24;
            this.dgvXetNghiem.Size = new System.Drawing.Size(477, 180);
            this.dgvXetNghiem.TabIndex = 34;
            this.dgvXetNghiem.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXetNghiem_CellClick_1);
            // 
            // sodk
            // 
            this.sodk.HeaderText = "Số DK";
            this.sodk.MinimumWidth = 6;
            this.sodk.Name = "sodk";
            this.sodk.Width = 125;
            // 
            // Mabn
            // 
            this.Mabn.HeaderText = "Mã BN";
            this.Mabn.MinimumWidth = 6;
            this.Mabn.Name = "Mabn";
            this.Mabn.Width = 125;
            // 
            // hotenbn
            // 
            this.hotenbn.HeaderText = "Họ Tên BN";
            this.hotenbn.MinimumWidth = 6;
            this.hotenbn.Name = "hotenbn";
            this.hotenbn.Width = 125;
            // 
            // gioitinh
            // 
            this.gioitinh.HeaderText = "Giới Tính";
            this.gioitinh.MinimumWidth = 6;
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Width = 125;
            // 
            // ngaysinh
            // 
            this.ngaysinh.HeaderText = "Ngày Sinh";
            this.ngaysinh.MinimumWidth = 6;
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Width = 125;
            // 
            // MaBS
            // 
            this.MaBS.HeaderText = "Mã BS";
            this.MaBS.MinimumWidth = 6;
            this.MaBS.Name = "MaBS";
            this.MaBS.Width = 125;
            // 
            // HOTENBS
            // 
            this.HOTENBS.HeaderText = "Họ Tên BS";
            this.HOTENBS.MinimumWidth = 6;
            this.HOTENBS.Name = "HOTENBS";
            this.HOTENBS.Width = 125;
            // 
            // YEUCAUXETNGIEM
            // 
            this.YEUCAUXETNGIEM.HeaderText = "Yêu Cầu Xét Nghiệm";
            this.YEUCAUXETNGIEM.MinimumWidth = 6;
            this.YEUCAUXETNGIEM.Name = "YEUCAUXETNGIEM";
            this.YEUCAUXETNGIEM.Width = 125;
            // 
            // chuandoan
            // 
            this.chuandoan.HeaderText = "Chuẩn Đoán";
            this.chuandoan.MinimumWidth = 6;
            this.chuandoan.Name = "chuandoan";
            this.chuandoan.Width = 125;
            // 
            // yeucau
            // 
            this.yeucau.HeaderText = "Yêu Cầu";
            this.yeucau.MinimumWidth = 6;
            this.yeucau.Name = "yeucau";
            this.yeucau.Width = 125;
            // 
            // txttim
            // 
            this.txttim.Location = new System.Drawing.Point(205, 286);
            this.txttim.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txttim.Name = "txttim";
            this.txttim.Size = new System.Drawing.Size(296, 22);
            this.txttim.TabIndex = 61;
            this.txttim.TextChanged += new System.EventHandler(this.txttim_TextChanged);
            // 
            // lbltim
            // 
            this.lbltim.AutoSize = true;
            this.lbltim.Location = new System.Drawing.Point(27, 289);
            this.lbltim.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltim.Name = "lbltim";
            this.lbltim.Size = new System.Drawing.Size(138, 17);
            this.lbltim.TabIndex = 62;
            this.lbltim.Text = "Tìm Kiếm bệnh nhân";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.crystalReportViewer1);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 571);
            this.panel1.TabIndex = 63;
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.DisplayStatusBar = false;
            this.crystalReportViewer1.Location = new System.Drawing.Point(9, 2);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(917, 560);
            this.crystalReportViewer1.TabIndex = 45;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.Image = global::benhvien.Properties.Resources.icons8_back_24;
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(932, 2);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 560);
            this.btnClose.TabIndex = 46;
            this.btnClose.Text = "Trở Về";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Frmxetnghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1029, 571);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txttim);
            this.Controls.Add(this.lbltim);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnxuat);
            this.Controls.Add(this.grnkham);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnthem);
            this.Controls.Add(this.groupBoxxeinghiem);
            this.Controls.Add(this.btnxoa);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frmxetnghiem";
            this.Text = "Frmxetnghiem";
            this.Load += new System.EventHandler(this.Frmxetnghiem_Load);
            this.groupBoxxeinghiem.ResumeLayout(false);
            this.groupBoxxeinghiem.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbenhnhan2)).EndInit();
            this.grnkham.ResumeLayout(false);
            this.grnkham.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXetNghiem)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PrintDialog printDialog2;
        private System.Drawing.Printing.PrintDocument printDocument2;
        private System.Windows.Forms.ComboBox cbbYeuCauXN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richTextYauCau;
        private System.Windows.Forms.RichTextBox richTextChuanDaon;
        private System.Windows.Forms.GroupBox groupBoxxeinghiem;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.Button btnxuat;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.GroupBox groupBox2;
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
        private System.Windows.Forms.GroupBox grnkham;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbTenBS;
        private System.Windows.Forms.ComboBox cbbMaBS;
        private System.Windows.Forms.TextBox txtSODK;
        private System.Windows.Forms.Label lbltiensu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMaBN;
        private System.Windows.Forms.ComboBox cbbGioitinh;
        private System.Windows.Forms.Label lblgioitinh;
        private System.Windows.Forms.Label lblma;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txttim;
        private System.Windows.Forms.Label lbltim;
        private System.Windows.Forms.DataGridView dgvXetNghiem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn sodk;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mabn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hotenbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn YEUCAUXETNGIEM;
        private System.Windows.Forms.DataGridViewTextBoxColumn chuandoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeucau;
        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnClose;
    }
}