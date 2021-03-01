
namespace ClientAdminFastFood
{
    partial class DanhMucSanPhamForm
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
            this.textBoxMaDM = new System.Windows.Forms.TextBox();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.textBoxTenDM = new System.Windows.Forms.TextBox();
            this.labelTendanhmuc = new System.Windows.Forms.Label();
            this.btnX = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.dgvDanhMucSanPham = new System.Windows.Forms.DataGridView();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMaDM
            // 
            this.textBoxMaDM.Location = new System.Drawing.Point(536, 57);
            this.textBoxMaDM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaDM.Multiline = true;
            this.textBoxMaDM.Name = "textBoxMaDM";
            this.textBoxMaDM.Size = new System.Drawing.Size(46, 29);
            this.textBoxMaDM.TabIndex = 70;
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(673, 57);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTimKiem.Multiline = true;
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(265, 29);
            this.textBoxTimKiem.TabIndex = 69;
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
            this.iconButtonSave.Location = new System.Drawing.Point(552, 139);
            this.iconButtonSave.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(159, 49);
            this.iconButtonSave.TabIndex = 68;
            this.iconButtonSave.Text = "Lưu";
            this.iconButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // textBoxTenDM
            // 
            this.textBoxTenDM.Location = new System.Drawing.Point(243, 57);
            this.textBoxTenDM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenDM.Multiline = true;
            this.textBoxTenDM.Name = "textBoxTenDM";
            this.textBoxTenDM.Size = new System.Drawing.Size(265, 29);
            this.textBoxTenDM.TabIndex = 65;
            // 
            // labelTendanhmuc
            // 
            this.labelTendanhmuc.AutoSize = true;
            this.labelTendanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTendanhmuc.ForeColor = System.Drawing.Color.Transparent;
            this.labelTendanhmuc.Location = new System.Drawing.Point(30, 57);
            this.labelTendanhmuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTendanhmuc.Name = "labelTendanhmuc";
            this.labelTendanhmuc.Size = new System.Drawing.Size(166, 29);
            this.labelTendanhmuc.TabIndex = 62;
            this.labelTendanhmuc.Text = "Tên danh mục";
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
            this.btnX.Location = new System.Drawing.Point(25, 645);
            this.btnX.Margin = new System.Windows.Forms.Padding(4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(159, 52);
            this.btnX.TabIndex = 61;
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(978, 50);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(159, 49);
            this.btnTimKiem.TabIndex = 60;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimKiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
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
            this.btnXoa.Location = new System.Drawing.Point(25, 479);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(159, 49);
            this.btnXoa.TabIndex = 59;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(25, 403);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(159, 49);
            this.btnSua.TabIndex = 58;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
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
            this.btnThem.Location = new System.Drawing.Point(25, 333);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(159, 49);
            this.btnThem.TabIndex = 57;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvDanhMucSanPham
            // 
            this.dgvDanhMucSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhMucSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma,
            this.Ten});
            this.dgvDanhMucSanPham.Location = new System.Drawing.Point(220, 235);
            this.dgvDanhMucSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDanhMucSanPham.Name = "dgvDanhMucSanPham";
            this.dgvDanhMucSanPham.RowHeadersWidth = 51;
            this.dgvDanhMucSanPham.Size = new System.Drawing.Size(1013, 492);
            this.dgvDanhMucSanPham.TabIndex = 56;
            this.dgvDanhMucSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhMucSanPham_CellClick);
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Mã danh mục sản phẩm";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.Width = 125;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên danh mục sản phẩm";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.Width = 125;
            // 
            // DanhMucSanPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1253, 738);
            this.Controls.Add(this.textBoxMaDM);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.textBoxTenDM);
            this.Controls.Add(this.labelTendanhmuc);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvDanhMucSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DanhMucSanPhamForm";
            this.Text = "DanhMucSanPhamForm";
            this.Load += new System.EventHandler(this.DanhMucSanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMucSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxMaDM;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private System.Windows.Forms.TextBox textBoxTenDM;
        private System.Windows.Forms.Label labelTendanhmuc;
        private FontAwesome.Sharp.IconButton btnX;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.DataGridView dgvDanhMucSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
    }
}