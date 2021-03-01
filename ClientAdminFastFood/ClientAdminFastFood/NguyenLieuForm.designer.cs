namespace Hotel_SoftWare2
{
    partial class CustomersForm
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
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.TenNguyenLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnX = new FontAwesome.Sharp.IconButton();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.textBoxMaNL = new System.Windows.Forms.TextBox();
            this.textBoxDVT = new System.Windows.Forms.TextBox();
            this.textBoxTenNL = new System.Windows.Forms.TextBox();
            this.labeltennl = new System.Windows.Forms.Label();
            this.labelMaNL = new System.Windows.Forms.Label();
            this.labeldonvitinh = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNguyenLieu,
            this.DonViTinh,
            this.Ma});
            this.dgvCustomers.Location = new System.Drawing.Point(239, 248);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.Size = new System.Drawing.Size(1001, 478);
            this.dgvCustomers.TabIndex = 0;
            this.dgvCustomers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomers_CellClick);
            // 
            // TenNguyenLieu
            // 
            this.TenNguyenLieu.DataPropertyName = "TenNguyenLieu";
            this.TenNguyenLieu.HeaderText = "Tên nguyên liệu";
            this.TenNguyenLieu.MinimumWidth = 6;
            this.TenNguyenLieu.Name = "TenNguyenLieu";
            this.TenNguyenLieu.ReadOnly = true;
            this.TenNguyenLieu.Width = 125;
            // 
            // DonViTinh
            // 
            this.DonViTinh.DataPropertyName = "DonViTinh";
            this.DonViTinh.HeaderText = "Đơn vị tính";
            this.DonViTinh.MinimumWidth = 6;
            this.DonViTinh.Name = "DonViTinh";
            this.DonViTinh.ReadOnly = true;
            this.DonViTinh.Width = 125;
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Mã";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            this.Ma.Visible = false;
            this.Ma.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnThem.IconColor = System.Drawing.Color.White;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnThem.IconSize = 30;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(32, 332);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(159, 49);
            this.btnThem.TabIndex = 1;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.PenAlt;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSua.IconSize = 30;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(32, 402);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(159, 49);
            this.btnSua.TabIndex = 2;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.UserTimes;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnXoa.IconSize = 30;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(32, 478);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(159, 49);
            this.btnXoa.TabIndex = 3;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimKiem.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTimKiem.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnTimKiem.IconColor = System.Drawing.Color.White;
            this.btnTimKiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTimKiem.IconSize = 30;
            this.btnTimKiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.Location = new System.Drawing.Point(1018, 31);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(159, 49);
            this.btnTimKiem.TabIndex = 4;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnX
            // 
            this.btnX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.btnX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnX.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnX.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnX.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.btnX.IconColor = System.Drawing.Color.White;
            this.btnX.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnX.IconSize = 30;
            this.btnX.Location = new System.Drawing.Point(32, 644);
            this.btnX.Margin = new System.Windows.Forms.Padding(4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(159, 52);
            this.btnX.TabIndex = 5;
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // iconButtonSave
            // 
            this.iconButtonSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.iconButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButtonSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButtonSave.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButtonSave.IconColor = System.Drawing.Color.White;
            this.iconButtonSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonSave.IconSize = 30;
            this.iconButtonSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.Location = new System.Drawing.Point(707, 125);
            this.iconButtonSave.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(159, 49);
            this.iconButtonSave.TabIndex = 20;
            this.iconButtonSave.Text = "Lưu";
            this.iconButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // textBoxMaNL
            // 
            this.textBoxMaNL.Location = new System.Drawing.Point(253, 44);
            this.textBoxMaNL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaNL.Multiline = true;
            this.textBoxMaNL.Name = "textBoxMaNL";
            this.textBoxMaNL.Size = new System.Drawing.Size(265, 29);
            this.textBoxMaNL.TabIndex = 40;
            // 
            // textBoxDVT
            // 
            this.textBoxDVT.Location = new System.Drawing.Point(253, 145);
            this.textBoxDVT.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDVT.Multiline = true;
            this.textBoxDVT.Name = "textBoxDVT";
            this.textBoxDVT.Size = new System.Drawing.Size(265, 29);
            this.textBoxDVT.TabIndex = 41;
            // 
            // textBoxTenNL
            // 
            this.textBoxTenNL.Location = new System.Drawing.Point(253, 96);
            this.textBoxTenNL.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenNL.Multiline = true;
            this.textBoxTenNL.Name = "textBoxTenNL";
            this.textBoxTenNL.Size = new System.Drawing.Size(265, 29);
            this.textBoxTenNL.TabIndex = 42;
            // 
            // labeltennl
            // 
            this.labeltennl.AutoSize = true;
            this.labeltennl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltennl.ForeColor = System.Drawing.Color.Transparent;
            this.labeltennl.Location = new System.Drawing.Point(32, 90);
            this.labeltennl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltennl.Name = "labeltennl";
            this.labeltennl.Size = new System.Drawing.Size(197, 29);
            this.labeltennl.TabIndex = 39;
            this.labeltennl.Text = "Tên Nguyên Liệu";
            // 
            // labelMaNL
            // 
            this.labelMaNL.AutoSize = true;
            this.labelMaNL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNL.ForeColor = System.Drawing.Color.Transparent;
            this.labelMaNL.Location = new System.Drawing.Point(32, 44);
            this.labelMaNL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaNL.Name = "labelMaNL";
            this.labelMaNL.Size = new System.Drawing.Size(187, 29);
            this.labelMaNL.TabIndex = 37;
            this.labelMaNL.Text = "Mã Nguyên Liệu";
            // 
            // labeldonvitinh
            // 
            this.labeldonvitinh.AutoSize = true;
            this.labeldonvitinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldonvitinh.ForeColor = System.Drawing.Color.Transparent;
            this.labeldonvitinh.Location = new System.Drawing.Point(32, 145);
            this.labeldonvitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldonvitinh.Name = "labeldonvitinh";
            this.labeldonvitinh.Size = new System.Drawing.Size(138, 29);
            this.labeldonvitinh.TabIndex = 38;
            this.labeldonvitinh.Text = "Đơn Vị Tính";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(707, 45);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTimKiem.Multiline = true;
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(265, 29);
            this.textBoxTimKiem.TabIndex = 43;
            // 
            // CustomersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1253, 738);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.textBoxMaNL);
            this.Controls.Add(this.textBoxDVT);
            this.Controls.Add(this.textBoxTenNL);
            this.Controls.Add(this.labeltennl);
            this.Controls.Add(this.labelMaNL);
            this.Controls.Add(this.labeldonvitinh);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomersForm";
            this.Text = "CustomersForm";
            this.Load += new System.EventHandler(this.CustomersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnX;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private System.Windows.Forms.TextBox textBoxMaNL;
        private System.Windows.Forms.TextBox textBoxDVT;
        private System.Windows.Forms.TextBox textBoxTenNL;
        private System.Windows.Forms.Label labeltennl;
        private System.Windows.Forms.Label labelMaNL;
        private System.Windows.Forms.Label labeldonvitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNguyenLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.TextBox textBoxTimKiem;
    }
}