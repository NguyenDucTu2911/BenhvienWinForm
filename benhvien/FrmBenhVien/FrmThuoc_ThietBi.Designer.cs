
namespace benhvien
{
    partial class FrmThuoc_ThietBi
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
            this.Dgvthuoc = new System.Windows.Forms.DataGridView();
            this.Manhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tennhom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chucvu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Matkhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Taikhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.grbthongtin = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtTênThuốc = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txthangsanxuatthuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtSLThuoc = new System.Windows.Forms.TextBox();
            this.TxtDVT = new System.Windows.Forms.TextBox();
            this.txtMaThuoc = new System.Windows.Forms.TextBox();
            this.btnXoaThuoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuaThuoc = new Guna.UI2.WinForms.Guna2Button();
            this.btnthemthuoc = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtHnagvt = new System.Windows.Forms.TextBox();
            this.txtSLvt = new System.Windows.Forms.TextBox();
            this.txtTenvt = new System.Windows.Forms.TextBox();
            this.txtMaVt = new System.Windows.Forms.TextBox();
            this.DgvVattu = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNhapMaBS = new System.Windows.Forms.Label();
            this.txttimthuoc = new System.Windows.Forms.TextBox();
            this.txttimvt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnThemVT = new Guna.UI2.WinForms.Guna2Button();
            this.btnsuavt = new Guna.UI2.WinForms.Guna2Button();
            this.btnxoavt = new Guna.UI2.WinForms.Guna2Button();
            this.btnin = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgvthuoc)).BeginInit();
            this.grbthongtin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVattu)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgvthuoc
            // 
            this.Dgvthuoc.AllowUserToAddRows = false;
            this.Dgvthuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgvthuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgvthuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Manhom,
            this.tennhom,
            this.chucvu,
            this.hoten,
            this.Matkhau,
            this.Taikhoan});
            this.Dgvthuoc.Location = new System.Drawing.Point(336, 205);
            this.Dgvthuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgvthuoc.Name = "Dgvthuoc";
            this.Dgvthuoc.RowHeadersWidth = 51;
            this.Dgvthuoc.RowTemplate.Height = 24;
            this.Dgvthuoc.Size = new System.Drawing.Size(416, 185);
            this.Dgvthuoc.TabIndex = 59;
            this.Dgvthuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgvthuoc_CellClick);
            // 
            // Manhom
            // 
            this.Manhom.HeaderText = "Mã Thuốc";
            this.Manhom.MinimumWidth = 6;
            this.Manhom.Name = "Manhom";
            // 
            // tennhom
            // 
            this.tennhom.HeaderText = "Tên Thuốc";
            this.tennhom.MinimumWidth = 6;
            this.tennhom.Name = "tennhom";
            // 
            // chucvu
            // 
            this.chucvu.HeaderText = "Hãng Sản Xuất";
            this.chucvu.MinimumWidth = 6;
            this.chucvu.Name = "chucvu";
            // 
            // hoten
            // 
            this.hoten.HeaderText = "Đơn Vị Tính";
            this.hoten.MinimumWidth = 6;
            this.hoten.Name = "hoten";
            // 
            // Matkhau
            // 
            this.Matkhau.HeaderText = "Số Lượng";
            this.Matkhau.MinimumWidth = 6;
            this.Matkhau.Name = "Matkhau";
            // 
            // Taikhoan
            // 
            this.Taikhoan.HeaderText = "Đơn Giá";
            this.Taikhoan.MinimumWidth = 6;
            this.Taikhoan.Name = "Taikhoan";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(222, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Quản Lý Thông Tin Thuốc Và Vật Tư";
            // 
            // grbthongtin
            // 
            this.grbthongtin.BackColor = System.Drawing.Color.Transparent;
            this.grbthongtin.Controls.Add(this.label8);
            this.grbthongtin.Controls.Add(this.label2);
            this.grbthongtin.Controls.Add(this.label6);
            this.grbthongtin.Controls.Add(this.label5);
            this.grbthongtin.Controls.Add(this.label4);
            this.grbthongtin.Controls.Add(this.TxtTênThuốc);
            this.grbthongtin.Controls.Add(this.txtdongia);
            this.grbthongtin.Controls.Add(this.txthangsanxuatthuoc);
            this.grbthongtin.Controls.Add(this.label3);
            this.grbthongtin.Controls.Add(this.TxtSLThuoc);
            this.grbthongtin.Controls.Add(this.TxtDVT);
            this.grbthongtin.Controls.Add(this.txtMaThuoc);
            this.grbthongtin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbthongtin.Location = new System.Drawing.Point(336, 54);
            this.grbthongtin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbthongtin.Name = "grbthongtin";
            this.grbthongtin.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grbthongtin.Size = new System.Drawing.Size(416, 120);
            this.grbthongtin.TabIndex = 58;
            this.grbthongtin.TabStop = false;
            this.grbthongtin.Text = "Thông tin thuốc";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 97);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Đơn Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "SL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(168, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Hãng Sản Xuất";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Đơn Vị Tính";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Tên Thuốc";
            // 
            // TxtTênThuốc
            // 
            this.TxtTênThuốc.Location = new System.Drawing.Point(268, 25);
            this.TxtTênThuốc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtTênThuốc.Name = "TxtTênThuốc";
            this.TxtTênThuốc.Size = new System.Drawing.Size(142, 23);
            this.TxtTênThuốc.TabIndex = 13;
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(268, 91);
            this.txtdongia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(142, 23);
            this.txtdongia.TabIndex = 13;
            this.txtdongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongia_KeyPress);
            // 
            // txthangsanxuatthuoc
            // 
            this.txthangsanxuatthuoc.Location = new System.Drawing.Point(268, 58);
            this.txthangsanxuatthuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txthangsanxuatthuoc.Name = "txthangsanxuatthuoc";
            this.txthangsanxuatthuoc.Size = new System.Drawing.Size(142, 23);
            this.txthangsanxuatthuoc.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 28);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Mã Thuốc";
            // 
            // TxtSLThuoc
            // 
            this.TxtSLThuoc.Location = new System.Drawing.Point(84, 91);
            this.TxtSLThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtSLThuoc.Name = "TxtSLThuoc";
            this.TxtSLThuoc.Size = new System.Drawing.Size(74, 23);
            this.TxtSLThuoc.TabIndex = 11;
            this.TxtSLThuoc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSLThuoc_KeyPress);
            // 
            // TxtDVT
            // 
            this.TxtDVT.Location = new System.Drawing.Point(84, 61);
            this.TxtDVT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TxtDVT.Name = "TxtDVT";
            this.TxtDVT.Size = new System.Drawing.Size(74, 23);
            this.TxtDVT.TabIndex = 11;
            // 
            // txtMaThuoc
            // 
            this.txtMaThuoc.Location = new System.Drawing.Point(84, 28);
            this.txtMaThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaThuoc.Name = "txtMaThuoc";
            this.txtMaThuoc.Size = new System.Drawing.Size(74, 23);
            this.txtMaThuoc.TabIndex = 11;
            // 
            // btnXoaThuoc
            // 
            this.btnXoaThuoc.AutoRoundedCorners = true;
            this.btnXoaThuoc.BorderRadius = 15;
            this.btnXoaThuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaThuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnXoaThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnXoaThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnXoaThuoc.FillColor = System.Drawing.Color.LightGray;
            this.btnXoaThuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaThuoc.ForeColor = System.Drawing.Color.Black;
            this.btnXoaThuoc.Location = new System.Drawing.Point(532, 407);
            this.btnXoaThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnXoaThuoc.Name = "btnXoaThuoc";
            this.btnXoaThuoc.Size = new System.Drawing.Size(63, 32);
            this.btnXoaThuoc.TabIndex = 60;
            this.btnXoaThuoc.Text = "Xóa";
            this.btnXoaThuoc.Click += new System.EventHandler(this.btnXoaThuoc_Click);
            // 
            // btnSuaThuoc
            // 
            this.btnSuaThuoc.AutoRoundedCorners = true;
            this.btnSuaThuoc.BorderRadius = 15;
            this.btnSuaThuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaThuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuaThuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuaThuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuaThuoc.FillColor = System.Drawing.Color.LightGray;
            this.btnSuaThuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaThuoc.ForeColor = System.Drawing.Color.Black;
            this.btnSuaThuoc.Location = new System.Drawing.Point(441, 407);
            this.btnSuaThuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSuaThuoc.Name = "btnSuaThuoc";
            this.btnSuaThuoc.Size = new System.Drawing.Size(74, 32);
            this.btnSuaThuoc.TabIndex = 61;
            this.btnSuaThuoc.Text = "Sửa";
            this.btnSuaThuoc.Click += new System.EventHandler(this.btnSuaThuoc_Click);
            // 
            // btnthemthuoc
            // 
            this.btnthemthuoc.AutoRoundedCorners = true;
            this.btnthemthuoc.BorderRadius = 15;
            this.btnthemthuoc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnthemthuoc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnthemthuoc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnthemthuoc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnthemthuoc.FillColor = System.Drawing.Color.LightGray;
            this.btnthemthuoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemthuoc.ForeColor = System.Drawing.Color.Black;
            this.btnthemthuoc.Location = new System.Drawing.Point(351, 407);
            this.btnthemthuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthemthuoc.Name = "btnthemthuoc";
            this.btnthemthuoc.Size = new System.Drawing.Size(74, 32);
            this.btnthemthuoc.TabIndex = 62;
            this.btnthemthuoc.Text = "Thêm";
            this.btnthemthuoc.Click += new System.EventHandler(this.btnthemthuoc_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtHnagvt);
            this.groupBox1.Controls.Add(this.txtSLvt);
            this.groupBox1.Controls.Add(this.txtTenvt);
            this.groupBox1.Controls.Add(this.txtMaVt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 54);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(312, 120);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Vật Tư";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(168, 67);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hãng";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 67);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "SL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(168, 28);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Tên VT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 28);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 17);
            this.label13.TabIndex = 12;
            this.label13.Text = "Mã VT";
            // 
            // txtHnagvt
            // 
            this.txtHnagvt.Location = new System.Drawing.Point(232, 62);
            this.txtHnagvt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtHnagvt.Name = "txtHnagvt";
            this.txtHnagvt.Size = new System.Drawing.Size(74, 23);
            this.txtHnagvt.TabIndex = 11;
            // 
            // txtSLvt
            // 
            this.txtSLvt.Location = new System.Drawing.Point(58, 65);
            this.txtSLvt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSLvt.Name = "txtSLvt";
            this.txtSLvt.Size = new System.Drawing.Size(74, 23);
            this.txtSLvt.TabIndex = 11;
            this.txtSLvt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLvt_KeyPress);
            // 
            // txtTenvt
            // 
            this.txtTenvt.Location = new System.Drawing.Point(232, 24);
            this.txtTenvt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTenvt.Name = "txtTenvt";
            this.txtTenvt.Size = new System.Drawing.Size(74, 23);
            this.txtTenvt.TabIndex = 11;
            // 
            // txtMaVt
            // 
            this.txtMaVt.Location = new System.Drawing.Point(57, 25);
            this.txtMaVt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaVt.Name = "txtMaVt";
            this.txtMaVt.Size = new System.Drawing.Size(74, 23);
            this.txtMaVt.TabIndex = 11;
            // 
            // DgvVattu
            // 
            this.DgvVattu.AllowUserToAddRows = false;
            this.DgvVattu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvVattu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvVattu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn5});
            this.DgvVattu.Location = new System.Drawing.Point(16, 205);
            this.DgvVattu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DgvVattu.Name = "DgvVattu";
            this.DgvVattu.RowHeadersWidth = 51;
            this.DgvVattu.RowTemplate.Height = 24;
            this.DgvVattu.Size = new System.Drawing.Size(316, 185);
            this.DgvVattu.TabIndex = 66;
            this.DgvVattu.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvVattu_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Mã Vật Tư";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Tên Vật Tư";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Hãng Sản Xuất";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Số Lượng";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // lblNhapMaBS
            // 
            this.lblNhapMaBS.AutoSize = true;
            this.lblNhapMaBS.BackColor = System.Drawing.Color.Transparent;
            this.lblNhapMaBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapMaBS.Location = new System.Drawing.Point(340, 178);
            this.lblNhapMaBS.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNhapMaBS.Name = "lblNhapMaBS";
            this.lblNhapMaBS.Size = new System.Drawing.Size(144, 17);
            this.lblNhapMaBS.TabIndex = 64;
            this.lblNhapMaBS.Text = "Tìm Thông Tin Thuốc";
            // 
            // txttimthuoc
            // 
            this.txttimthuoc.Location = new System.Drawing.Point(488, 178);
            this.txttimthuoc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttimthuoc.Name = "txttimthuoc";
            this.txttimthuoc.Size = new System.Drawing.Size(162, 20);
            this.txttimthuoc.TabIndex = 63;
            this.txttimthuoc.TextChanged += new System.EventHandler(this.txttimthuoc_TextChanged);
            // 
            // txttimvt
            // 
            this.txttimvt.Location = new System.Drawing.Point(94, 178);
            this.txttimvt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txttimvt.Name = "txttimvt";
            this.txttimvt.Size = new System.Drawing.Size(162, 20);
            this.txttimvt.TabIndex = 67;
            this.txttimvt.TextChanged += new System.EventHandler(this.txttimvt_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(17, 178);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 17);
            this.label10.TabIndex = 68;
            this.label10.Text = "Tìm vật tư";
            // 
            // btnThemVT
            // 
            this.btnThemVT.AutoRoundedCorners = true;
            this.btnThemVT.BorderRadius = 15;
            this.btnThemVT.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnThemVT.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnThemVT.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnThemVT.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnThemVT.FillColor = System.Drawing.Color.LightGray;
            this.btnThemVT.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemVT.ForeColor = System.Drawing.Color.Black;
            this.btnThemVT.Location = new System.Drawing.Point(20, 407);
            this.btnThemVT.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemVT.Name = "btnThemVT";
            this.btnThemVT.Size = new System.Drawing.Size(67, 32);
            this.btnThemVT.TabIndex = 62;
            this.btnThemVT.Text = "Thêm";
            this.btnThemVT.Click += new System.EventHandler(this.btnThemVT_Click);
            // 
            // btnsuavt
            // 
            this.btnsuavt.AutoRoundedCorners = true;
            this.btnsuavt.BorderRadius = 15;
            this.btnsuavt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsuavt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsuavt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsuavt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsuavt.FillColor = System.Drawing.Color.LightGray;
            this.btnsuavt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuavt.ForeColor = System.Drawing.Color.Black;
            this.btnsuavt.Location = new System.Drawing.Point(94, 407);
            this.btnsuavt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsuavt.Name = "btnsuavt";
            this.btnsuavt.Size = new System.Drawing.Size(54, 32);
            this.btnsuavt.TabIndex = 61;
            this.btnsuavt.Text = "Sửa";
            this.btnsuavt.Click += new System.EventHandler(this.btnsuavt_Click);
            // 
            // btnxoavt
            // 
            this.btnxoavt.AutoRoundedCorners = true;
            this.btnxoavt.BorderRadius = 15;
            this.btnxoavt.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnxoavt.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnxoavt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnxoavt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnxoavt.FillColor = System.Drawing.Color.LightGray;
            this.btnxoavt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoavt.ForeColor = System.Drawing.Color.Black;
            this.btnxoavt.Location = new System.Drawing.Point(152, 407);
            this.btnxoavt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnxoavt.Name = "btnxoavt";
            this.btnxoavt.Size = new System.Drawing.Size(57, 32);
            this.btnxoavt.TabIndex = 60;
            this.btnxoavt.Text = "Xóa";
            this.btnxoavt.Click += new System.EventHandler(this.btnxoavt_Click);
            // 
            // btnin
            // 
            this.btnin.AutoRoundedCorners = true;
            this.btnin.BorderRadius = 15;
            this.btnin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnin.FillColor = System.Drawing.Color.LightGray;
            this.btnin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnin.ForeColor = System.Drawing.Color.Black;
            this.btnin.Location = new System.Drawing.Point(611, 407);
            this.btnin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnin.Name = "btnin";
            this.btnin.Size = new System.Drawing.Size(142, 32);
            this.btnin.TabIndex = 62;
            this.btnin.Text = "In Thuốc Và Vật Tư";
            this.btnin.Click += new System.EventHandler(this.btnin_Click);
            // 
            // FrmThuoc_ThietBi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(790, 456);
            this.Controls.Add(this.txttimvt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.DgvVattu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txttimthuoc);
            this.Controls.Add(this.lblNhapMaBS);
            this.Controls.Add(this.Dgvthuoc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grbthongtin);
            this.Controls.Add(this.btnxoavt);
            this.Controls.Add(this.btnXoaThuoc);
            this.Controls.Add(this.btnsuavt);
            this.Controls.Add(this.btnin);
            this.Controls.Add(this.btnThemVT);
            this.Controls.Add(this.btnSuaThuoc);
            this.Controls.Add(this.btnthemthuoc);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmThuoc_ThietBi";
            this.Text = "FrmThuoc_ThietBi";
            this.Load += new System.EventHandler(this.FrmThuoc_ThietBi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgvthuoc)).EndInit();
            this.grbthongtin.ResumeLayout(false);
            this.grbthongtin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvVattu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView Dgvthuoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbthongtin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthangsanxuatthuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaThuoc;
        private Guna.UI2.WinForms.Guna2Button btnXoaThuoc;
        private Guna.UI2.WinForms.Guna2Button btnSuaThuoc;
        private Guna.UI2.WinForms.Guna2Button btnthemthuoc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSLThuoc;
        private System.Windows.Forms.TextBox TxtDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Manhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn tennhom;
        private System.Windows.Forms.DataGridViewTextBoxColumn chucvu;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matkhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn Taikhoan;
        private System.Windows.Forms.TextBox TxtTênThuốc;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtHnagvt;
        private System.Windows.Forms.TextBox txtSLvt;
        private System.Windows.Forms.TextBox txtTenvt;
        private System.Windows.Forms.TextBox txtMaVt;
        private System.Windows.Forms.DataGridView DgvVattu;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label lblNhapMaBS;
        private System.Windows.Forms.TextBox txttimthuoc;
        private System.Windows.Forms.TextBox txttimvt;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2Button btnThemVT;
        private Guna.UI2.WinForms.Guna2Button btnsuavt;
        private Guna.UI2.WinForms.Guna2Button btnxoavt;
        private Guna.UI2.WinForms.Guna2Button btnin;
    }
}