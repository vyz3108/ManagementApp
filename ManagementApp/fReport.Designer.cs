namespace QuanLyQuanAo
{
    partial class fReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource6 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource7 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.tblProductBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qL_QuanAoDataSet = new ManagementApp.QL_QuanAoDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblProductTableAdapter = new ManagementApp.QL_QuanAoDataSetTableAdapters.tblProductTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tblCustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblCustomerTableAdapter1 = new ManagementApp.QL_QuanAoDataSetTableAdapters.tblCustomerTableAdapter();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tblCustomerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_QuanAoDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tblProductBindingSource
            // 
            this.tblProductBindingSource.DataMember = "tblProduct";
            this.tblProductBindingSource.DataSource = this.qL_QuanAoDataSet;
            // 
            // qL_QuanAoDataSet
            // 
            this.qL_QuanAoDataSet.DataSetName = "QL_QuanAoDataSet";
            this.qL_QuanAoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource6.Name = "DataSet1";
            reportDataSource6.Value = this.tblProductBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource6);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "ManagementApp.rReportProduct.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 36);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1026, 656);
            this.reportViewer1.TabIndex = 0;
            // 
            // tblProductTableAdapter
            // 
            this.tblProductTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sảnPhẩmToolStripMenuItem,
            this.kháchHàngToolStripMenuItem});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(91, 29);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // sảnPhẩmToolStripMenuItem
            // 
            this.sảnPhẩmToolStripMenuItem.Name = "sảnPhẩmToolStripMenuItem";
            this.sảnPhẩmToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.sảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.sảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            this.sảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.sảnPhẩmToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // tblCustomerBindingSource
            // 
            this.tblCustomerBindingSource.DataMember = "tblCustomer";
            this.tblCustomerBindingSource.DataSource = this.qL_QuanAoDataSet;
            // 
            // tblCustomerTableAdapter1
            // 
            this.tblCustomerTableAdapter1.ClearBeforeFill = true;
            // 
            // reportViewer2
            // 
            reportDataSource7.Name = "DataSet1";
            reportDataSource7.Value = this.tblCustomerBindingSource1;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource7);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "ManagementApp.rCustomer.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 36);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1026, 656);
            this.reportViewer2.TabIndex = 2;
            // 
            // tblCustomerBindingSource1
            // 
            this.tblCustomerBindingSource1.DataMember = "tblCustomer";
            this.tblCustomerBindingSource1.DataSource = this.qL_QuanAoDataSet;
            // 
            // fReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1026, 692);
            this.Controls.Add(this.reportViewer2);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fReport";
            this.Text = "Báo cáo";
            this.Load += new System.EventHandler(this.fReporting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProductBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qL_QuanAoDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblCustomerBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ManagementApp.QL_QuanAoDataSet qL_QuanAoDataSet;
        private System.Windows.Forms.BindingSource tblProductBindingSource;
        private ManagementApp.QL_QuanAoDataSetTableAdapters.tblProductTableAdapter tblProductTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource;
        private ManagementApp.QL_QuanAoDataSetTableAdapters.tblCustomerTableAdapter tblCustomerTableAdapter1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource tblCustomerBindingSource1;
    }
}