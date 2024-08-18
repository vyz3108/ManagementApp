using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAo
{
    public partial class fProducts : Form
    {
        public fProducts()
        {
            InitializeComponent();
            LoadTheme();
        }
        #region Method
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        public void loadProductList()
        {
            dtgvProducts.Rows.Clear();
            ProductBLL pdBLL = new ProductBLL();
            List<Product> list = pdBLL.LoadProductList();
            foreach (var item in list)
            {
                dtgvProducts.Rows.Add(item.ID, item.Name,item.Price, item.Image);
                
            }
        }
        public void loadDataSrc()
        {
            CategoryBLL categoryBLL = new CategoryBLL();
            List<Category> list = categoryBLL.LoadCategoryList();
            foreach (var i in list)
            {
                cbProductType.Items.Add(i.Name);
            }
        }
        private void btnSearchProd_Click(object sender, EventArgs e)
        {
            int id;
            if (txtSearchId.Text == "")
            {
                loadProductList();
            }
            else
            {
                id = Convert.ToInt32(txtSearchId.Text);
                dtgvProducts.Rows.Clear();
                ProductBLL prdBLL = new ProductBLL();
                List<Product> list = prdBLL.GetProductById(id);
                foreach (var item in list)
                {
                    dtgvProducts.Rows.Add(item.ID, item.Name, item.IdCategory, item.Price, item.Image);
                }
            }
        }
        private void fProducts_Load(object sender, EventArgs e)
        {
            loadProductList();
            loadDataSrc();
        }
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                file.Filter = "jpg files(*.jpg)|*.jpg|" +
                            "PNG files(*.png)|*.png|" +
                            "All Files(*.*)|*.*";
                if(file.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = file.FileName;
                    txtIamge.Text = imageLocation;
                    imgProduct.ImageLocation = imageLocation;
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Không tìm thấy hình ảnh", "404 Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClr_Click(object sender, EventArgs e)
        {
            txtProductName.Clear();
            txtPrice.Value = 0;
            txtIamge.Clear();

        }
        private void dtgvProducts_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtSearchId.Text = dtgvProducts.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtProductName.Text = dtgvProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtPrice.Text = dtgvProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtIamge.Text = dtgvProducts.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (txtIamge.Text == "") txtIamge.Text = Application.StartupPath + "\\Resources\\" + "clothes-examples.png";
            else
            {
                Bitmap bitmap = new Bitmap($"{txtIamge.Text}");
                imgProduct.Image = bitmap;
            }
        }

        private void btnAddProd_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            string categoryName = cbProductType.Text;
            if (!categoryName.Equals("---Chọn loại---"))
            {
                int idCategory = cbProductType.SelectedIndex+1;
                float price = Convert.ToSingle(txtPrice.Value);
                string image = txtIamge.Text;
                ProductDAL.Instance.Add_Product(productName, idCategory, price, image);
                MessageBox.Show($"Đã thêm sản phẩm {productName}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnClr_Click(sender, e);
            loadProductList();
        }
        private void btnEditProd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtSearchId.Text);
            string productName = txtProductName.Text;
            int idCategory = cbProductType.SelectedIndex + 1;
            float price = Convert.ToSingle(txtPrice.Value);
            string image = txtIamge.Text;
            if (id > 0)
            {
                ProductDAL.Instance.Update_Product(id ,productName, idCategory, price, image);
                MessageBox.Show($"Đã cập nhật sản phẩm {productName}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnClr_Click(sender, e);
            loadProductList();
        }
        private void btnDelProd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtSearchId.Text);
            if (id != 0)
            {
                DialogResult dialogRes = MessageBox.Show($"Bạn chắc chắn xóa sản phẩm id:{id}?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogRes == DialogResult.Yes)
                {
                    ProductDAL.Instance.Delete_Product(id);
                    MessageBox.Show($"Đã xóa sản phẩm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnClr_Click(sender, e);
                    loadProductList();
                }
            }
            else {MessageBox.Show($"Không tìm thấy sản phẩm id:{id}!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);}
        }
        private void txtSearchId_KeyPress(object sender, KeyPressEventArgs e)
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
        #endregion
    }
}
