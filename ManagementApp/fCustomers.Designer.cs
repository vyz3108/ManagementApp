namespace QuanLyQuanAo
{
    partial class fCustomers
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
            this.btnSearchCus = new System.Windows.Forms.Button();
            this.dtgvCustomer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.btnEditCus = new System.Windows.Forms.Button();
            this.txtCusAddr = new System.Windows.Forms.TextBox();
            this.txtCusSDT = new System.Windows.Forms.TextBox();
            this.txtCusName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddCus = new System.Windows.Forms.Button();
            this.btnDelCus = new System.Windows.Forms.Button();
            this.btnClr = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchCus
            // 
            this.btnSearchCus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCus.Location = new System.Drawing.Point(732, 26);
            this.btnSearchCus.Name = "btnSearchCus";
            this.btnSearchCus.Size = new System.Drawing.Size(114, 38);
            this.btnSearchCus.TabIndex = 5;
            this.btnSearchCus.Text = "Tìm kiếm";
            this.btnSearchCus.UseVisualStyleBackColor = true;
            this.btnSearchCus.Click += new System.EventHandler(this.btnSearchCus_Click);
            // 
            // dtgvCustomer
            // 
            this.dtgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dtgvCustomer.Location = new System.Drawing.Point(13, 158);
            this.dtgvCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtgvCustomer.Name = "dtgvCustomer";
            this.dtgvCustomer.RowHeadersWidth = 62;
            this.dtgvCustomer.Size = new System.Drawing.Size(883, 488);
            this.dtgvCustomer.TabIndex = 16;
            this.dtgvCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCustomer_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên khách hàng";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Số điện thoại";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(632, 29);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(93, 30);
            this.txtSearchCustomer.TabIndex = 4;
            this.txtSearchCustomer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearchCustomer_KeyPress);
            // 
            // btnEditCus
            // 
            this.btnEditCus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCus.Location = new System.Drawing.Point(660, 106);
            this.btnEditCus.Name = "btnEditCus";
            this.btnEditCus.Size = new System.Drawing.Size(90, 38);
            this.btnEditCus.TabIndex = 8;
            this.btnEditCus.Text = "Sửa";
            this.btnEditCus.UseVisualStyleBackColor = true;
            this.btnEditCus.Click += new System.EventHandler(this.btnEditCus_Click);
            // 
            // txtCusAddr
            // 
            this.txtCusAddr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusAddr.Location = new System.Drawing.Point(188, 108);
            this.txtCusAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusAddr.Name = "txtCusAddr";
            this.txtCusAddr.Size = new System.Drawing.Size(264, 30);
            this.txtCusAddr.TabIndex = 3;
            // 
            // txtCusSDT
            // 
            this.txtCusSDT.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusSDT.Location = new System.Drawing.Point(188, 68);
            this.txtCusSDT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusSDT.Name = "txtCusSDT";
            this.txtCusSDT.Size = new System.Drawing.Size(264, 30);
            this.txtCusSDT.TabIndex = 2;
            // 
            // txtCusName
            // 
            this.txtCusName.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCusName.Location = new System.Drawing.Point(188, 28);
            this.txtCusName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCusName.Name = "txtCusName";
            this.txtCusName.Size = new System.Drawing.Size(264, 30);
            this.txtCusName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 23);
            this.label1.TabIndex = 24;
            this.label1.Text = "Tên khách hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 23);
            this.label3.TabIndex = 26;
            this.label3.Text = "Số điện thoại:";
            // 
            // btnAddCus
            // 
            this.btnAddCus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCus.Location = new System.Drawing.Point(468, 106);
            this.btnAddCus.Name = "btnAddCus";
            this.btnAddCus.Size = new System.Drawing.Size(90, 38);
            this.btnAddCus.TabIndex = 6;
            this.btnAddCus.Text = "Thêm";
            this.btnAddCus.UseVisualStyleBackColor = true;
            this.btnAddCus.Click += new System.EventHandler(this.btnAddCus_Click);
            // 
            // btnDelCus
            // 
            this.btnDelCus.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelCus.Location = new System.Drawing.Point(564, 106);
            this.btnDelCus.Name = "btnDelCus";
            this.btnDelCus.Size = new System.Drawing.Size(90, 38);
            this.btnDelCus.TabIndex = 7;
            this.btnDelCus.Text = "Xóa";
            this.btnDelCus.UseVisualStyleBackColor = true;
            this.btnDelCus.Click += new System.EventHandler(this.btnDelCus_Click);
            // 
            // btnClr
            // 
            this.btnClr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.Location = new System.Drawing.Point(756, 106);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(90, 38);
            this.btnClr.TabIndex = 9;
            this.btnClr.Text = "Hủy";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(482, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 23);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mã khách hàng";
            // 
            // fCustomers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 660);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.btnDelCus);
            this.Controls.Add(this.btnAddCus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCusName);
            this.Controls.Add(this.txtCusSDT);
            this.Controls.Add(this.txtCusAddr);
            this.Controls.Add(this.btnEditCus);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.dtgvCustomer);
            this.Controls.Add(this.btnSearchCus);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "fCustomers";
            this.Text = "Danh sách khách hàng";
            this.Load += new System.EventHandler(this.fCustomers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSearchCus;
        private System.Windows.Forms.DataGridView dtgvCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Button btnEditCus;
        private System.Windows.Forms.TextBox txtCusAddr;
        private System.Windows.Forms.TextBox txtCusSDT;
        private System.Windows.Forms.TextBox txtCusName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddCus;
        private System.Windows.Forms.Button btnDelCus;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}