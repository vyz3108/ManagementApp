namespace QuanLyQuanAo
{
    partial class fAdmin
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
            this.btnAddAd = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDisplayName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEditAd = new System.Windows.Forms.Button();
            this.dtgvAccount = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClr = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nb_TypeAccount = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDelAd = new System.Windows.Forms.Button();
            this.btnSearchAcc = new System.Windows.Forms.Button();
            this.btnResetPassword = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_TypeAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddAd
            // 
            this.btnAddAd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAd.Location = new System.Drawing.Point(501, 148);
            this.btnAddAd.Name = "btnAddAd";
            this.btnAddAd.Size = new System.Drawing.Size(120, 45);
            this.btnAddAd.TabIndex = 5;
            this.btnAddAd.Text = "Thêm";
            this.btnAddAd.UseVisualStyleBackColor = true;
            this.btnAddAd.Click += new System.EventHandler(this.btnAddAd_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDisplayName);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(482, 48);
            this.panel1.TabIndex = 10;
            // 
            // txtDisplayName
            // 
            this.txtDisplayName.Location = new System.Drawing.Point(160, 10);
            this.txtDisplayName.Name = "txtDisplayName";
            this.txtDisplayName.Size = new System.Drawing.Size(310, 30);
            this.txtDisplayName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên hiển thị:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtUserName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(12, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(482, 48);
            this.panel2.TabIndex = 9;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(160, 10);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(310, 30);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập:";
            // 
            // btnEditAd
            // 
            this.btnEditAd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAd.Location = new System.Drawing.Point(628, 148);
            this.btnEditAd.Name = "btnEditAd";
            this.btnEditAd.Size = new System.Drawing.Size(120, 45);
            this.btnEditAd.TabIndex = 6;
            this.btnEditAd.Text = "Sửa";
            this.btnEditAd.UseVisualStyleBackColor = true;
            this.btnEditAd.Click += new System.EventHandler(this.btnEditAd_Click);
            // 
            // dtgvAccount
            // 
            this.dtgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgvAccount.Location = new System.Drawing.Point(12, 204);
            this.dtgvAccount.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvAccount.Name = "dtgvAccount";
            this.dtgvAccount.RowHeadersWidth = 62;
            this.dtgvAccount.Size = new System.Drawing.Size(1001, 420);
            this.dtgvAccount.TabIndex = 18;
            this.dtgvAccount.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dtgvAccount_RowHeaderMouseClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên đăng nhập";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên hiển thị";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 300;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Loại tài khoản";
            this.Column3.MaxInputLength = 1;
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // btnClr
            // 
            this.btnClr.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClr.Location = new System.Drawing.Point(628, 42);
            this.btnClr.Name = "btnClr";
            this.btnClr.Size = new System.Drawing.Size(120, 45);
            this.btnClr.TabIndex = 8;
            this.btnClr.Text = "Hủy";
            this.btnClr.UseVisualStyleBackColor = true;
            this.btnClr.Click += new System.EventHandler(this.btnClr_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nb_TypeAccount);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel3.Location = new System.Drawing.Point(12, 148);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(482, 48);
            this.panel3.TabIndex = 20;
            // 
            // nb_TypeAccount
            // 
            this.nb_TypeAccount.Location = new System.Drawing.Point(160, 9);
            this.nb_TypeAccount.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nb_TypeAccount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nb_TypeAccount.Name = "nb_TypeAccount";
            this.nb_TypeAccount.Size = new System.Drawing.Size(67, 30);
            this.nb_TypeAccount.TabIndex = 3;
            this.nb_TypeAccount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Loại:";
            // 
            // btnDelAd
            // 
            this.btnDelAd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAd.Location = new System.Drawing.Point(754, 42);
            this.btnDelAd.Name = "btnDelAd";
            this.btnDelAd.Size = new System.Drawing.Size(120, 45);
            this.btnDelAd.TabIndex = 7;
            this.btnDelAd.Text = "Xóa";
            this.btnDelAd.UseVisualStyleBackColor = true;
            this.btnDelAd.Click += new System.EventHandler(this.btnDelAd_Click);
            // 
            // btnSearchAcc
            // 
            this.btnSearchAcc.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAcc.Location = new System.Drawing.Point(501, 43);
            this.btnSearchAcc.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchAcc.Name = "btnSearchAcc";
            this.btnSearchAcc.Size = new System.Drawing.Size(120, 45);
            this.btnSearchAcc.TabIndex = 4;
            this.btnSearchAcc.Text = "Tìm kiếm";
            this.btnSearchAcc.UseVisualStyleBackColor = true;
            this.btnSearchAcc.Click += new System.EventHandler(this.btnSearchAcc_Click);
            // 
            // btnResetPassword
            // 
            this.btnResetPassword.Font = new System.Drawing.Font("Arial", 9.75F);
            this.btnResetPassword.Location = new System.Drawing.Point(755, 148);
            this.btnResetPassword.Name = "btnResetPassword";
            this.btnResetPassword.Size = new System.Drawing.Size(174, 45);
            this.btnResetPassword.TabIndex = 9;
            this.btnResetPassword.Text = "Đặt lại mật khẩu";
            this.btnResetPassword.UseVisualStyleBackColor = true;
            this.btnResetPassword.Click += new System.EventHandler(this.btnResetPassword_Click);
            // 
            // fAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1026, 676);
            this.Controls.Add(this.btnResetPassword);
            this.Controls.Add(this.btnSearchAcc);
            this.Controls.Add(this.btnDelAd);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnClr);
            this.Controls.Add(this.dtgvAccount);
            this.Controls.Add(this.btnEditAd);
            this.Controls.Add(this.btnAddAd);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "fAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý tài khoản";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvAccount)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nb_TypeAccount)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddAd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEditAd;
        private System.Windows.Forms.DataGridView dtgvAccount;
        private System.Windows.Forms.Button btnClr;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDelAd;
        private System.Windows.Forms.Button btnSearchAcc;
        private System.Windows.Forms.Button btnResetPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.NumericUpDown nb_TypeAccount;
    }
}