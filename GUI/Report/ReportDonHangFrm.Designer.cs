namespace pharmacy_management.GUI.Report
{
    partial class ReportDonHangFrm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.donhangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ql_nhathuocDataSet = new pharmacy_management.ql_nhathuocDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.donhangTableAdapter = new pharmacy_management.ql_nhathuocDataSetTableAdapters.donhangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.donhangBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_nhathuocDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // donhangBindingSource
            // 
            this.donhangBindingSource.DataMember = "donhang";
            this.donhangBindingSource.DataSource = this.ql_nhathuocDataSet;
            // 
            // ql_nhathuocDataSet
            // 
            this.ql_nhathuocDataSet.DataSetName = "ql_nhathuocDataSet";
            this.ql_nhathuocDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.donhangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "pharmacy_management.GUI.Report.rDonHang.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(825, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // donhangTableAdapter
            // 
            this.donhangTableAdapter.ClearBeforeFill = true;
            // 
            // ReportDonHangFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportDonHangFrm";
            this.Text = "Report Đơn hàng";
            this.Load += new System.EventHandler(this.ReportDonHangFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.donhangBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ql_nhathuocDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ql_nhathuocDataSet ql_nhathuocDataSet;
        private System.Windows.Forms.BindingSource donhangBindingSource;
        private ql_nhathuocDataSetTableAdapters.donhangTableAdapter donhangTableAdapter;
    }
}