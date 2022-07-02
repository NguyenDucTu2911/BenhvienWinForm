namespace benhvien
{
    partial class Frmquanly
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frmquanly));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btntaikhoan = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button6 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button5 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnbenhnhan = new Guna.UI2.WinForms.Guna2Button();
            this.btnbacsi = new Guna.UI2.WinForms.Guna2Button();
            this.btntrangchu = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.imgSlide = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.guna2GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btntaikhoan);
            this.panel1.Controls.Add(this.guna2Button6);
            this.panel1.Controls.Add(this.guna2Button5);
            this.panel1.Controls.Add(this.guna2Button4);
            this.panel1.Controls.Add(this.btnbenhnhan);
            this.panel1.Controls.Add(this.btnbacsi);
            this.panel1.Controls.Add(this.btntrangchu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.imgSlide);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 608);
            this.panel1.TabIndex = 2;
            
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bệnh Viện";
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.panel2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.guna2GroupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(180, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(892, 608);
            this.panel2.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(9, 301);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(874, 295);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thanh Toán Hóa Đơn";
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.guna2CirclePictureBox1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(9, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.Size = new System.Drawing.Size(874, 286);
            this.guna2GroupBox1.TabIndex = 2;
            this.guna2GroupBox1.Text = "BỆNH VIỆN ";
            this.guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = global::benhvien.Properties.Resources.dang_ky_kham_benh_minhanh;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(3, 50);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(868, 233);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // btntaikhoan
            // 
            this.btntaikhoan.BackColor = System.Drawing.Color.Transparent;
            this.btntaikhoan.BorderRadius = 22;
            this.btntaikhoan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btntaikhoan.CheckedState.FillColor = System.Drawing.Color.White;
            this.btntaikhoan.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btntaikhoan.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btntaikhoan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btntaikhoan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntaikhoan.ForeColor = System.Drawing.Color.White;
            this.btntaikhoan.Image = ((System.Drawing.Image)(resources.GetObject("btntaikhoan.Image")));
            this.btntaikhoan.Location = new System.Drawing.Point(31, 181);
            this.btntaikhoan.Name = "btntaikhoan";
            this.btntaikhoan.Size = new System.Drawing.Size(149, 43);
            this.btntaikhoan.TabIndex = 6;
            this.btntaikhoan.Text = "Tài Khoản";
            this.btntaikhoan.UseTransparentBackground = true;
            this.btntaikhoan.CheckedChanged += new System.EventHandler(this.btntaikhoan_CheckedChanged);
            this.btntaikhoan.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button6
            // 
            this.guna2Button6.BorderRadius = 5;
            this.guna2Button6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button6.ForeColor = System.Drawing.Color.White;
            this.guna2Button6.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button6.Image")));
            this.guna2Button6.Location = new System.Drawing.Point(43, 558);
            this.guna2Button6.Name = "guna2Button6";
            this.guna2Button6.Size = new System.Drawing.Size(109, 38);
            this.guna2Button6.TabIndex = 5;
            this.guna2Button6.Text = "Đăng Xuất";
            this.guna2Button6.Click += new System.EventHandler(this.guna2Button6_Click_1);
            // 
            // guna2Button5
            // 
            this.guna2Button5.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button5.BorderRadius = 22;
            this.guna2Button5.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button5.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button5.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button5.CheckedState.Image = global::benhvien.Properties.Resources.xetnghiem;
            this.guna2Button5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button5.ForeColor = System.Drawing.Color.White;
            this.guna2Button5.Image = global::benhvien.Properties.Resources.xetnghiem;
            this.guna2Button5.Location = new System.Drawing.Point(31, 499);
            this.guna2Button5.Name = "guna2Button5";
            this.guna2Button5.Size = new System.Drawing.Size(149, 43);
            this.guna2Button5.TabIndex = 2;
            this.guna2Button5.Text = "Xét Nghiệm";
            this.guna2Button5.UseTransparentBackground = true;
            this.guna2Button5.CheckedChanged += new System.EventHandler(this.btntaikhoan_CheckedChanged);
            this.guna2Button5.Click += new System.EventHandler(this.guna2Button5_Click);
            // 
            // guna2Button4
            // 
            this.guna2Button4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Button4.BorderRadius = 22;
            this.guna2Button4.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.guna2Button4.CheckedState.FillColor = System.Drawing.Color.White;
            this.guna2Button4.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button4.CheckedState.Image = global::benhvien.Properties.Resources.dakhoa;
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.guna2Button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = global::benhvien.Properties.Resources.dakhoa;
            this.guna2Button4.Location = new System.Drawing.Point(31, 428);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(149, 43);
            this.guna2Button4.TabIndex = 2;
            this.guna2Button4.Text = "Đa Khoa";
            this.guna2Button4.UseTransparentBackground = true;
            this.guna2Button4.CheckedChanged += new System.EventHandler(this.btntaikhoan_CheckedChanged);
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnbenhnhan
            // 
            this.btnbenhnhan.BackColor = System.Drawing.Color.Transparent;
            this.btnbenhnhan.BorderRadius = 22;
            this.btnbenhnhan.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnbenhnhan.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnbenhnhan.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnbenhnhan.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.btnbenhnhan.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnbenhnhan.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbenhnhan.ForeColor = System.Drawing.Color.White;
            this.btnbenhnhan.Image = ((System.Drawing.Image)(resources.GetObject("btnbenhnhan.Image")));
            this.btnbenhnhan.Location = new System.Drawing.Point(31, 350);
            this.btnbenhnhan.Name = "btnbenhnhan";
            this.btnbenhnhan.Size = new System.Drawing.Size(149, 43);
            this.btnbenhnhan.TabIndex = 2;
            this.btnbenhnhan.Text = "Bệnh Nhân";
            this.btnbenhnhan.UseTransparentBackground = true;
            this.btnbenhnhan.CheckedChanged += new System.EventHandler(this.btntaikhoan_CheckedChanged);
            this.btnbenhnhan.Click += new System.EventHandler(this.btnbenhnhan_Click);
            // 
            // btnbacsi
            // 
            this.btnbacsi.BackColor = System.Drawing.Color.Transparent;
            this.btnbacsi.BorderRadius = 22;
            this.btnbacsi.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btnbacsi.CheckedState.FillColor = System.Drawing.Color.White;
            this.btnbacsi.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnbacsi.CheckedState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.btnbacsi.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btnbacsi.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbacsi.ForeColor = System.Drawing.Color.White;
            this.btnbacsi.Image = ((System.Drawing.Image)(resources.GetObject("btnbacsi.Image")));
            this.btnbacsi.ImageOffset = new System.Drawing.Point(-8, 0);
            this.btnbacsi.Location = new System.Drawing.Point(31, 268);
            this.btnbacsi.Name = "btnbacsi";
            this.btnbacsi.Size = new System.Drawing.Size(149, 43);
            this.btnbacsi.TabIndex = 2;
            this.btnbacsi.Text = "Bác Sĩ";
            this.btnbacsi.UseTransparentBackground = true;
            this.btnbacsi.CheckedChanged += new System.EventHandler(this.btntaikhoan_CheckedChanged);
            this.btnbacsi.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // btntrangchu
            // 
            this.btntrangchu.BackColor = System.Drawing.Color.Transparent;
            this.btntrangchu.BorderRadius = 22;
            this.btntrangchu.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.btntrangchu.Checked = true;
            this.btntrangchu.CheckedState.FillColor = System.Drawing.Color.White;
            this.btntrangchu.CheckedState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btntrangchu.CheckedState.Image = global::benhvien.Properties.Resources.icons8_hospital_insurance_24;
            this.btntrangchu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.btntrangchu.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntrangchu.ForeColor = System.Drawing.Color.White;
            this.btntrangchu.Image = global::benhvien.Properties.Resources.icons8_hospital_insurance_24;
            this.btntrangchu.Location = new System.Drawing.Point(31, 92);
            this.btntrangchu.Name = "btntrangchu";
            this.btntrangchu.Size = new System.Drawing.Size(149, 43);
            this.btntrangchu.TabIndex = 2;
            this.btntrangchu.Text = "Trang Chủ";
            this.btntrangchu.UseTransparentBackground = true;
            this.btntrangchu.CheckedChanged += new System.EventHandler(this.btntaikhoan_CheckedChanged);
            this.btntrangchu.Click += new System.EventHandler(this.btntaikhoan_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::benhvien.Properties.Resources.icons8_hospital_3_80;
            this.pictureBox1.Location = new System.Drawing.Point(20, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // imgSlide
            // 
            this.imgSlide.Image = ((System.Drawing.Image)(resources.GetObject("imgSlide.Image")));
            this.imgSlide.Location = new System.Drawing.Point(141, 62);
            this.imgSlide.Name = "imgSlide";
            this.imgSlide.Size = new System.Drawing.Size(39, 101);
            this.imgSlide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSlide.TabIndex = 0;
            this.imgSlide.TabStop = false;
            // 
            // Frmquanly
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1072, 608);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frmquanly";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.guna2GroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSlide)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button guna2Button6;
        private Guna.UI2.WinForms.Guna2Button guna2Button5;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnbenhnhan;
        private Guna.UI2.WinForms.Guna2Button btnbacsi;
        private Guna.UI2.WinForms.Guna2Button btntrangchu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgSlide;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button btntaikhoan;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}