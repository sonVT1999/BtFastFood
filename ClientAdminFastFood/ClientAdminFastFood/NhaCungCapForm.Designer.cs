
namespace ClientAdminFastFood
{
    partial class NhaCungCapForm
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
            this.textBoxMaNCC = new System.Windows.Forms.TextBox();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.textBoxTenNCC = new System.Windows.Forms.TextBox();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.textBoxDiaDiem = new System.Windows.Forms.TextBox();
            this.labeldiadiem = new System.Windows.Forms.Label();
            this.labelTenNCC = new System.Windows.Forms.Label();
            this.labelSDT = new System.Windows.Forms.Label();
            this.btnX = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.dgvNCC = new System.Windows.Forms.DataGridView();
            this.ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diadiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxMaNCC
            // 
            this.textBoxMaNCC.Location = new System.Drawing.Point(531, 15);
            this.textBoxMaNCC.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaNCC.Multiline = true;
            this.textBoxMaNCC.Name = "textBoxMaNCC";
            this.textBoxMaNCC.Size = new System.Drawing.Size(46, 29);
            this.textBoxMaNCC.TabIndex = 55;
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(758, 52);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTimKiem.Multiline = true;
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(265, 29);
            this.textBoxTimKiem.TabIndex = 54;
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
            this.iconButtonSave.Location = new System.Drawing.Point(696, 141);
            this.iconButtonSave.Margin = new System.Windows.Forms.Padding(4);
            this.iconButtonSave.Name = "iconButtonSave";
            this.iconButtonSave.Size = new System.Drawing.Size(159, 49);
            this.iconButtonSave.TabIndex = 53;
            this.iconButtonSave.Text = "Lưu";
            this.iconButtonSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonSave.UseVisualStyleBackColor = false;
            this.iconButtonSave.Click += new System.EventHandler(this.iconButtonSave_Click);
            // 
            // textBoxTenNCC
            // 
            this.textBoxTenNCC.Location = new System.Drawing.Point(241, 12);
            this.textBoxTenNCC.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenNCC.Multiline = true;
            this.textBoxTenNCC.Name = "textBoxTenNCC";
            this.textBoxTenNCC.Size = new System.Drawing.Size(265, 29);
            this.textBoxTenNCC.TabIndex = 50;
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(241, 113);
            this.textBoxSDT.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSDT.Multiline = true;
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(265, 29);
            this.textBoxSDT.TabIndex = 51;
            // 
            // textBoxDiaDiem
            // 
            this.textBoxDiaDiem.Location = new System.Drawing.Point(241, 64);
            this.textBoxDiaDiem.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDiaDiem.Multiline = true;
            this.textBoxDiaDiem.Name = "textBoxDiaDiem";
            this.textBoxDiaDiem.Size = new System.Drawing.Size(265, 29);
            this.textBoxDiaDiem.TabIndex = 52;
            // 
            // labeldiadiem
            // 
            this.labeldiadiem.AutoSize = true;
            this.labeldiadiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldiadiem.ForeColor = System.Drawing.Color.Transparent;
            this.labeldiadiem.Location = new System.Drawing.Point(20, 58);
            this.labeldiadiem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeldiadiem.Name = "labeldiadiem";
            this.labeldiadiem.Size = new System.Drawing.Size(112, 29);
            this.labeldiadiem.TabIndex = 49;
            this.labeldiadiem.Text = "Địa Điểm";
            // 
            // labelTenNCC
            // 
            this.labelTenNCC.AutoSize = true;
            this.labelTenNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNCC.ForeColor = System.Drawing.Color.Transparent;
            this.labelTenNCC.Location = new System.Drawing.Point(20, 12);
            this.labelTenNCC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTenNCC.Name = "labelTenNCC";
            this.labelTenNCC.Size = new System.Drawing.Size(219, 29);
            this.labelTenNCC.TabIndex = 47;
            this.labelTenNCC.Text = "Tên Nhà Cung Cấp";
            // 
            // labelSDT
            // 
            this.labelSDT.AutoSize = true;
            this.labelSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSDT.ForeColor = System.Drawing.Color.Transparent;
            this.labelSDT.Location = new System.Drawing.Point(20, 113);
            this.labelSDT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Size = new System.Drawing.Size(154, 29);
            this.labelSDT.TabIndex = 48;
            this.labelSDT.Text = "Số điện thoại";
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
            this.btnX.TabIndex = 46;
            this.btnX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnX.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnX.UseVisualStyleBackColor = false;
            this.btnX.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(1046, 38);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(159, 49);
            this.btnTimKiem.TabIndex = 45;
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
            this.btnXoa.TabIndex = 44;
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
            this.btnSua.TabIndex = 43;
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
            this.btnThem.TabIndex = 42;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNCC
            // 
            this.dgvNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ten,
            this.Column1,
            this.diadiem,
            this.sdt});
            this.dgvNCC.Location = new System.Drawing.Point(220, 235);
            this.dgvNCC.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNCC.Name = "dgvNCC";
            this.dgvNCC.RowHeadersWidth = 51;
            this.dgvNCC.Size = new System.Drawing.Size(1013, 492);
            this.dgvNCC.TabIndex = 41;
            this.dgvNCC.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNhaCungCap_CellClick);
            // 
            // ten
            // 
            this.ten.DataPropertyName = "Ten";
            this.ten.HeaderText = "Tên nhà cung cấp";
            this.ten.MinimumWidth = 6;
            this.ten.Name = "ten";
            this.ten.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ma";
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // diadiem
            // 
            this.diadiem.DataPropertyName = "DiaDiem";
            this.diadiem.HeaderText = "Địa điểm";
            this.diadiem.MinimumWidth = 6;
            this.diadiem.Name = "diadiem";
            this.diadiem.Width = 125;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "SoDienThoai";
            this.sdt.HeaderText = "Số điện thoại";
            this.sdt.MinimumWidth = 6;
            this.sdt.Name = "sdt";
            this.sdt.Width = 125;
            // 
            // NhaCungCapForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(33)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(1253, 738);
            this.Controls.Add(this.textBoxMaNCC);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.textBoxTenNCC);
            this.Controls.Add(this.textBoxSDT);
            this.Controls.Add(this.textBoxDiaDiem);
            this.Controls.Add(this.labeldiadiem);
            this.Controls.Add(this.labelTenNCC);
            this.Controls.Add(this.labelSDT);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNCC);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NhaCungCapForm";
            this.Text = "NhaCungCapForm";
            this.Load += new System.EventHandler(this.NhaCungCap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMaNCC;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private System.Windows.Forms.TextBox textBoxTenNCC;
        private System.Windows.Forms.TextBox textBoxSDT;
        private System.Windows.Forms.TextBox textBoxDiaDiem;
        private System.Windows.Forms.Label labeldiadiem;
        private System.Windows.Forms.Label labelTenNCC;
        private System.Windows.Forms.Label labelSDT;
        private FontAwesome.Sharp.IconButton btnX;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.DataGridView dgvNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn diadiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
    }
}