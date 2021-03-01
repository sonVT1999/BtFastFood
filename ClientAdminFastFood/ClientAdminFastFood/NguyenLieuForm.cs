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

namespace Hotel_SoftWare2
{
    public partial class CustomersForm : Form
    {
        public CustomersForm()
        {
            InitializeComponent();
        }

        private void btnX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            status = true;
            unlockText();
            clearText();
            btnSua.Enabled = false;
        }

        private void CustomersForm_Load(object sender, EventArgs e)
        {
            labelMaNL.Visible = textBoxMaNL.Visible = false;
            ShowNL(dgvCustomers);
            lockText();
        }

        private void ShowNL(DataGridView dgv)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("NguyenLieu").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<NguyenLieu>>().Result;
            dgv.DataSource = item;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        
        private void lockText()
        {
            textBoxDVT.Enabled = textBoxMaNL.Enabled = textBoxTenNL.Enabled = false;
            btnSua.Enabled = btnXoa.Enabled = false;
        }

        private void unlockText()
        {
            textBoxTenNL.Enabled = textBoxDVT.Enabled = true;
        }

        bool status;
        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            if(status == true)
            {
                NguyenLieu nl = new NguyenLieu()
                {
                    TenNguyenLieu = textBoxTenNL.Text, DonVitinh = textBoxDVT.Text
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.PostAsJsonAsync("NguyenLieu", nl).Result;
                try
                {
                    MessageBox.Show("Thêm nguyên liệu thành công");
                    //cus.SaveChanges();
                    ShowNL(dgvCustomers);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                NguyenLieu nl = new NguyenLieu()
                {
                    TenNguyenLieu = textBoxTenNL.Text,
                    DonVitinh = textBoxDVT.Text
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.PutAsJsonAsync("NguyenLieu/"+ int.Parse(textBoxMaNL.Text), nl).Result;
                //cus.updateCus(textBoxMaKH.Text, textBoxTenKH.Text, textBoxSoCMND.Text, textBoxDiaChi.Text, textBoxSDT.Text);
                try
                {
                    MessageBox.Show("Cập nhật thông tin nguyên liệu thành công");
                    //cus.SaveChanges();
                    ShowNL(dgvCustomers);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            clearText();
            lockText();
        }

        private void clearText()
        {
            textBoxDVT.Text = textBoxTenNL.Text =  "";
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = btnXoa.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvCustomers.Rows[e.RowIndex];
                textBoxMaNL.Text = row.Cells[0].Value.ToString();
                textBoxTenNL.Text = row.Cells[1].Value.ToString();
                textBoxDVT.Text = row.Cells[2].Value.ToString();
            }
            catch
            {

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = false;
            unlockText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn xóa nguyên liệu này?","Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes )
            {
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.DeleteAsync("NguyenLieu/" + int.Parse(textBoxMaNL.Text)).Result;
                //cus.delCus(textBoxMaKH.Text);
                try
                {
                    MessageBox.Show("Xóa nguyên liệu thành công");
                    //cus.SaveChanges();
                    ShowNL(dgvCustomers);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                clearText();
                btnXoa.Enabled = false;
                textBoxMaNL.Text = "";
            }
        }

        void timkiem()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("NguyenLieu/" + textBoxTimKiem.Text).Result;
            var item = response.Content.ReadAsAsync<List<NguyenLieu>>().Result;
            if (item == null)
            {
                MessageBox.Show("Không tồn tại nguyên liệu bạn muốn tìm");
            }
            else
            {
                List<NguyenLieu> itemList = new List<NguyenLieu>();
                for (int i = 0; i < item.Count(); i++)
                {
                    itemList.Add(item[i]);
                }
                dgvCustomers.DataSource = itemList;
                dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }
            
        }

        void backTimKiem()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("NguyenLieu").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<NguyenLieu>>().Result;
            dgvCustomers.DataSource = item;
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
    }
}
