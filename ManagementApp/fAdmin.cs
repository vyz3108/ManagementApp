using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace QuanLyQuanAo
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccount();
        }
        #region Method
        public void LoadAccount()
        {
            dtgvAccount.Rows.Clear();
            AccountDAL accDAL = new AccountDAL();
            List<Account> list = accDAL.GetListAccount();
            foreach (var item in list)
            {
                dtgvAccount.Rows.Add(item.UserName, item.DisplayName, item.Type);
            }
        }
        #endregion
        private void btnClr_Click(object sender, EventArgs e)
        {
            txtUserName.Clear();
            txtDisplayName.Clear();
        }
        private void dtgvAccount_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtUserName.Text = dtgvAccount.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDisplayName.Text = dtgvAccount.Rows[e.RowIndex].Cells[1].Value.ToString();
            nb_TypeAccount.Value = Convert.ToInt32(dtgvAccount.Rows[e.RowIndex].Cells[2].Value.ToString());
            
        }
        private void btnSearchAcc_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            dtgvAccount.Rows.Clear();
            AccountDAL accDAL = new AccountDAL();
            List<Account> list = accDAL.GetAccountByUserName(userName);
            foreach (var item in list)
            {
                dtgvAccount.Rows.Add(item.UserName, item.DisplayName, item.Type);
            }
        }
        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            Const.UserName = txtUserName.Text;
            if (Const.UserName != "")
            {
                DialogResult dialogRes = MessageBox.Show($"Bạn chắc chắn đặt lại mật khẩu cho {Const.UserName.ToUpper()}?", "Thông báo", MessageBoxButtons.YesNo);
                if(dialogRes == DialogResult.Yes)
                {
                    UpdateAccountDAL.Instance.Reset_Password(Const.UserName);
                    MessageBox.Show("Đặt lại mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClr_Click(sender, e);
                    LoadAccount();
                }
            }
        }
        private void btnAddAd_Click(object sender, EventArgs e)
        {
            Const.UserName = txtUserName.Text;
            AccountBLL accBll = new AccountBLL();
            List<Account> list = accBll.GetAccountByUserName(Const.UserName);
            if (list.Count == 0)
            {
                Const.DisplayName = txtDisplayName.Text;
                Const.LoaiTaiKhoan = Convert.ToInt32(nb_TypeAccount.Value);
                UpdateAccountDAL.Instance.AD_Add_Account(Const.UserName, Const.DisplayName, Const.LoaiTaiKhoan);
                MessageBox.Show($"Đã thêm tài khoản {Const.UserName}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClr_Click(sender, e);
                LoadAccount();
            }
            else { MessageBox.Show($"Tài khoản {Const.UserName} đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnEditAd_Click(object sender, EventArgs e)
        {
            Const.UserName = txtUserName.Text;
            AccountBLL accBll = new AccountBLL();
            List<Account> list = accBll.GetAccountByUserName(Const.UserName);
            if (list.Count > 0)
            {
                Const.DisplayName = txtDisplayName.Text;
                Const.LoaiTaiKhoan = Convert.ToInt32(nb_TypeAccount.Value);
                UpdateAccountDAL.Instance.AD_Edit_Account(Const.UserName, Const.DisplayName, Const.LoaiTaiKhoan);
                MessageBox.Show($"Đã cập nhật cho tài khoản {Const.UserName}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClr_Click(sender, e);
                LoadAccount();
            }
            else { MessageBox.Show($"Tài khoản {Const.UserName} không tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void btnDelAd_Click(object sender, EventArgs e)
        {
            Const.UserName = txtUserName.Text;
            if (Const.UserName != "")
            {
                DialogResult dialogRes = MessageBox.Show($"Bạn chắc chắn xóa tài khoản {Const.UserName.ToUpper()}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(dialogRes == DialogResult.Yes)
                {
                    UpdateAccountDAL.Instance.AD_Delete_Account(Const.UserName);
                    MessageBox.Show($"Đã xóa tài khoản {Const.UserName}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClr_Click(sender, e);
                    LoadAccount();
                }
            }
            else
            {
                MessageBox.Show($"Không tìm thấy tài khoản {Const.UserName}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
