namespace QuanLyQuanAo
{
    partial class fProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fProducts));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchId = new System.Windows.Forms.TextBox();
            this.btnDelProd = new System.Windows.Forms.Button();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.imgProduct = new System.Windows.Forms.PictureBox();
            this.btnAddProd = new System.Windows.Forms.Button();
            this.btnEditProd = new System.Windows.Forms.Button();
            this.btnSearchProd = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtIamge = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbProductType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvProducts = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtPrice = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtSearchId);
            this.groupBox1.Controls.Add(this.btnDelProd);
            this.groupBox1.Controls.Add(this.btnOpenFile);
            this.groupBox1.Controls.Add(this.imgProduct);
            this.groupBox1.Controls.Add(this.btnAddProd);
            this.groupBox1.Controls.Add(this.btnEditProd);
            this.groupBox1.Controls.Add(this.btnSearchProd);
            this.groupBox1.Controls.Add(this.btnClr);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.panel3);
            this.groupBox1.Location = new System.Drawing.Point(10, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1001, 220);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(620, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Mã";
            // 
            // txtSearchId
            // 
            this.txtSearchId.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchId.ForeColor = System.Drawing.Color.Black;
            this.txtSearchId.Location = new System.Drawing.Point(657, 175);
            this.txtSearchId.Name = "txtSearchId";
            this.txtSearchId.Size = new System.Drawing.Size(97, 30);
            this.txtSearchId.TabIndex = 9;
            this.txtSearchId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchId_KeyPress);
            // 
            // btnDelProd
            // 
            this.btnDelProd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelProd.Location = new System.Drawing.Point(137, 175);
            this.btnDelProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelProd.Name = "btnDelProd";
            this.btnDelProd.Size = new System.Drawing.Size(112, 35);
            this.btnDelProd.TabIndex = 6;
            this.btnDelProd.Text = "Xóa";
            this.btnDelProd.UseVisualStyleBackColor = true;
            this.btnDelProd.Click += new System.EventHandler(this.btnDelProd_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.Location = new System.Drawing.Point(881, 172);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(112, 35);
            this.btnOpenFile.TabIndex = 11;
            this.btnOpenFile.Text = "Tải lên";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // imgProduct
            // 
            this.imgProduct.ErrorImage = null;
            this.imgProduct.Image = ((System.Drawing.Image)(resources.GetObject("imgProduct.Image")));
            this.imgProduct.Location = new System.Drawing.Point(755, 18);
            this.imgProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgProduct.Name = "imgProduct";
            this.imgProduct.Size = new System.Drawing.Size(238, 147);
            this.imgProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgProduct.TabIndex = 17;
            this.imgProduct.TabStop = false;
            // 
            // btnAddProd
            // 
            this.btnAddProd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProd.Location = new System.Drawing.Point(15, 175);
            this.btnAddProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddProd.Name = "btnAddProd";
            this.btnAddProd.Size = new System.Drawing.Size(112, 35);
            this.btnAddProd.TabIndex = 5;
            this.btnAddProd.Text = "Thêm";
            this.btnAddProd.UseVisualStyleBackColor = true;
            this.btnAddProd.Click += new System.EventHandler(this.btnAddProd_Click);
            // 
            // btnEditProd
            // 
            this.btnEditProd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProd.Location = new System.Drawing.Point(259, 175);
            this.btnEditProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditProd.Name = "btnEditProd";
            this.btnEditProd.Size = new System.Drawing.Size(112, 35);
            this.btnEditProd.TabIndex = 7;
            this.btnEditProd.Text = "Sửa";
            this.btnEditProd.UseVisualStyleBackColor = true;
            this.btnEditProd.Click += new System.EventHandler(this.btnEditProd_Click);
            // 
            // btnSearchProd
            // 
            this.btnSearchProd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProd.Location = new System.Drawing.Point(761, 172);
            this.btnSearchProd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchProd.Name = "btnSearchProd";
            this.btnSearchProd.Size = new System.Drawing.Size(112, 35);
            this.btnSearchProd.TabIndex = 10;
            this.btnSearchProd.Text = "Tìm kiếm";
            this.btnSearchProd.UseVisualStyleBackColor = true;
            this.btnSearchProd.Click += new System.EventHandler(this.btnSearchProd_Click);
            // 
            // btnClr
            // 
            this.btnClr.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.Location = new System.Drawing.Point(380, 175);
            this.btnClr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(112, 35);
            this.btnClr.TabIndex = 8;
            this.btnClr.Text = "Hủy";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtProductName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(15, 18);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(382, 51);
            this.panel2.TabIndex = 17;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(153, 11);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(224, 30);
            this.txtProductName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên sản phẩm:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtIamge);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(408, 18);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(219, 51);
            this.panel4.TabIndex = 20;
            // 
            // txtIamge
            // 
            this.txtIamge.Location = new System.Drawing.Point(58, 9);
            this.txtIamge.Name = "txtIamge";
            this.txtIamge.ReadOnly = true;
            this.txtIamge.Size = new System.Drawing.Size(156, 30);
            this.txtIamge.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ảnh:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbProductType);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(15, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 51);
            this.panel1.TabIndex = 18;
            // 
            // cbProductType
            // 
            this.cbProductType.FormattingEnabled = true;
            this.cbProductType.Location = new System.Drawing.Point(153, 9);
            this.cbProductType.Name = "cbProductType";
            this.cbProductType.Size = new System.Drawing.Size(224, 33);
            this.cbProductType.TabIndex = 2;
            this.cbProductType.Text = "---Chọn loại---";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Loại sản phẩm:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtPrice);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(408, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(219, 51);
            this.panel3.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Giá:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgvProducts);
            this.groupBox2.Location = new System.Drawing.Point(10, 244);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1005, 421);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách";
            // 
            // dtgvProducts
            // 
            this.dtgvProducts.ColumnHeadersHeight = 34;
            this.dtgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgvProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.dtgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvProducts.Location = new System.Drawing.Point(4, 24);
            this.dtgvProducts.Name = "dtgvProducts";
            this.dtgvProducts.RowHeadersWidth = 62;
            this.dtgvProducts.RowTemplate.Height = 28;
            this.dtgvProducts.Size = new System.Drawing.Size(997, 392);
            this.dtgvProducts.TabIndex = 0;
            this.dtgvProducts.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvProducts_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã sản phẩm";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên sản phẩm";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Giá tiền";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Đường dẫn ảnh";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 160;
            // 
            // txtPrice
            // 
            this.txtPrice.Increment = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.txtPrice.Location = new System.Drawing.Point(58, 7);
            this.txtPrice.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(156, 30);
            this.txtPrice.TabIndex = 4;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CancelButton = this.btnClr;
            this.ClientSize = new System.Drawing.Size(1028, 679);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fProducts";
            this.Text = "Thông tin sản phẩm";
            this.Load += new System.EventHandler(this.fProducts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgProduct)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtIamge;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnAddProd;
        private System.Windows.Forms.Button btnEditProd;
        private System.Windows.Forms.Button btnSearchProd;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Button btnDelProd;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox imgProduct;
        private System.Windows.Forms.ComboBox cbProductType;
        private System.Windows.Forms.DataGridView dtgvProducts;
        private System.Windows.Forms.TextBox txtSearchId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.NumericUpDown txtPrice;
    }
}