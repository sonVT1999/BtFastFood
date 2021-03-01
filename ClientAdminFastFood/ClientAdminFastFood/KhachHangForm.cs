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
    public partial class KhachHangForm : Form
    {
        bool status;
        public KhachHangForm()
        {
            InitializeComponent();
        }

        private void NguyenLieu_Load(object sender, EventArgs e)
        {
            textBoxMaKH.Visible = false;
            lockText();
            showData(dgvKhachHang);
        }

        private void showData(DataGridView dgv)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("KhachHang").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<KhachHang>>().Result;
            dgv.DataSource = item;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvKhachHang.Rows[e.RowIndex];
                textBoxMaKH.Text = row.Cells[0].Value.ToString();
                textBoxTenKH.Text = row.Cells[1].Value.ToString();
                textBoxDiaDiem.Text = row.Cells[4].Value.ToString();
                textBoxSDT.Text = row.Cells[5].Value.ToString();
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
            textBoxTenKH.Enabled = textBoxDiaDiem.Enabled = textBoxSDT.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void unlockText()
        {
            textBoxTenKH.Enabled = textBoxDiaDiem.Enabled = textBoxSDT.Enabled = true;
        }

        private void clearText()
        {
            textBoxTenKH.Text = textBoxDiaDiem.Text = textBoxSDT.Text = "";
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
                KhachHang kh = new KhachHang()
                {
                    Ten = textBoxTenKH.Text,
                    DiaDiem = textBoxDiaDiem.Text,
                    SoDienThoai = textBoxSDT.Text
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.PostAsJsonAsync("KhachHang", kh).Result;
                try
                {
                    MessageBox.Show("Thêm khách hàng thành công");
                    //cus.SaveChanges();
                    showData(dgvKhachHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                KhachHang kh = new KhachHang()
                {
                    Ten = textBoxTenKH.Text,
                    DiaDiem = textBoxDiaDiem.Text,
                    SoDienThoai = textBoxSDT.Text
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.PutAsJsonAsync("KhachHang/" + int.Parse(textBoxMaKH.Text), kh).Result;
                //cus.updateCus(textBoxMaKH.Text, textBoxTenKH.Text, textBoxSoCMND.Text, textBoxDiaChi.Text, textBoxSDT.Text);
                try
                {
                    MessageBox.Show("Cập nhật thông tin khách hàng thành công");
                    //cus.SaveChanges();
                    showData(dgvKhachHang);
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
            if (MessageBox.Show("Bạn có chắc muốn xóa khách hàng này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.DeleteAsync("KhachHang/" + int.Parse(textBoxMaKH.Text)).Result;
                //cus.delCus(textBoxMaKH.Text);
                try
                {
                    MessageBox.Show("Xóa khách hàng thành công");
                    //cus.SaveChanges();
                    showData(dgvKhachHang);
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
            HttpResponseMessage response = client.GetAsync("KhachHang/" + textBoxTimKiem.Text).Result;
            var item = response.Content.ReadAsAsync<List<KhachHang>>().Result;
            if (item == null)
            {
                MessageBox.Show("Không tồn tại khách hàng bạn muốn tìm");
            }
            else
            {
                List<KhachHang> itemList = new List<KhachHang>();
                for (int i = 0; i < item.Count(); i++)
                {
                    itemList.Add(item[i]);
                }
                dgvKhachHang.DataSource = itemList;
                dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }

        }

        void backTimKiem()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("KhachHang").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<KhachHang>>().Result;
            dgvKhachHang.DataSource = item;
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhachHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
    }
}
