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
    public partial class SanPhamForm : Form
    {
        bool status;
        public SanPhamForm()
        {
            InitializeComponent();
        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            textBoxMaSP.Visible = false;
            lockText();
            showData(dgvSanPham);
        }

        private void showData(DataGridView dgv)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("SanPham").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<SanPham>>().Result;
            dgv.DataSource = item;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvSanPham.Rows[e.RowIndex];
                textBoxMaSP.Text = row.Cells[0].Value.ToString();
                textBoxTenSP.Text = row.Cells[1].Value.ToString();
                textBoxDG.Text = row.Cells[2].Value.ToString();
                textBoxmota.Text = row.Cells[3].Value.ToString();
                textBoxMaDM.Text = row.Cells[4].Value.ToString();
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
            textBoxTenSP.Enabled = textBoxDG.Enabled = textBoxmota.Enabled = textBoxMaDM.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void unlockText()
        {
            textBoxTenSP.Enabled = textBoxDG.Enabled = textBoxmota.Enabled = textBoxMaDM.Enabled = true;
        }

        private void clearText()
        {
            textBoxTenSP.Text = textBoxDG.Text = textBoxmota.Text = textBoxMaDM.Text = "";
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
                SanPham sp = new SanPham()
                {
                    Ten = textBoxTenSP.Text,
                    DonGia = int.Parse(textBoxDG.Text),
                    MoTa = textBoxmota.Text,
                    MaDanhMucSanPham = int.Parse(textBoxMaDM.Text),
                    
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.PostAsJsonAsync("SanPham", sp).Result;
                try
                {
                    MessageBox.Show("Thêm sản phẩm thành công");
                    //cus.SaveChanges();
                    showData(dgvSanPham);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                SanPham sp = new SanPham()
                {
                    Ten = textBoxTenSP.Text,
                    DonGia = int.Parse(textBoxDG.Text),
                    MoTa = textBoxmota.Text,
                    MaDanhMucSanPham = int.Parse(textBoxMaDM.Text),

                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.PutAsJsonAsync("SanPham/" + int.Parse(textBoxMaSP.Text), sp).Result;
                //cus.updateCus(textBoxMaKH.Text, textBoxTenKH.Text, textBoxSoCMND.Text, textBoxDiaChi.Text, textBoxSDT.Text);
                try
                {
                    MessageBox.Show("Cập nhật thông tin sản phẩm thành công");
                    //cus.SaveChanges();
                    showData(dgvSanPham);
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
            if (MessageBox.Show("Bạn có chắc muốn xóa sản phẩm này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.DeleteAsync("SanPham/" + int.Parse(textBoxMaSP.Text)).Result;
                //cus.delCus(textBoxMaKH.Text);
                try
                {
                    MessageBox.Show("Xóa sản phẩm thành công");
                    //cus.SaveChanges();
                    showData(dgvSanPham);
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
            HttpResponseMessage response = client.GetAsync("SanPham/" + textBoxTimKiem.Text).Result;
            var item = response.Content.ReadAsAsync<List<SanPham>>().Result;
            if (item == null)
            {
                MessageBox.Show("Không tồn tại sản phẩm bạn muốn tìm");
            }
            else
            {
                List<SanPham> itemList = new List<SanPham>();
                for (int i = 0; i < item.Count(); i++)
                {
                    itemList.Add(item[i]);
                }
                dgvSanPham.DataSource = itemList;
                dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }

        }

        void backTimKiem()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("SanPham").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<SanPham>>().Result;
            dgvSanPham.DataSource = item;
            dgvSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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

