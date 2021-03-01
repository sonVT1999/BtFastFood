
namespace ClientAdminFastFood
{
    partial class AccountForm
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
            this.labelMaND = new System.Windows.Forms.Label();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.labelMaKH = new System.Windows.Forms.Label();
            this.textBoxTimKiem = new System.Windows.Forms.TextBox();
            this.textBoxMaAcc = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.iconButtonSave = new FontAwesome.Sharp.IconButton();
            this.btnX = new FontAwesome.Sharp.IconButton();
            this.btnTimKiem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.textBoxMaND = new System.Windows.Forms.TextBox();
            this.textBoxMaNND = new System.Windows.Forms.TextBox();
            this.labelMaNND = new System.Windows.Forms.Label();
            this.Ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaND
            // 
            this.labelMaND.AutoSize = true;
            this.labelMaND.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaND.ForeColor = System.Drawing.Color.Transparent;
            this.labelMaND.Location = new System.Drawing.Point(620, 24);
            this.labelMaND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaND.Name = "labelMaND";
            this.labelMaND.Size = new System.Drawing.Size(172, 29);
            this.labelMaND.TabIndex = 78;
            this.labelMaND.Text = "Mã người dùng\r\n";
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(834, 80);
            this.textBoxMaKH.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaKH.Multiline = true;
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(194, 29);
            this.textBoxMaKH.TabIndex = 76;
            // 
            // labelMaKH
            // 
            this.labelMaKH.AutoSize = true;
            this.labelMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaKH.ForeColor = System.Drawing.Color.Transparent;
            this.labelMaKH.Location = new System.Drawing.Point(620, 80);
            this.labelMaKH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaKH.Name = "labelMaKH";
            this.labelMaKH.Size = new System.Drawing.Size(174, 29);
            this.labelMaKH.TabIndex = 75;
            this.labelMaKH.Text = "Mã khách hàng";
            // 
            // textBoxTimKiem
            // 
            this.textBoxTimKiem.Location = new System.Drawing.Point(763, 192);
            this.textBoxTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTimKiem.Multiline = true;
            this.textBoxTimKiem.Name = "textBoxTimKiem";
            this.textBoxTimKiem.Size = new System.Drawing.Size(265, 29);
            this.textBoxTimKiem.TabIndex = 74;
            // 
            // textBoxMaAcc
            // 
            this.textBoxMaAcc.Location = new System.Drawing.Point(1128, 38);
            this.textBoxMaAcc.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaAcc.Multiline = true;
            this.textBoxMaAcc.Name = "textBoxMaAcc";
            this.textBoxMaAcc.Size = new System.Drawing.Size(31, 29);
            this.textBoxMaAcc.TabIndex = 71;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(263, 105);
            this.textBoxPass.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPass.Multiline = true;
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(265, 29);
            this.textBoxPass.TabIndex = 72;
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(263, 47);
            this.textBoxUser.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUser.Multiline = true;
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(265, 29);
            this.textBoxUser.TabIndex = 73;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUser.ForeColor = System.Drawing.Color.Transparent;
            this.labelUser.Location = new System.Drawing.Point(99, 47);
            this.labelUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(129, 29);
            this.labelUser.TabIndex = 70;
            this.labelUser.Text = "UserName";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPass.ForeColor = System.Drawing.Color.Transparent;
            this.labelPass.Location = new System.Drawing.Point(104, 105);
            this.labelPass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(124, 29);
            this.labelPass.TabIndex = 69;
            this.labelPass.Text = "PassWord";
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
            this.iconButtonSave.Location = new System.Drawing.Point(344, 178);
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
            this.btnTimKiem.Location = new System.Drawing.Point(1054, 178);
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
            // dgvAccount
            // 
            this.dgvAccount.AllowUserToAddRows = false;
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ten,
            this.DonGia,
            this.Column1});
            this.dgvAccount.Location = new System.Drawing.Point(229, 235);
            this.dgvAccount.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.RowHeadersWidth = 51;
            this.dgvAccount.Size = new System.Drawing.Size(1001, 478);
            this.dgvAccount.TabIndex = 62;
            this.dgvAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccount_CellClick);
            // 
            // textBoxMaND
            // 
            this.textBoxMaND.Location = new System.Drawing.Point(834, 24);
            this.textBoxMaND.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaND.Multiline = true;
            this.textBoxMaND.Name = "textBoxMaND";
            this.textBoxMaND.Size = new System.Drawing.Size(194, 29);
            this.textBoxMaND.TabIndex = 79;
            // 
            // textBoxMaNND
            // 
            this.textBoxMaNND.Location = new System.Drawing.Point(834, 138);
            this.textBoxMaNND.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMaNND.Multiline = true;
            this.textBoxMaNND.Name = "textBoxMaNND";
            this.textBoxMaNND.Size = new System.Drawing.Size(194, 29);
            this.textBoxMaNND.TabIndex = 81;
            // 
            // labelMaNND
            // 
            this.labelMaNND.AutoSize = true;
            this.labelMaNND.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNND.ForeColor = System.Drawing.Color.Transparent;
            this.labelMaNND.Location = new System.Drawing.Point(556, 138);
            this.labelMaNND.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaNND.Name = "labelMaNND";
            this.labelMaNND.Size = new System.Drawing.Size(238, 29);
            this.labelMaNND.TabIndex = 80;
            this.labelMaNND.Text = "Mã nhóm người dùng";
            // 
            // Ten
            // 
            this.Ten.DataPropertyName = "UserName";
            this.Ten.HeaderText = "UserName";
            this.Ten.MinimumWidth = 6;
            this.Ten.Name = "Ten";
            this.Ten.ReadOnly = true;
            this.Ten.Width = 125;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "PassWord";
            this.DonGia.HeaderText = "PassWord";
            this.DonGia.MinimumWidth = 6;
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            this.DonGia.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Ma";
            this.Column1.HeaderText = "Column1";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            this.Column1.Width = 125;
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(1253, 738);
            this.Controls.Add(this.textBoxMaNND);
            this.Controls.Add(this.labelMaNND);
            this.Controls.Add(this.textBoxMaND);
            this.Controls.Add(this.labelMaND);
            this.Controls.Add(this.textBoxMaKH);
            this.Controls.Add(this.labelMaKH);
            this.Controls.Add(this.textBoxTimKiem);
            this.Controls.Add(this.textBoxMaAcc);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.iconButtonSave);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvAccount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AccountForm";
            this.Text = "AccountForm";
            this.Load += new System.EventHandler(this.Account_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelMaND;
        private System.Windows.Forms.TextBox textBoxMaKH;
        private System.Windows.Forms.Label labelMaKH;
        private System.Windows.Forms.TextBox textBoxTimKiem;
        private System.Windows.Forms.TextBox textBoxMaAcc;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private FontAwesome.Sharp.IconButton iconButtonSave;
        private FontAwesome.Sharp.IconButton btnX;
        private FontAwesome.Sharp.IconButton btnTimKiem;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnThem;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.TextBox textBoxMaND;
        private System.Windows.Forms.TextBox textBoxMaNND;
        private System.Windows.Forms.Label labelMaNND;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}