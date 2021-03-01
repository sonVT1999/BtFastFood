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
    public partial class NhaCungCapForm : Form
    {
        bool status;
        public NhaCungCapForm()
        {
            InitializeComponent();
        }

        private void NhaCungCap_Load(object sender, EventArgs e)
        {
            textBoxMaNCC.Visible = false;
            lockText();
            showData(dgvNCC);
        }

        private void showData(DataGridView dgv)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("NhaCungCap").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<NhaCungCap>>().Result;
            dgv.DataSource = item;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNCC.Rows[e.RowIndex];
                textBoxMaNCC.Text = row.Cells[0].Value.ToString();
                textBoxTenNCC.Text = row.Cells[1].Value.ToString();
                textBoxDiaDiem.Text = row.Cells[3].Value.ToString();
                textBoxSDT.Text = row.Cells[2].Value.ToString();
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
            textBoxTenNCC.Enabled = textBoxDiaDiem.Enabled = textBoxSDT.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void unlockText()
        {
            textBoxTenNCC.Enabled = textBoxDiaDiem.Enabled = textBoxSDT.Enabled = true;
        }

        private void clearText()
        {
            textBoxTenNCC.Text = textBoxDiaDiem.Text = textBoxSDT.Text = "";
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
                    Ten = textBoxTenNCC.Text,
                    DiaDiem = textBoxDiaDiem.Text,
                    SoDienThoai = textBoxSDT.Text
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.PostAsJsonAsync("NhaCungCap", kh).Result;
                try
                {
                    MessageBox.Show("Thêm nhà cung cấp thành công");
                    //cus.SaveChanges();
                    showData(dgvNCC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                NhaCungCap ncc = new NhaCungCap()
                {
                    Ten = textBoxTenNCC.Text,
                    DiaDiem = textBoxDiaDiem.Text,
                    SoDienThoai = textBoxSDT.Text
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.PutAsJsonAsync("NhaCungCap/" + int.Parse(textBoxMaNCC.Text), ncc).Result;
                //cus.updateCus(textBoxMaKH.Text, textBoxTenKH.Text, textBoxSoCMND.Text, textBoxDiaChi.Text, textBoxSDT.Text);
                try
                {
                    MessageBox.Show("Cập nhật thông tin nhà cung cấp thành công");
                    //cus.SaveChanges();
                    showData(dgvNCC);
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
            if (MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.DeleteAsync("NhaCungCap/" + int.Parse(textBoxMaNCC.Text)).Result;
                //cus.delCus(textBoxMaKH.Text);
                try
                {
                    MessageBox.Show("Xóa nhà cung cấp thành công");
                    //cus.SaveChanges();
                    showData(dgvNCC);
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
            HttpResponseMessage response = client.GetAsync("NhaCungCap/" + textBoxTimKiem.Text).Result;
            var item = response.Content.ReadAsAsync<List<NhaCungCap>>().Result;
            if (item == null)
            {
                MessageBox.Show("Không tồn tại nhà cung cấp bạn muốn tìm");
            }
            else
            {
                List<NhaCungCap> itemList = new List<NhaCungCap>();
                for (int i = 0; i < item.Count(); i++)
                {
                    itemList.Add(item[i]);
                }
                dgvNCC.DataSource = itemList;
                dgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvNCC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }

        }

        void backTimKiem()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("NhaCungCap").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<NhaCungCap>>().Result;
            dgvNCC.DataSource = item;
            dgvNCC.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNCC.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
