namespace benhvien
{
    partial class Frmbenhnhan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmbenhnhan));
            this.lblTong = new System.Windows.Forms.Label();
            this.phongkham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sobhyt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doituong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnghe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quoctich = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diachi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvgt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvngay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvho = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvbenhnhan = new System.Windows.Forms.DataGridView();
            this.dgvma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNhapMaBn = new System.Windows.Forms.Label();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.grbbacsi = new System.Windows.Forms.GroupBox();
            this.btnTimBS = new System.Windows.Forms.Button();
            this.comboBoxbn = new System.Windows.Forms.ComboBox();
            this.checkBoxbn = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnthongke = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvbenhnhan)).BeginInit();
            this.grbbacsi.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTong
            // 
            this.lblTong.AutoSize = true;
            this.lblTong.BackColor = System.Drawing.Color.Transparent;
            this.lblTong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblTong.Location = new System.Drawing.Point(28, 97);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(135, 23);
            this.lblTong.TabIndex = 31;
            this.lblTong.Text = "Số Bệnh Nhân:";
            // 
            // phongkham
            // 
            this.phongkham.HeaderText = "Phòng Khám";
            this.phongkham.MinimumWidth = 6;
            this.phongkham.Name = "phongkham";
            this.phongkham.Width = 125;
            // 
            // gia
            // 
            this.gia.HeaderText = "Gía Trị BHYT";
            this.gia.MinimumWidth = 6;
            this.gia.Name = "gia";
            this.gia.Width = 125;
            // 
            // sobhyt
            // 
            this.sobhyt.HeaderText = "Số BHYT";
            this.sobhyt.MinimumWidth = 6;
            this.sobhyt.Name = "sobhyt";
            this.sobhyt.Width = 125;
            // 
            // doituong
            // 
            this.doituong.HeaderText = "Đối Tượng";
            this.doituong.MinimumWidth = 6;
            this.doituong.Name = "doituong";
            this.doituong.Width = 125;
            // 
            // dgvnghe
            // 
            this.dgvnghe.HeaderText = "Nghề nghiệp";
            this.dgvnghe.MinimumWidth = 6;
            this.dgvnghe.Name = "dgvnghe";
            this.dgvnghe.Width = 125;
            // 
            // quoctich
            // 
            this.quoctich.HeaderText = "Quốc Tịch";
            this.quoctich.MinimumWidth = 6;
            this.quoctich.Name = "quoctich";
            this.quoctich.Width = 125;
            // 
            // dgvdan
            // 
            this.dgvdan.HeaderText = "Dân Tộc";
            this.dgvdan.MinimumWidth = 6;
            this.dgvdan.Name = "dgvdan";
            this.dgvdan.Width = 125;
            // 
            // diachi
            // 
            this.diachi.HeaderText = "Địa Chỉ";
            this.diachi.MinimumWidth = 6;
            this.diachi.Name = "diachi";
            this.diachi.Width = 125;
            // 
            // dgvgt
            // 
            this.dgvgt.HeaderText = "giới tính";
            this.dgvgt.MinimumWidth = 6;
            this.dgvgt.Name = "dgvgt";
            this.dgvgt.Width = 125;
            // 
            // dgvngay
            // 
            this.dgvngay.HeaderText = "Ngày sinh";
            this.dgvngay.MinimumWidth = 6;
            this.dgvngay.Name = "dgvngay";
            this.dgvngay.Width = 125;
            // 
            // GHICHU
            // 
            this.GHICHU.HeaderText = "Ghi Chú";
            this.GHICHU.MinimumWidth = 6;
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.Width = 125;
            // 
            // dgvho
            // 
            this.dgvho.HeaderText = "Họ tên";
            this.dgvho.MinimumWidth = 6;
            this.dgvho.Name = "dgvho";
            this.dgvho.Width = 125;
            // 
            // dgvbenhnhan
            // 
            this.dgvbenhnhan.AllowUserToAddRows = false;
            this.dgvbenhnhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvbenhnhan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvma,
            this.dgvho,
            this.dgvngay,
            this.dgvgt,
            this.diachi,
            this.dgvdan,
            this.quoctich,
            this.dgvnghe,
            this.doituong,
            this.sobhyt,
            this.gia,
            this.phongkham,
            this.GHICHU});
            this.dgvbenhnhan.Location = new System.Drawing.Point(10, 141);
            this.dgvbenhnhan.Name = "dgvbenhnhan";
            this.dgvbenhnhan.RowHeadersWidth = 51;
            this.dgvbenhnhan.RowTemplate.Height = 24;
            this.dgvbenhnhan.Size = new System.Drawing.Size(1014, 416);
            this.dgvbenhnhan.TabIndex = 30;
            // 
            // dgvma
            // 
            this.dgvma.HeaderText = "Mã bệnh nhân";
            this.dgvma.MinimumWidth = 6;
            this.dgvma.Name = "dgvma";
            this.dgvma.Width = 125;
            // 
            // lblNhapMaBn
            // 
            this.lblNhapMaBn.AutoSize = true;
            this.lblNhapMaBn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhapMaBn.Location = new System.Drawing.Point(28, 32);
            this.lblNhapMaBn.Name = "lblNhapMaBn";
            this.lblNhapMaBn.Size = new System.Drawing.Size(149, 20);
            this.lblNhapMaBn.TabIndex = 17;
            this.lblNhapMaBn.Text = "Họ Tên Bệnh nhân";
            // 
            // txtTim
            // 
            this.txtTim.Location = new System.Drawing.Point(79, 55);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(215, 24);
            this.txtTim.TabIndex = 0;
            this.txtTim.TextChanged += new System.EventHandler(this.txtTim_TextChanged);
            // 
            // grbbacsi
            // 
            this.grbbacsi.BackColor = System.Drawing.Color.Transparent;
            this.grbbacsi.Controls.Add(this.lblTong);
            this.grbbacsi.Controls.Add(this.lblNhapMaBn);
            this.grbbacsi.Controls.Add(this.txtTim);
            this.grbbacsi.Controls.Add(this.btnTimBS);
            this.grbbacsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbbacsi.Location = new System.Drawing.Point(10, 9);
            this.grbbacsi.Name = "grbbacsi";
            this.grbbacsi.Size = new System.Drawing.Size(488, 123);
            this.grbbacsi.TabIndex = 28;
            this.grbbacsi.TabStop = false;
            this.grbbacsi.Text = "Tìm Kiếm Thông Tin Bệnh Nhân";
            // 
            // btnTimBS
            // 
            this.btnTimBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimBS.Image = ((System.Drawing.Image)(resources.GetObject("btnTimBS.Image")));
            this.btnTimBS.Location = new System.Drawing.Point(332, 50);
            this.btnTimBS.Name = "btnTimBS";
            this.btnTimBS.Size = new System.Drawing.Size(91, 35);
            this.btnTimBS.TabIndex = 19;
            this.btnTimBS.Text = "Tìm";
            this.btnTimBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTimBS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimBS.UseVisualStyleBackColor = true;
            this.btnTimBS.Click += new System.EventHandler(this.btnTimBS_Click);
            // 
            // comboBoxbn
            // 
            this.comboBoxbn.FormattingEnabled = true;
            this.comboBoxbn.Items.AddRange(new object[] {
            "Miễn phí",
            "BHYT",
            "Thu phí",
            "Khác"});
            this.comboBoxbn.Location = new System.Drawing.Point(45, 61);
            this.comboBoxbn.Name = "comboBoxbn";
            this.comboBoxbn.Size = new System.Drawing.Size(169, 26);
            this.comboBoxbn.TabIndex = 21;
            // 
            // checkBoxbn
            // 
            this.checkBoxbn.AutoSize = true;
            this.checkBoxbn.Location = new System.Drawing.Point(24, 36);
            this.checkBoxbn.Name = "checkBoxbn";
            this.checkBoxbn.Size = new System.Drawing.Size(173, 22);
            this.checkBoxbn.TabIndex = 20;
            this.checkBoxbn.Text = "Đối Tượng Bệnh nhân";
            this.checkBoxbn.UseVisualStyleBackColor = true;
            this.checkBoxbn.CheckedChanged += new System.EventHandler(this.checkBoxbn_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnIn);
            this.groupBox1.Controls.Add(this.comboBoxbn);
            this.groupBox1.Controls.Add(this.checkBoxbn);
            this.groupBox1.Controls.Add(this.btnthongke);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(525, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 123);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống Kê Bệnh Nhân";
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = ((System.Drawing.Image)(resources.GetObject("btnIn.Image")));
            this.btnIn.Location = new System.Drawing.Point(363, 52);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(125, 43);
            this.btnIn.TabIndex = 22;
            this.btnIn.Text = "Export";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnthongke
            // 
            this.btnthongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthongke.Image = ((System.Drawing.Image)(resources.GetObject("btnthongke.Image")));
            this.btnthongke.Location = new System.Drawing.Point(220, 52);
            this.btnthongke.Name = "btnthongke";
            this.btnthongke.Size = new System.Drawing.Size(133, 43);
            this.btnthongke.TabIndex = 19;
            this.btnthongke.Text = "Thống kê";
            this.btnthongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnthongke.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnthongke.UseVisualStyleBackColor = true;
            this.btnthongke.Click += new System.EventHandler(this.btnthongke_Click);
            // 
            // Frmbenhnhan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1035, 571);
            this.Controls.Add(this.dgvbenhnhan);
            this.Controls.Add(this.grbbacsi);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frmbenhnhan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Bệnh Nhân";
            this.Load += new System.EventHandler(this.Frmbenhnhan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvbenhnhan)).EndInit();
            this.grbbacsi.ResumeLayout(false);
            this.grbbacsi.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTong;
        private System.Windows.Forms.DataGridViewTextBoxColumn phongkham;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sobhyt;
        private System.Windows.Forms.DataGridViewTextBoxColumn doituong;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnghe;
        private System.Windows.Forms.DataGridViewTextBoxColumn quoctich;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdan;
        private System.Windows.Forms.DataGridViewTextBoxColumn diachi;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvgt;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvngay;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvho;
        private System.Windows.Forms.DataGridView dgvbenhnhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvma;
        private System.Windows.Forms.Label lblNhapMaBn;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.Button btnTimBS;
        private System.Windows.Forms.GroupBox grbbacsi;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.ComboBox comboBoxbn;
        private System.Windows.Forms.CheckBox checkBoxbn;
        private System.Windows.Forms.Button btnthongke;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}