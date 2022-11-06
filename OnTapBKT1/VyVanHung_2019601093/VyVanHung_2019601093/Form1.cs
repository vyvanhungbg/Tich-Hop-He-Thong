using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VyVanHung_2019601093
{
    public partial class Form1 : Form
    {
        private DataUtil data = new DataUtil();

        List<String> nhaXuatBan = new List<string>();
      
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            lbError.Text = "";
            Sach sach = getSachFromForm();
            if(data.findNodeByID(sach.maSach) == null)
            {
                data.ThemSach(sach);
                DisplayData();
            }
            else
            {
                lbError.Text = "Trung mã sách ";
            }
        }

        private void DisplayData()
        {
            List<Sach> list = data.getAll();
            dtgrView.DataSource = list;
            dtgrView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgrView.Columns[0].HeaderText = "ABC";
            dtgrView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgrView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgrView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgrView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private Sach getSachFromForm()
        {
            bool error = false;
            string maSach = txtMaSach.Text;
            string nhaXuatBan = (String) cbbNhaXB.SelectedItem;
            string tenSach = txtTenSach.Text;
            string giaBan = txtGiaBan.Text;
            string tacGia = txtTacGia.Text;
            Sach sach = new Sach(maSach, nhaXuatBan, tenSach, Double.Parse(giaBan), tacGia);
            return sach;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nhaXuatBan.Add("NXB GD");
            nhaXuatBan.Add("NXB TH");
            nhaXuatBan.Add("NXB KĐ");
            cbbNhaXB.DataSource = nhaXuatBan;
            DisplayData();
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            Sach sach = getSachFromForm();
            bool check = data.Sua(sach);
            DisplayData();
            if (!check)
            {
                MessageBox.Show("Thông báo", "Sửa thất bại");
            }
        }

        private void DtgrView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Sach sach = (Sach)dtgrView.CurrentRow.DataBoundItem;
                txtMaSach.Text = sach.maSach;
                txtTenSach.Text = sach.tenSach;
                txtGiaBan.Text = sach.giaBan.ToString();
                txtTacGia.Text = sach.tacGia;
                cbbNhaXB.SelectedIndex = nhaXuatBan.IndexOf(sach.nhaXuatBan);
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult item = MessageBox.Show("Thông báo", "Bạn chăc muốn xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(item == DialogResult.Yes)
            {
                bool chack = data.Xoa(txtMaSach.Text);
                if (!chack)
                {
                    MessageBox.Show("Thông báo", "Xóa thất bại");
                }
                DisplayData();
            }
            
        }
    }
}
