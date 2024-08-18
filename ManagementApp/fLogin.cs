using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace QuanLyQuanAo
{
    public partial class fLogin : Form
    {
        public fLogin()
        {
            InitializeComponent();
        }
        
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Const.UserName = txtUserName.Text;
            Const.Password = txtPassword.Text;
            if(Login(Const.UserName, Const.Password))
            {
                this.Hide();
                fMainMenu f = new fMainMenu();
                f.ShowDialog();
                this.txtUserName.Clear();
                this.txtPassword.Clear();
                this.Show();
                txtUserName.Focus();
            }
            else
            {
                MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool Login(string userName, string password)
        {
            return LoginDAL.Instance.Login(userName, password);
        }
        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", 
                MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
