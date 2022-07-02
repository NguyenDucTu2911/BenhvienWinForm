
namespace benhvien
{
    partial class FrmReportThuoc_VatTu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportThuoc_VatTu));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdovattu = new System.Windows.Forms.RadioButton();
            this.rdointhuoc = new System.Windows.Forms.RadioButton();
            this.btnINBS = new System.Windows.Forms.Button();
            this.cbbvattu = new System.Windows.Forms.ComboBox();
            this.cbbthuoc = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "benhvien.Report.ReportBacSi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(11, 131);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(920, 490);
            this.reportViewer1.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdovattu);
            this.groupBox1.Controls.Add(this.rdointhuoc);
            this.groupBox1.Controls.Add(this.btnINBS);
            this.groupBox1.Controls.Add(this.cbbthuoc);
            this.groupBox1.Controls.Add(this.cbbvattu);
            this.groupBox1.Location = new System.Drawing.Point(249, 21);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(405, 97);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thuốc và Vật Tư";
            // 
            // rdovattu
            // 
            this.rdovattu.AutoSize = true;
            this.rdovattu.Location = new System.Drawing.Point(16, 56);
            this.rdovattu.Margin = new System.Windows.Forms.Padding(2);
            this.rdovattu.Name = "rdovattu";
            this.rdovattu.Size = new System.Drawing.Size(69, 17);
            this.rdovattu.TabIndex = 2;
            this.rdovattu.TabStop = true;
            this.rdovattu.Text = "In Vật Tư";
            this.rdovattu.UseVisualStyleBackColor = true;
            this.rdovattu.CheckedChanged += new System.EventHandler(this.rdovattu_CheckedChanged);
            // 
            // rdointhuoc
            // 
            this.rdointhuoc.AutoSize = true;
            this.rdointhuoc.Location = new System.Drawing.Point(16, 29);
            this.rdointhuoc.Margin = new System.Windows.Forms.Padding(2);
            this.rdointhuoc.Name = "rdointhuoc";
            this.rdointhuoc.Size = new System.Drawing.Size(68, 17);
            this.rdointhuoc.TabIndex = 2;
            this.rdointhuoc.TabStop = true;
            this.rdointhuoc.Text = "In Thuốc";
            this.rdointhuoc.UseVisualStyleBackColor = true;
            this.rdointhuoc.CheckedChanged += new System.EventHandler(this.rdointhuoc_CheckedChanged);
            // 
            // btnINBS
            // 
            this.btnINBS.BackColor = System.Drawing.Color.LightGray;
            this.btnINBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINBS.Image = ((System.Drawing.Image)(resources.GetObject("btnINBS.Image")));
            this.btnINBS.Location = new System.Drawing.Point(291, 55);
            this.btnINBS.Margin = new System.Windows.Forms.Padding(2);
            this.btnINBS.Name = "btnINBS";
            this.btnINBS.Size = new System.Drawing.Size(98, 28);
            this.btnINBS.TabIndex = 1;
            this.btnINBS.Text = "In Bác Sĩ";
            this.btnINBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnINBS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnINBS.UseVisualStyleBackColor = false;
            this.btnINBS.Click += new System.EventHandler(this.btnINBS_Click);
            // 
            // cbbvattu
            // 
            this.cbbvattu.FormattingEnabled = true;
            this.cbbvattu.Location = new System.Drawing.Point(116, 55);
            this.cbbvattu.Margin = new System.Windows.Forms.Padding(2);
            this.cbbvattu.Name = "cbbvattu";
            this.cbbvattu.Size = new System.Drawing.Size(131, 21);
            this.cbbvattu.TabIndex = 0;
            // 
            // cbbthuoc
            // 
            this.cbbthuoc.FormattingEnabled = true;
            this.cbbthuoc.Location = new System.Drawing.Point(116, 25);
            this.cbbthuoc.Margin = new System.Windows.Forms.Padding(2);
            this.cbbthuoc.Name = "cbbthuoc";
            this.cbbthuoc.Size = new System.Drawing.Size(131, 21);
            this.cbbthuoc.TabIndex = 0;
            // 
            // FrmReportThuoc_VatTu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 626);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportThuoc_VatTu";
            this.Text = "FrmReportThuoc_VatTu";
            this.Load += new System.EventHandler(this.FrmReportThuoc_VatTu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdovattu;
        private System.Windows.Forms.RadioButton rdointhuoc;
        private System.Windows.Forms.Button btnINBS;
        private System.Windows.Forms.ComboBox cbbthuoc;
        private System.Windows.Forms.ComboBox cbbvattu;
    }
}