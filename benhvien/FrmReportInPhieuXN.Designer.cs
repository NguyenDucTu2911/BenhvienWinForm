namespace benhvien
{
    partial class FrmReportInPhieuXN
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportInPhieuXN));
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmaBN = new System.Windows.Forms.TextBox();
            this.rdokhoa = new System.Windows.Forms.RadioButton();
            this.rdotatca = new System.Windows.Forms.RadioButton();
            this.btnINBS = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "benhvien.Report.ReportInPhieuXN.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 146);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1173, 490);
            this.reportViewer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtmaBN);
            this.groupBox1.Controls.Add(this.rdokhoa);
            this.groupBox1.Controls.Add(this.rdotatca);
            this.groupBox1.Controls.Add(this.btnINBS);
            this.groupBox1.Location = new System.Drawing.Point(287, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(625, 119);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Bệnh Nhân";
            // 
            // txtmaBN
            // 
            this.txtmaBN.Location = new System.Drawing.Point(269, 66);
            this.txtmaBN.Multiline = true;
            this.txtmaBN.Name = "txtmaBN";
            this.txtmaBN.Size = new System.Drawing.Size(141, 30);
            this.txtmaBN.TabIndex = 3;
            // 
            // rdokhoa
            // 
            this.rdokhoa.AutoSize = true;
            this.rdokhoa.Location = new System.Drawing.Point(22, 74);
            this.rdokhoa.Name = "rdokhoa";
            this.rdokhoa.Size = new System.Drawing.Size(226, 20);
            this.rdokhoa.TabIndex = 2;
            this.rdokhoa.TabStop = true;
            this.rdokhoa.Text = "In Phiếu Xét Nghiệm Theo Mã BN";
            this.rdokhoa.UseVisualStyleBackColor = true;
            this.rdokhoa.CheckedChanged += new System.EventHandler(this.rdokhoa_CheckedChanged);
            // 
            // rdotatca
            // 
            this.rdotatca.AutoSize = true;
            this.rdotatca.Location = new System.Drawing.Point(22, 36);
            this.rdotatca.Name = "rdotatca";
            this.rdotatca.Size = new System.Drawing.Size(190, 20);
            this.rdotatca.TabIndex = 2;
            this.rdotatca.TabStop = true;
            this.rdotatca.Text = "In Tất Cả Phiếu Xét Nghiệm";
            this.rdotatca.UseVisualStyleBackColor = true;
            this.rdotatca.CheckedChanged += new System.EventHandler(this.rdotatca_CheckedChanged);
            // 
            // btnINBS
            // 
            this.btnINBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINBS.Image = ((System.Drawing.Image)(resources.GetObject("btnINBS.Image")));
            this.btnINBS.Location = new System.Drawing.Point(444, 60);
            this.btnINBS.Name = "btnINBS";
            this.btnINBS.Size = new System.Drawing.Size(152, 36);
            this.btnINBS.TabIndex = 1;
            this.btnINBS.Text = "In Phiếu XN";
            this.btnINBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnINBS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnINBS.UseVisualStyleBackColor = true;
            this.btnINBS.Click += new System.EventHandler(this.btnINBS_Click);
            // 
            // FrmReportInPhieuXN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1197, 648);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportInPhieuXN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmReportInPhieuXN";
            this.Load += new System.EventHandler(this.FrmReportInPhieuXN_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtmaBN;
        private System.Windows.Forms.RadioButton rdokhoa;
        private System.Windows.Forms.RadioButton rdotatca;
        private System.Windows.Forms.Button btnINBS;
    }
}