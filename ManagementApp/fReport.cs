using Microsoft.Reporting.WinForms;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo
{
    public partial class fReport : Form
    {
        public fReport()
        {
            InitializeComponent();
        }

        private void fReporting_Load(object sender, EventArgs e)
        {
            
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.reportViewer2.Hide();
            this.reportViewer1.Show();
            this.tblProductTableAdapter.Fill(this.qL_QuanAoDataSet.tblProduct);
            this.reportViewer1.RefreshReport();
        }
        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.reportViewer1.Hide();
            this.reportViewer2.Show();
            this.tblCustomerTableAdapter1.Fill(this.qL_QuanAoDataSet.tblCustomer);
            this.reportViewer2.RefreshReport();
        }
    }
}
