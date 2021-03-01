
namespace ClientAdminFastFood
{
    partial class SanPhamForm
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
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.textBoxMaSP = new System.Windows.Forms.TextBox();
            this.textBoxDG = new System.Windows.Forms.TextBox();
            this.textBoxTenSP = new System.Windows.Forms.TextBox();
            this.labeltensp = new System.Windows.Forms.Label();
            this.labeldongia = new System.Windows.Forms.Label();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.btnX = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.textBoxmota = new System.Windows.Forms.TextBox();
            this.labelmota = new System.Windows.Forms.Label();
            this.labeltendanhmuc = new System.Windows.Forms.Label();
            this.textBoxMaDM = new System.Windows.Forms.TextBox();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(715, 156);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTimKiem.Multiline = true;
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(265, 29);
            this.textBoxTimKiem.TabIndex = 57;
            // 
            // textBoxMaSP
            // 
            this.textBoxMaSP.Location = new System.Drawing.Point(594, 88);
            this.textBoxMaSP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaSP.Multiline = true;
            this.textBoxMaSP.Name = "textBoxMaSP";
            this.textBoxMaSP.Size = new System.Drawing.Size(31, 29);
            this.textBoxMaSP.TabIndex = 54;
            // 
            // textBoxDG
            // 
            this.textBoxDG.Location = new System.Drawing.Point(263, 84);
            this.textBoxDG.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDG.Multiline = true;
            this.textBoxDG.Name = "textBoxDG";
            this.textBoxDG.Size = new System.Drawing.Size(265, 29);
            this.textBoxDG.TabIndex = 55;
            // 
            // textBoxTenSP
            // 
            this.textBoxTenSP.Location = new System.Drawing.Point(263, 35);
            this.textBoxTenSP.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenSP.Multiline = true;
            this.textBoxTenSP.Name = "textBoxTenSP";
            this.textBoxTenSP.Size = new System.Drawing.Size(265, 29);
            this.textBoxTenSP.TabIndex = 56;
            // 
            // labeltensp
            // 
            this.labeltensp.AutoSize = true;
            this.labeltensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltensp.ForeColor = System.Drawing.Color.Transparent;
            this.labeltensp.Location = new System.Drawing.Point(42, 29);
            this.labeltensp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltensp.Name = "labeltensp";
            this.labeltensp.Size = new System.Drawing.Size(172, 29);
            this.labeltensp.TabIndex = 53;
            this.labeltensp.Text = "Tên Sản Phẩm";
            // 
            // labeldongia
            // 
            this.labeldongia.AutoSize = true;
            this.labeldongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldongia.ForeColor = System.Drawing.Color.Transparent;
            this.labeldongia.Location = new System.Drawing.Point(42, 84);
            this.labeldongia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldongia.Name = "labeldongia";
            this.labeldongia.Size = new System.Drawing.Size(100, 29);
            this.labeldongia.TabIndex = 52;
            this.labeldongia.Text = "Đơn Giá";
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
            this.iconButtonSave.Location = new System.Drawing.Point(537, 182);
            this.iconButtonSave.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(159, 49);
            this.iconButtonSave.TabIndex = 50;
            this.iconButtonSave.Text = "Lưu";
            this.iconButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
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
            this.btnX.Location = new System.Drawing.Point(22, 635);
            this.btnX.Margin = new System.Windows.Forms.Padding(4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(159, 52);
            this.btnX.TabIndex = 49;
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
            this.btnTimKiem.Location = new System.Drawing.Point(1031, 142);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(159, 49);
            this.btnTimKiem.TabIndex = 48;
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
            this.btnXoa.Location = new System.Drawing.Point(22, 469);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(159, 49);
            this.btnXoa.TabIndex = 47;
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
            this.btnSua.Location = new System.Drawing.Point(22, 393);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(159, 49);
            this.btnSua.TabIndex = 46;
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
            this.btnThem.Location = new System.Drawing.Point(22, 323);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(159, 49);
            this.btnThem.TabIndex = 45;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.AllowUserToAddRows = false;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.DonGia,
            this.MoTa,
            this.Column2,
            this.Column1});
            this.dgvSanPham.Location = new System.Drawing.Point(229, 239);
            this.dgvSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.Size = new System.Drawing.Size(1001, 478);
            this.dgvSanPham.TabIndex = 44;
            this.dgvSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSanPham_CellClick);
            // 
            // textBoxmota
            // 
            this.textBoxmota.Location = new System.Drawing.Point(715, 35);
            this.textBoxmota.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxmota.Multiline = true;
            this.textBoxmota.Name = "textBoxmota";
            this.textBoxmota.Size = new System.Drawing.Size(441, 78);
            this.textBoxmota.TabIndex = 59;
            // 
            // labelmota
            // 
            this.labelmota.AutoSize = true;
            this.labelmota.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmota.ForeColor = System.Drawing.Color.Transparent;
            this.labelmota.Location = new System.Drawing.Point(589, 35);
            this.labelmota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelmota.Name = "labelmota";
            this.labelmota.Size = new System.Drawing.Size(82, 29);
            this.labelmota.TabIndex = 58;
            this.labelmota.Text = "Mô Tả";
            // 
            // labeltendanhmuc
            // 
            this.labeltendanhmuc.AutoSize = true;
            this.labeltendanhmuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltendanhmuc.ForeColor = System.Drawing.Color.Transparent;
            this.labeltendanhmuc.Location = new System.Drawing.Point(42, 142);
            this.labeltendanhmuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltendanhmuc.Name = "labeltendanhmuc";
            this.labeltendanhmuc.Size = new System.Drawing.Size(159, 29);
            this.labeltendanhmuc.TabIndex = 61;
            this.labeltendanhmuc.Text = "Mã Danh Mục";
            // 
            // textBoxMaDM
            // 
            this.textBoxMaDM.Location = new System.Drawing.Point(263, 142);
            this.textBoxMaDM.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaDM.Multiline = true;
            this.textBoxMaDM.Name = "textBoxMaDM";
            this.textBoxMaDM.Size = new System.Drawing.Size(265, 29);
            this.textBoxMaDM.TabIndex = 62;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên Sản Phẩm";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            this.DonGia.HeaderText = "Đơn Giá";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 125;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô Tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenDanhMucSanPham";
            this.Column2.HeaderText = "Tên Danh Mục Sản Phẩm";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ma";
            this.Column1.HeaderText = "Ma";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // SanPhamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1253, 738);
            this.Controls.Add(this.textBoxMaDM);
            this.Controls.Add(this.labeltendanhmuc);
            this.Controls.Add(this.textBoxmota);
            this.Controls.Add(this.labelmota);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.textBoxMaSP);
            this.Controls.Add(this.textBoxDG);
            this.Controls.Add(this.textBoxTenSP);
            this.Controls.Add(this.labeltensp);
            this.Controls.Add(this.labeldongia);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvSanPham);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SanPhamForm";
            this.Text = "SanPhamForm";
            this.Load += new System.EventHandler(this.SanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.TextBox textBoxMaSP;
        private System.Windows.Forms.TextBox textBoxDG;
        private System.Windows.Forms.TextBox textBoxTenSP;
        private System.Windows.Forms.Label labeltensp;
        private System.Windows.Forms.Label labeldongia;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton btnX;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.TextBox textBoxmota;
        private System.Windows.Forms.Label labelmota;
        private System.Windows.Forms.Label labeltendanhmuc;
        private System.Windows.Forms.TextBox textBoxMaDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}