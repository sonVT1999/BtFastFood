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
    public partial class DanhMucSanPhamForm : Form
    {
        bool status;
        public DanhMucSanPhamForm()
        {
            InitializeComponent();
        }

        private void DanhMucSanPham_Load(object sender, EventArgs e)
        {
            textBoxMaDM.Visible = false;
            lockText();
            showData(dgvDanhMucSanPham);
        }

        private void showData(DataGridView dgv)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("DanhMucSanPham").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<DanhMucSanPham>>().Result;
            dgv.DataSource = item;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgvDanhMucSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDanhMucSanPham.Rows[e.RowIndex];
                textBoxMaDM.Text = row.Cells[0].Value.ToString();
                textBoxTenDM.Text = row.Cells[1].Value.ToString();
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
            textBoxTenDM.Enabled  = false;
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void unlockText()
        {
            textBoxTenDM.Enabled = true;
        }

        private void clearText()
        {
            textBoxTenDM.Text  = "";
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
                DanhMucSanPham dm = new DanhMucSanPham()
                {
                    Ten = textBoxTenDM.Text,
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.PostAsJsonAsync("DanhMucSanPham", dm).Result;
                try
                {
                    MessageBox.Show("Thêm danh mục sản phẩm thành công");
                    //cus.SaveChanges();
                    showData(dgvDanhMucSanPham);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                DanhMucSanPham dm = new DanhMucSanPham()
                {
                    Ten = textBoxTenDM.Text,
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.PutAsJsonAsync("DanhMucSanPham/" + int.Parse(textBoxMaDM.Text), dm).Result;
                //cus.updateCus(textBoxMaKH.Text, textBoxTenKH.Text, textBoxSoCMND.Text, textBoxDiaChi.Text, textBoxSDT.Text);
                try
                {
                    MessageBox.Show("Cập nhật thông tin danh mục sản phẩm thành công");
                    //cus.SaveChanges();
                    showData(dgvDanhMucSanPham);
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
            if (MessageBox.Show("Bạn có chắc muốn xóa danh mục sản phẩm này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.DeleteAsync("DanhMucSanPham/" + int.Parse(textBoxMaDM.Text)).Result;
                //cus.delCus(textBoxMaKH.Text);
                try
                {
                    MessageBox.Show("Xóa danh mục sản phẩm thành công");
                    //cus.SaveChanges();
                    showData(dgvDanhMucSanPham);
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
            HttpResponseMessage response = client.GetAsync("DanhMucSanPham/" + textBoxTimKiem.Text).Result;
            var item = response.Content.ReadAsAsync<List<DanhMucSanPham>>().Result;
            if (item == null)
            {
                MessageBox.Show("Không tồn tại danh mục sản phẩm bạn muốn tìm");
            }
            else
            {
                List<DanhMucSanPham> itemList = new List<DanhMucSanPham>();
                for (int i = 0; i < item.Count(); i++)
                {
                    itemList.Add(item[i]);
                }
                dgvDanhMucSanPham.DataSource = itemList;
                dgvDanhMucSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDanhMucSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }

        }

        void backTimKiem()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("DanhMucSanPham").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<DanhMucSanPham>>().Result;
            dgvDanhMucSanPham.DataSource = item;
            dgvDanhMucSanPham.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDanhMucSanPham.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
