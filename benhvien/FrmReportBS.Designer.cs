namespace benhvien
{
    partial class FrmReportBS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReportBS));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdokhoa = new System.Windows.Forms.RadioButton();
            this.rdotatca = new System.Windows.Forms.RadioButton();
            this.btnINBS = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.khoarreportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DSbacsiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoarreportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSbacsiBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdokhoa);
            this.groupBox1.Controls.Add(this.rdotatca);
            this.groupBox1.Controls.Add(this.btnINBS);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(288, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(552, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Khoa Muốn xuất";
            // 
            // rdokhoa
            // 
            this.rdokhoa.AutoSize = true;
            this.rdokhoa.Location = new System.Drawing.Point(22, 69);
            this.rdokhoa.Name = "rdokhoa";
            this.rdokhoa.Size = new System.Drawing.Size(151, 20);
            this.rdokhoa.TabIndex = 2;
            this.rdokhoa.TabStop = true;
            this.rdokhoa.Text = "In Bác Sĩ Theo Khoa";
            this.rdokhoa.UseVisualStyleBackColor = true;
            this.rdokhoa.CheckedChanged += new System.EventHandler(this.rdokhoa_CheckedChanged);
            // 
            // rdotatca
            // 
            this.rdotatca.AutoSize = true;
            this.rdotatca.Location = new System.Drawing.Point(22, 36);
            this.rdotatca.Name = "rdotatca";
            this.rdotatca.Size = new System.Drawing.Size(117, 20);
            this.rdotatca.TabIndex = 2;
            this.rdotatca.TabStop = true;
            this.rdotatca.Text = "In tất cả Bác Sĩ";
            this.rdotatca.UseVisualStyleBackColor = true;
            this.rdotatca.CheckedChanged += new System.EventHandler(this.rdotatca_CheckedChanged);
            // 
            // btnINBS
            // 
            this.btnINBS.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnINBS.Image = ((System.Drawing.Image)(resources.GetObject("btnINBS.Image")));
            this.btnINBS.Location = new System.Drawing.Point(400, 62);
            this.btnINBS.Name = "btnINBS";
            this.btnINBS.Size = new System.Drawing.Size(131, 34);
            this.btnINBS.TabIndex = 1;
            this.btnINBS.Text = "In Bác Sĩ";
            this.btnINBS.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnINBS.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnINBS.UseVisualStyleBackColor = true;
            this.btnINBS.Click += new System.EventHandler(this.btnINBS_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(204, 68);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(173, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "benhvien.Report.ReportBacSi.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 156);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1226, 603);
            this.reportViewer1.TabIndex = 5;
            // 
            // FrmReportBS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 760);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FrmReportBS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống Kê Bác Sĩ";
            this.Load += new System.EventHandler(this.FrmReportBS_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khoarreportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DSbacsiBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource khoarreportBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdokhoa;
        private System.Windows.Forms.RadioButton rdotatca;
        private System.Windows.Forms.Button btnINBS;
        private System.Windows.Forms.ComboBox comboBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource DSbacsiBindingSource;
    }
}