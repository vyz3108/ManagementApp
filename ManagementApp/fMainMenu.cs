using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo
{
    public partial class fMainMenu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public fMainMenu()
        {
            InitializeComponent();
            loadLoginInfo();
            lbHello.Text = Const.DisplayName;
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            button2.Enabled = false;
        }
        #region Method
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //Methods
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        public void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }
        public void loadLoginInfo()
        {
            AccountDAL accDAL = new AccountDAL();
            List<Account> list = accDAL.GetAccountByUserName(Const.UserName);
            foreach (Account account in list)
            {
                Const.DisplayName = account.DisplayName;
                Const.LoaiTaiKhoan = account.Type;
            }
            if (Const.LoaiTaiKhoan.Equals(2))
                btnManagerAccount.Enabled = false;
            else
                btnManagerAccount.Enabled = true;
        }
        #endregion

        private void btnAccountProfile_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new fAccountProfile(), sender);
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fCustomers(), sender);
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fProducts(), sender);
        }

        //private void btnOrders_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new fReporting(), sender);
        //}


        private void btnManagerAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fAdmin(), sender);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void btnCloseChildForm_Click_1(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
            Reset();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fReport(), sender);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new fOrders(), sender);
        }
    }


}
