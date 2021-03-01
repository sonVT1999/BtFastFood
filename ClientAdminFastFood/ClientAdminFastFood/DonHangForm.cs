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
    public partial class DonHangForm : Form
    {
        bool status;
        public DonHangForm()
        {
            InitializeComponent();
        }

        private void DonHang_Load(object sender, EventArgs e)
        {
            textBoxMaDH.Visible = false;
            lockText();
            showData(dgvDonHang);
        }

        private void showData(DataGridView dgv)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("DonHang/getall").Result;
            var item = response.Content.ReadAsAsync<List<DonHang>>().Result;
            dgv.DataSource = item;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSua.Enabled = true;
            try
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgvDonHang.Rows[e.RowIndex];

                textBoxMaDH.Text = row.Cells[0].Value.ToString();
                textBoxTT.Text = row.Cells[4].Value.ToString();

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
            textBoxTT.Enabled = false;
            btnSua.Enabled  = false;
        }

        private void unlockText()
        {
             textBoxTT.Enabled = true;
        }

        private void clearText()
        {
             textBoxTT.Text = "";
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            status = false;
            unlockText();
        }

        private void iconButtonSave_Click(object sender, EventArgs e)
        {
            //if (status == true)
            //{
            //    DonHang dh = new DonHang()
            //    {

            //    };
            //    HttpClient client = new HttpClient();
            //    client.BaseAddress = new Uri("http://localhost:59609/api/");
            //    HttpResponseMessage response = client.PostAsJsonAsync("DonHang", dh).Result;
            //    try
            //    {
            //        MessageBox.Show("Thêm đơn hàng thành công");

            //        showData(dgvDonHang);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
            //else
            //{
            DonHang dh = new DonHang()
            {
                TrangThai = int.Parse(textBoxTT.Text)
                };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("http://localhost:59609/api/");
                HttpResponseMessage response = client.PutAsJsonAsync("DonHang/" + int.Parse(textBoxMaDH.Text), dh).Result;
                //cus.updateCus(textBoxMaKH.Text, textBoxTenKH.Text, textBoxSoCMND.Text, textBoxDiaChi.Text, textBoxSDT.Text);
                try
                {
                    MessageBox.Show("Cập nhật tình trạng đơn hàng thành công");
                    //cus.SaveChanges();
                    showData(dgvDonHang);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            //}
            clearText();
            lockText();
        }

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    if (MessageBox.Show("Bạn có chắc muốn xóa đơn hàng này?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //    {
        //        HttpClient client = new HttpClient();
        //        client.BaseAddress = new Uri("http://localhost:59609/api/");
        //        HttpResponseMessage response = client.DeleteAsync("DonHang/" + int.Parse(textBoxMaDH.Text)).Result;
        //        //cus.delCus(textBoxMaKH.Text);
        //        try
        //        {
        //            MessageBox.Show("Xóa đơn hàng thành công");
        //            //cus.SaveChanges();
        //            showData(dgvDonHang);
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message);
        //        }
        //        clearText();
        //        btnXoa.Enabled = false;
        //    }
        //}

        void timkiem()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:41256/api/");
            HttpResponseMessage response = client.GetAsync("DonHang/" + textBoxTimKiem.Text).Result;
            var item = response.Content.ReadAsAsync<List<DonHang>>().Result;
            if (item == null)
            {
                MessageBox.Show("Không tồn tại đơn hàng bạn muốn tìm");
            }
            else
            {
                List<DonHang> itemList = new List<DonHang>();
                for (int i = 0; i < item.Count(); i++)
                {
                    itemList.Add(item[i]);
                }
                dgvDonHang.DataSource = itemList;
                dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDonHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            }

        }

        void backTimKiem()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("http://localhost:59609/api/");
            HttpResponseMessage response = client.GetAsync("DonHang").Result;
            var item = response.Content.ReadAsAsync<IEnumerable<DonHang>>().Result;
            dgvDonHang.DataSource = item;
            dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonHang.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
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
