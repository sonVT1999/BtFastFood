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
    public partial class NguoiDungForm : Form
    {
        bool status;
        public NguoiDungForm()
        {
            InitializeComponent();
        }

        private void NguoiDung_Load(object sender, EventArgs e)
        {
            textBoxMaND.Visible = false;
            lockText();
            showData(dgvNguoiDung);
        }

        private void showData(DataGridView dgv)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("NguoiDung").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<NguoiDung>>().Result;
            dgv.DataSource = item;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgvNguoiDung_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvNguoiDung.Rows[e.RowIndex];
                textBoxMaND.Text = row.Cells[0].Value.ToString();
                textBoxTenND.Text = row.Cells[1].Value.ToString();
                textBoxViTri.Text = row.Cells[2].Value.ToString();
                textBoxNgaySinh.Text = row.Cells[3].Value.ToString();
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
            textBoxMaND.Enabled = textBoxTenND.Enabled = textBoxViTri.Enabled = textBoxNgaySinh.Enabled=false;
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void unlockText()
        {
            textBoxMaND.Enabled = textBoxTenND.Enabled = textBoxViTri.Enabled = textBoxNgaySinh.Enabled =true;
        }

        private void clearText()
        {
            textBoxMaND.Text = textBoxTenND.Text = textBoxViTri.Text = textBoxNgaySinh.Text ="";
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
                NguoiDung nd = new NguoiDung()
                {
                    Ten = textBoxTenND.Text,
                    ViTri = textBoxViTri.Text,
                    NgaySinh = DateTime.Parse(textBoxNgaySinh.Text),
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.PostAsJsonAsync("NguoiDung", nd).Result;
                try
                {
                    MessageBox.Show("Thêm người dùng thành công");
                    //cus.SaveChanges();
                    showData(dgvNguoiDung);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                NguoiDung nd = new NguoiDung()
                {
                    Ten = textBoxTenND.Text,
                    ViTri = textBoxViTri.Text,
                    NgaySinh = DateTime.Parse(textBoxNgaySinh.Text),
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.PutAsJsonAsync("NguoiDung/" + int.Parse(textBoxMaND.Text), nd).Result;
                //cus.updateCus(textBoxMaKH.Text, textBoxTenKH.Text, textBoxSoCMND.Text, textBoxDiaChi.Text, textBoxSDT.Text);
                try
                {
                    MessageBox.Show("Cập nhật thông tin người dùng thành công");
                    //cus.SaveChanges();
                    showData(dgvNguoiDung);
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
            if (MessageBox.Show("Bạn có chắc muốn xóa người dùng này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.DeleteAsync("NguoiDung/" + int.Parse(textBoxMaND.Text)).Result;
                //cus.delCus(textBoxMaKH.Text);
                try
                {
                    MessageBox.Show("Xóa người dùng thành công");
                    //cus.SaveChanges();
                    showData(dgvNguoiDung);
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
            HttpResponseMessage response = client.GetAsync("NguoiDung/" + textBoxTimKiem.Text).Result;
            var item = response.Content.ReadAsAsync<List<NguoiDung>>().Result;
            if (item == null)
            {
                MessageBox.Show("Không tồn tại người dùng bạn muốn tìm");
            }
            else
            {
                List<NguoiDung> itemList = new List<NguoiDung>();
                for (int i = 0; i < item.Count(); i++)
                {
                    itemList.Add(item[i]);
                }
                
                dgvNguoiDung.DataSource = itemList;
                dgvNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvNguoiDung.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }

        }

        void backTimKiem()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("NguoiDung").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<NguoiDung>>().Result;
            dgvNguoiDung.DataSource = item;
            dgvNguoiDung.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNguoiDung.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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


