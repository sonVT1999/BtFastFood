
namespace ClientAdminFastFood
{
    partial class NguoiDungForm
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
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.textBoxMaND = new System.Windows.Forms.TextBox();
            this.textBoxViTri = new System.Windows.Forms.TextBox();
            this.textBoxTenND = new System.Windows.Forms.TextBox();
            this.labeltennguoidung = new System.Windows.Forms.Label();
            this.labelVitri = new System.Windows.Forms.Label();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.btnX = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.dgvNguoiDung = new System.Windows.Forms.DataGridView();
            this.textBoxNgaySinh = new System.Windows.Forms.TextBox();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).BeginInit();
            this.SuspendLayout();
            // 
            // labelNgaySinh
            // 
            this.labelNgaySinh.AutoSize = true;
            this.labelNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgaySinh.ForeColor = System.Drawing.Color.Transparent;
            this.labelNgaySinh.Location = new System.Drawing.Point(760, 20);
            this.labelNgaySinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNgaySinh.Name = "labelNgaySinh";
            this.labelNgaySinh.Size = new System.Drawing.Size(123, 29);
            this.labelNgaySinh.TabIndex = 78;
            this.labelNgaySinh.Text = "Ngày Sinh";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(765, 178);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTimKiem.Multiline = true;
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(265, 29);
            this.textBoxTimKiem.TabIndex = 74;
            // 
            // textBoxMaND
            // 
            this.textBoxMaND.Location = new System.Drawing.Point(1199, 127);
            this.textBoxMaND.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaND.Multiline = true;
            this.textBoxMaND.Name = "textBoxMaND";
            this.textBoxMaND.Size = new System.Drawing.Size(31, 29);
            this.textBoxMaND.TabIndex = 71;
            // 
            // textBoxViTri
            // 
            this.textBoxViTri.Location = new System.Drawing.Point(422, 75);
            this.textBoxViTri.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxViTri.Multiline = true;
            this.textBoxViTri.Name = "textBoxViTri";
            this.textBoxViTri.Size = new System.Drawing.Size(265, 29);
            this.textBoxViTri.TabIndex = 72;
            // 
            // textBoxTenND
            // 
            this.textBoxTenND.Location = new System.Drawing.Point(422, 27);
            this.textBoxTenND.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTenND.Multiline = true;
            this.textBoxTenND.Name = "textBoxTenND";
            this.textBoxTenND.Size = new System.Drawing.Size(265, 29);
            this.textBoxTenND.TabIndex = 73;
            // 
            // labeltennguoidung
            // 
            this.labeltennguoidung.AutoSize = true;
            this.labeltennguoidung.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltennguoidung.ForeColor = System.Drawing.Color.Transparent;
            this.labeltennguoidung.Location = new System.Drawing.Point(198, 27);
            this.labeltennguoidung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labeltennguoidung.Name = "labeltennguoidung";
            this.labeltennguoidung.Size = new System.Drawing.Size(190, 29);
            this.labeltennguoidung.TabIndex = 70;
            this.labeltennguoidung.Text = "Tên Người Dùng";
            // 
            // labelVitri
            // 
            this.labelVitri.AutoSize = true;
            this.labelVitri.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVitri.ForeColor = System.Drawing.Color.Transparent;
            this.labelVitri.Location = new System.Drawing.Point(198, 75);
            this.labelVitri.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVitri.Name = "labelVitri";
            this.labelVitri.Size = new System.Drawing.Size(70, 29);
            this.labelVitri.TabIndex = 69;
            this.labelVitri.Text = "Vị Trí";
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
            this.iconButtonSave.Location = new System.Drawing.Point(467, 164);
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
            this.btnX.Location = new System.Drawing.Point(22, 631);
            this.btnX.Margin = new System.Windows.Forms.Padding(4);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(159, 52);
            this.btnX.TabIndex = 67;
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
            this.btnTimKiem.Location = new System.Drawing.Point(1071, 164);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(159, 49);
            this.btnTimKiem.TabIndex = 66;
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
            this.btnXoa.Location = new System.Drawing.Point(22, 465);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(159, 49);
            this.btnXoa.TabIndex = 65;
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
            this.btnSua.Location = new System.Drawing.Point(22, 389);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(159, 49);
            this.btnSua.TabIndex = 64;
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
            this.btnThem.Location = new System.Drawing.Point(22, 319);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(159, 49);
            this.btnThem.TabIndex = 63;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvNguoiDung
            // 
            this.dgvNguoiDung.AllowUserToAddRows = false;
            this.dgvNguoiDung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNguoiDung.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.ViTri,
            this.MoTa,
            this.Ma});
            this.dgvNguoiDung.Location = new System.Drawing.Point(229, 235);
            this.dgvNguoiDung.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNguoiDung.Name = "dgvNguoiDung";
            this.dgvNguoiDung.RowHeadersWidth = 51;
            this.dgvNguoiDung.Size = new System.Drawing.Size(1001, 478);
            this.dgvNguoiDung.TabIndex = 62;
            this.dgvNguoiDung.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNguoiDung_CellClick);
            // 
            // textBoxNgaySinh
            // 
            this.textBoxNgaySinh.Location = new System.Drawing.Point(907, 20);
            this.textBoxNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNgaySinh.Multiline = true;
            this.textBoxNgaySinh.Name = "textBoxNgaySinh";
            this.textBoxNgaySinh.Size = new System.Drawing.Size(265, 29);
            this.textBoxNgaySinh.TabIndex = 84;
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "Ten";
            this.Ten.HeaderText = "Tên Người Dùng";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 125;
            // 
            // ViTri
            // 
            this.ViTri.DataPropertyName = "ViTri";
            this.ViTri.HeaderText = "Vị Trí";
            this.ViTri.MinimumWidth = 6;
            this.ViTri.Name = "ViTri";
            this.ViTri.ReadOnly = true;
            this.ViTri.Width = 125;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "NgaySinh";
            this.MoTa.HeaderText = "Ngày Sinh";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Width = 125;
            // 
            // Ma
            // 
            this.Ma.DataPropertyName = "Ma";
            this.Ma.HeaderText = "Ma";
            this.Ma.MinimumWidth = 6;
            this.Ma.Name = "Ma";
            this.Ma.ReadOnly = true;
            this.Ma.Visible = false;
            this.Ma.Width = 125;
            // 
            // NguoiDungForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1253, 738);
            this.Controls.Add(this.textBoxNgaySinh);
            this.Controls.Add(this.labelNgaySinh);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.textBoxMaND);
            this.Controls.Add(this.textBoxViTri);
            this.Controls.Add(this.textBoxTenND);
            this.Controls.Add(this.labeltennguoidung);
            this.Controls.Add(this.labelVitri);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvNguoiDung);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NguoiDungForm";
            this.Text = "NguoiDungForm";
            this.Load += new System.EventHandler(this.NguoiDung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNguoiDung)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.TextBox textBoxMaND;
        private System.Windows.Forms.TextBox textBoxViTri;
        private System.Windows.Forms.TextBox textBoxTenND;
        private System.Windows.Forms.Label labeltennguoidung;
        private System.Windows.Forms.Label labelVitri;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton btnX;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.DataGridView dgvNguoiDung;
        private System.Windows.Forms.TextBox textBoxNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn ViTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ma;
    }
}