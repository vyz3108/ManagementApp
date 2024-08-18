using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;

namespace QuanLyQuanAo
{
    public partial class fOrders : Form
    {
        public fOrders()
        {
            InitializeComponent();
        }

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {

        }
        public void GetBillList()
        {
            dtgvlistOrder.Rows.Clear();
            BillBLL pdBLL = new BillBLL();
            List<Bill> list = pdBLL.GetBillList();
            foreach (var item in list)
            {
                dtgvlistOrder.Rows.Add(item.ID, item.IdCustomer, item.BuyTime);
            }
        }
        private void fOrders_Load(object sender, EventArgs e)
        {
            GetBillList();
        }

        private void txtQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnDelOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnEditOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnClrOrder_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtPhone.Clear();
            txtAddr.Clear();
        }
    }
}
