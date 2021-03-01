using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Net.Http.Formatting;
using ClientAdminFastFood.Models;

namespace ClientAdminFastFood
{
    public partial class AccountForm : Form
    {
        bool status;
        public AccountForm()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            textBoxMaAcc.Visible = false;
            lockText();
            showData(dgvAccount);
        }

        private void showData(DataGridView dgv)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("Account").Result;
            var item = response.Content.ReadAsAsync<List<Account>>().Result;
            dgv.DataSource = item;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgvAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvAccount.Rows[e.RowIndex];
                textBoxMaAcc.Text = row.Cells[0].Value.ToString();
                textBoxUser.Text = row.Cells[1].Value.ToString();
                textBoxPass.Text = row.Cells[2].Value.ToString();
                textBoxMaKH.Text = row.Cells[3].Value.ToString();
                textBoxMaND.Text = row.Cells[4].Value.ToString();
                textBoxMaNND.Text = row.Cells[5].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = true;
            unlockText();
            clearText();
            btnSua.Enabled = false;
        }

        private void lockText()
        {
            textBoxUser.Enabled = textBoxPass.Enabled = textBoxMaKH.Enabled = textBoxMaND.Enabled = textBoxMaNND.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void unlockText()
        {
            textBoxUser.Enabled = textBoxPass.Enabled = textBoxMaKH.Enabled = textBoxMaND.Enabled = textBoxMaNND.Enabled = true;
        }

        private void clearText()
        {
            textBoxUser.Text = textBoxPass.Text = textBoxMaKH.Text = textBoxMaND.Text = textBoxMaNND.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = false;
            unlockText();
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if (status == true)
            {
                Account acc = new Account()
                {
                    UserName = textBoxUser.Text,
                    PassWord = textBoxPass.Text,
                    MaKhachHang = int.Parse(textBoxMaKH.Text),
                    MaNguoiDung = int.Parse(textBoxMaND.Text),
                    MaNhomNguoiDung = int.Parse(textBoxMaNND.Text),

                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.PostAsJsonAsync("Account", acc).Result;
                try
                {
                    MessageBox.Show("Thêm account thành công");
                    //cus.SaveChanges();
                    showData(dgvAccount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                Account acc = new Account()
                {
                    UserName = textBoxUser.Text,
                    PassWord = textBoxPass.Text,
                    MaKhachHang = int.Parse(textBoxMaKH.Text),
                    MaNguoiDung = int.Parse(textBoxMaND.Text),
                    MaNhomNguoiDung = int.Parse(textBoxMaNND.Text),

                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.PostAsJsonAsync("Account", acc).Result;
                //cus.updateCus(textBoxMaKH.Text, textBoxTenKH.Text, textBoxSoCMND.Text, textBoxDiaChi.Text, textBoxSDT.Text);
                try
                {
                    MessageBox.Show("Cập nhật thông tin account thành công");
                    //cus.SaveChanges();
                    showData(dgvAccount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            clearText();
            lockText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn xóa account này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.DeleteAsync("Account/" + int.Parse(textBoxMaAcc.Text)).Result;
                //cus.delCus(textBoxMaKH.Text);
                try
                {
                    MessageBox.Show("Xóa account thành công");
                    //cus.SaveChanges();
                    showData(dgvAccount);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                clearText();
                btnXoa.Enabled = false;
            }
        }

        void timkiem()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("Account/" + textBoxTimKiem.Text).Result;
            var item = response.Content.ReadAsAsync<List<Account>>().Result;
            if (item == null)
            {
                MessageBox.Show("Không tồn tại account bạn muốn tìm");
            }
            else
            {
                List<Account> itemList = new List<Account>();
                for (int i = 0; i < item.Count(); i++)
                {
                    itemList.Add(item[i]);
                }
                dgvAccount.DataSource = itemList;
                dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvAccount.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }

        }

        void backTimKiem()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("SanPham").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<SanPham>>().Result;
            dgvAccount.DataSource = item;
            dgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvAccount.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (textBoxTimKiem.Text == "")
            {
                backTimKiem();
            }
            else
            {
                timkiem();
            }
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void getSanPhamName()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("SanPham/TenSanPham").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<SanPham>>().Result;
            //comboBoxTenDM.DataSource = item;
        }
    }
}


