
namespace benhvien
{
    partial class FrmNhapViên
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
            this.grbbenhan = new System.Windows.Forms.GroupBox();
            this.dtpGiaTriBHYT = new System.Windows.Forms.DateTimePicker();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbbGioitinh = new System.Windows.Forms.ComboBox();
            this.cbbDoiTuong = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblquoctich = new System.Windows.Forms.Label();
            this.lblsobhyt = new System.Windows.Forms.Label();
            this.lbldantoc = new System.Windows.Forms.Label();
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
            this.grbbenhan.SuspendLayout();
            this.SuspendLayout();
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
            this.grbbenhan.Location = new System.Drawing.Point(11, 11);
            this.grbbenhan.Margin = new System.Windows.Forms.Padding(2);
            this.grbbenhan.Name = "grbbenhan";
            this.grbbenhan.Padding = new System.Windows.Forms.Padding(2);
            this.grbbenhan.Size = new System.Drawing.Size(651, 184);
            this.grbbenhan.TabIndex = 33;
            this.grbbenhan.TabStop = false;
            this.grbbenhan.Text = "Thông Tin Bệnh Nhân";
            // 
            // dtpGiaTriBHYT
            // 
            this.dtpGiaTriBHYT.CustomFormat = "dd/MM/yyyy";
            this.dtpGiaTriBHYT.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpGiaTriBHYT.Location = new System.Drawing.Point(500, 156);
            this.dtpGiaTriBHYT.Margin = new System.Windows.Forms.Padding(2);
            this.dtpGiaTriBHYT.Name = "dtpGiaTriBHYT";
            this.dtpGiaTriBHYT.Size = new System.Drawing.Size(133, 21);
            this.dtpGiaTriBHYT.TabIndex = 10;
            this.dtpGiaTriBHYT.Value = new System.DateTime(2021, 10, 22, 0, 0, 0, 0);
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(500, 23);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(133, 21);
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
            this.cbbGioitinh.Location = new System.Drawing.Point(129, 76);
            this.cbbGioitinh.Margin = new System.Windows.Forms.Padding(2);
            this.cbbGioitinh.Name = "cbbGioitinh";
            this.cbbGioitinh.Size = new System.Drawing.Size(90, 21);
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
            this.cbbDoiTuong.Location = new System.Drawing.Point(500, 85);
            this.cbbDoiTuong.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDoiTuong.Name = "cbbDoiTuong";
            this.cbbDoiTuong.Size = new System.Drawing.Size(132, 23);
            this.cbbDoiTuong.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gía Trị BHYT Đến Ngày";
            // 
            // lblquoctich
            // 
            this.lblquoctich.AutoSize = true;
            this.lblquoctich.Location = new System.Drawing.Point(19, 161);
            this.lblquoctich.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblquoctich.Name = "lblquoctich";
            this.lblquoctich.Size = new System.Drawing.Size(62, 15);
            this.lblquoctich.TabIndex = 0;
            this.lblquoctich.Text = "Quốc Tịch";
            // 
            // lblsobhyt
            // 
            this.lblsobhyt.AutoSize = true;
            this.lblsobhyt.Location = new System.Drawing.Point(397, 124);
            this.lblsobhyt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblsobhyt.Name = "lblsobhyt";
            this.lblsobhyt.Size = new System.Drawing.Size(56, 15);
            this.lblsobhyt.TabIndex = 0;
            this.lblsobhyt.Text = "Số BHYT";
            // 
            // lbldantoc
            // 
            this.lbldantoc.AutoSize = true;
            this.lbldantoc.Location = new System.Drawing.Point(19, 130);
            this.lbldantoc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldantoc.Name = "lbldantoc";
            this.lbldantoc.Size = new System.Drawing.Size(49, 15);
            this.lbldantoc.TabIndex = 0;
            this.lbldantoc.Text = "Dân tộc";
            // 
            // lbldiachi
            // 
            this.lbldiachi.AutoSize = true;
            this.lbldiachi.Location = new System.Drawing.Point(19, 102);
            this.lbldiachi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldiachi.Name = "lbldiachi";
            this.lbldiachi.Size = new System.Drawing.Size(47, 15);
            this.lbldiachi.TabIndex = 0;
            this.lbldiachi.Text = "Địa Chỉ";
            // 
            // txtquoctich
            // 
            this.txtquoctich.Location = new System.Drawing.Point(129, 158);
            this.txtquoctich.Margin = new System.Windows.Forms.Padding(2);
            this.txtquoctich.Name = "txtquoctich";
            this.txtquoctich.Size = new System.Drawing.Size(164, 21);
            this.txtquoctich.TabIndex = 5;
            // 
            // txtbhyt
            // 
            this.txtbhyt.Location = new System.Drawing.Point(501, 119);
            this.txtbhyt.Margin = new System.Windows.Forms.Padding(2);
            this.txtbhyt.Name = "txtbhyt";
            this.txtbhyt.Size = new System.Drawing.Size(132, 21);
            this.txtbhyt.TabIndex = 9;
            // 
            // txtdantoc
            // 
            this.txtdantoc.Location = new System.Drawing.Point(129, 130);
            this.txtdantoc.Margin = new System.Windows.Forms.Padding(2);
            this.txtdantoc.Name = "txtdantoc";
            this.txtdantoc.Size = new System.Drawing.Size(164, 21);
            this.txtdantoc.TabIndex = 4;
            // 
            // txtdiachi
            // 
            this.txtdiachi.Location = new System.Drawing.Point(129, 102);
            this.txtdiachi.Margin = new System.Windows.Forms.Padding(2);
            this.txtdiachi.Name = "txtdiachi";
            this.txtdiachi.Size = new System.Drawing.Size(164, 21);
            this.txtdiachi.TabIndex = 3;
            // 
            // lbldoituong
            // 
            this.lbldoituong.AutoSize = true;
            this.lbldoituong.Location = new System.Drawing.Point(397, 92);
            this.lbldoituong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldoituong.Name = "lbldoituong";
            this.lbldoituong.Size = new System.Drawing.Size(64, 15);
            this.lbldoituong.TabIndex = 0;
            this.lbldoituong.Text = "Đối Tượng";
            // 
            // txtnghe
            // 
            this.txtnghe.Location = new System.Drawing.Point(500, 52);
            this.txtnghe.Margin = new System.Windows.Forms.Padding(2);
            this.txtnghe.Name = "txtnghe";
            this.txtnghe.Size = new System.Drawing.Size(133, 21);
            this.txtnghe.TabIndex = 7;
            // 
            // txthoten
            // 
            this.txthoten.Location = new System.Drawing.Point(129, 49);
            this.txthoten.Margin = new System.Windows.Forms.Padding(2);
            this.txthoten.Name = "txthoten";
            this.txthoten.Size = new System.Drawing.Size(164, 21);
            this.txthoten.TabIndex = 1;
            // 
            // lblnghenghiep
            // 
            this.lblnghenghiep.AutoSize = true;
            this.lblnghenghiep.Location = new System.Drawing.Point(397, 57);
            this.lblnghenghiep.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblnghenghiep.Name = "lblnghenghiep";
            this.lblnghenghiep.Size = new System.Drawing.Size(80, 15);
            this.lblnghenghiep.TabIndex = 0;
            this.lblnghenghiep.Text = "Nghề Nghiệp";
            // 
            // txtmabenh
            // 
            this.txtmabenh.Location = new System.Drawing.Point(129, 22);
            this.txtmabenh.Margin = new System.Windows.Forms.Padding(2);
            this.txtmabenh.Name = "txtmabenh";
            this.txtmabenh.Size = new System.Drawing.Size(90, 21);
            this.txtmabenh.TabIndex = 0;
            // 
            // lblma
            // 
            this.lblma.AutoSize = true;
            this.lblma.Location = new System.Drawing.Point(19, 26);
            this.lblma.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblma.Name = "lblma";
            this.lblma.Size = new System.Drawing.Size(45, 15);
            this.lblma.TabIndex = 0;
            this.lblma.Text = "Mã BN";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 51);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 15);
            this.label9.TabIndex = 0;
            this.label9.Text = "Họ tên ";
            // 
            // lblgioitinh
            // 
            this.lblgioitinh.AutoSize = true;
            this.lblgioitinh.Location = new System.Drawing.Point(19, 76);
            this.lblgioitinh.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblgioitinh.Name = "lblgioitinh";
            this.lblgioitinh.Size = new System.Drawing.Size(56, 15);
            this.lblgioitinh.TabIndex = 0;
            this.lblgioitinh.Text = "Giới Tính";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày Sinh ";
            // 
            // FrmNhapViên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 467);
            this.Controls.Add(this.grbbenhan);
            this.Name = "FrmNhapViên";
            this.Text = "FrmNhapViên";
            this.grbbenhan.ResumeLayout(false);
            this.grbbenhan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbbenhan;
        private System.Windows.Forms.DateTimePicker dtpGiaTriBHYT;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.ComboBox cbbGioitinh;
        private System.Windows.Forms.ComboBox cbbDoiTuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblquoctich;
        private System.Windows.Forms.Label lblsobhyt;
        private System.Windows.Forms.Label lbldantoc;
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
    }
}