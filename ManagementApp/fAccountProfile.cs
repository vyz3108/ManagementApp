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

namespace QuanLyQuanAo
{
    public partial class fAccountProfile : Form
    {
        public fAccountProfile()
        {
            InitializeComponent();
        }
        #region Method
        public int checkInput()
        {
            if (txtDisplayName.Text != "" 
                && txtPassword.Text != ""
                && txtNewPassword.Text == ""
                && txtRepass.Text == "")
            {
                return 1;
            }
            else if (txtDisplayName.Text == ""
                && txtPassword.Text != ""
                && txtNewPassword.Text != ""
                && txtRepass.Text.Equals( txtNewPassword.Text))
            {
                return 2;
            }
            else if (txtDisplayName.Text != ""
                && txtPassword.Text != ""
                && txtNewPassword.Text != ""
                && txtRepass.Text.Equals(txtNewPassword.Text))
            {
                return 3;
            }
            return 0;
        }
        #endregion
        private void fAccountProfile_Load(object sender, EventArgs e)
        {
            txtUserName.Text = Const.UserName;
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            txtDisplayName.Clear();
            txtPassword.Clear();
            txtNewPassword.Clear();
            txtRepass.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Const.DisplayName = txtDisplayName.Text;
            Const.Password = txtPassword.Text;
            string newPassword = txtNewPassword.Text;
            string rePassord = txtRepass.Text;
            switch (checkInput())
            {
                case 1: // Đổi tên hiển thị
                    UpdateAccountDAL.Instance.Change_DisplayName(Const.UserName, Const.DisplayName, Const.Password);
                    MessageBox.Show("Đổi tên hiển thị thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2: //Đổi mật khẩu
                    if(!newPassword.Equals(Const.Password) && newPassword.Length >= 8)
                    {
                        UpdateAccountDAL.Instance.Change_Password(Const.UserName, Const.Password, newPassword, rePassord);
                        MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                        MessageBox.Show("Mật khẩu mới giống mật khẩu cũ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    break;
                case 3: //Đổi tên hiển thị + mật khẩu
                    if(!newPassword.Equals(Const.Password) && newPassword.Length >= 8 && !txtDisplayName.Equals(Const.DisplayName))
                    {
                        UpdateAccountDAL.Instance.Update_Account(Const.UserName, Const.DisplayName, Const.Password, newPassword, rePassord);
                        MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    break;
                default:
                    MessageBox.Show("Dữ liệu nhập vào không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
            btnClr_Click(sender, e);
        }
    }
}
