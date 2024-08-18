using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace QuanLyQuanAo
{
    public partial class fCustomers : Form
    {
        public fCustomers()
        {
            InitializeComponent();
            btnDelCus.Enabled = false;
        }
        #region Method 
        public void LoadCustomerList()
        {
            dtgvCustomer.Rows.Clear();
            CustomerBLL pdBLL = new CustomerBLL();
            List<Customer> list = pdBLL.LoadCustomerList();
            foreach (var item in list)
            {
                dtgvCustomer.Rows.Add(item.ID, item.Name, item.Address, item.Sdt);
            }
        }
        #endregion
        private void btnSearchCus_Click(object sender, EventArgs e)
        {
            if (txtSearchCustomer.Text.Equals(""))
            {
                LoadCustomerList();
            }
            else
            {
                dtgvCustomer.Rows.Clear();
                int id = Convert.ToInt32(txtSearchCustomer.Text);
                CustomerBLL cusBLL = new CustomerBLL();
                List<Customer> list = cusBLL.GetCustomerById(id);
                foreach (var item in list)
                {
                    dtgvCustomer.Rows.Add(item.ID, item.Name, item.Address, item.Sdt);
                }
            }
            
        }
        private void fCustomers_Load(object sender, EventArgs e)
        {
            LoadCustomerList();
        }
        private void txtSearchCustomer_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnAddCus_Click(object sender, EventArgs e)
        {
            if (!txtSearchCustomer.Text.Equals(""))
            {
                int id = Convert.ToInt32(txtSearchCustomer.Text);
                string name = txtCusName.Text;
                string address = txtCusAddr.Text;
                string sdt = txtCusSDT.Text;
                CustomerDAL.Instance.Add_Customer(name, address, sdt);
                MessageBox.Show($"Đã thêm khách hàng {name}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClr_Click(sender, e);
                LoadCustomerList();
            }
        }

        private void btnDelCus_Click(object sender, EventArgs e)
        {
            
            string name = txtCusName.Text;
            if (!txtSearchCustomer.Text.Equals(""))
            {
                int id = Convert.ToInt32(txtSearchCustomer.Text);
                DialogResult dialogRes = MessageBox.Show($"Bạn chắc chắn xóa khách hàng {name}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogRes == DialogResult.Yes)
                {
                    CustomerDAL.Instance.Delete_Customer(id);
                    MessageBox.Show($"Đã xóa khách hàng {name}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClr_Click(sender, e);
                    LoadCustomerList();
                }
            }
            else { MessageBox.Show($"Không tìm thấy khách hàng {name}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void btnEditCus_Click(object sender, EventArgs e)
        {
            if (!txtSearchCustomer.Text.Equals(""))
            {
                int id = Convert.ToInt32(txtSearchCustomer.Text);
                string name = txtCusName.Text;
                string address = txtCusAddr.Text;
                string sdt = txtCusSDT.Text;
                CustomerDAL.Instance.Update_Customer(id, name, address, sdt);
                MessageBox.Show($"Đã cập nhật khách hàng {name}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClr_Click(sender, e);
                LoadCustomerList();
            }
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtCusName.Clear();
            txtCusAddr.Clear();
            txtCusSDT.Clear();
            txtSearchCustomer.Clear();
        }

        private void dtgvCustomer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtSearchCustomer.Text = dtgvCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCusName.Text = dtgvCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtCusAddr.Text = dtgvCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCusSDT.Text = dtgvCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
