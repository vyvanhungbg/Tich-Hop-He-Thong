using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VyVanHung_2019601093_Bai8_Phieu3
{
    public partial class Form1 : Form
    {
        private DataUtil data = new DataUtil();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void DisplayData()
        {
            dtgridView.DataSource = data.getAll();
            dtgridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgridView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgridView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgridView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgridView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgridView.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien nhanVien = getNhanVienFormFrom();
                if (data.findNodeByID(nhanVien.maNV) == null)
                {
                    data.Them(getNhanVienFormFrom());
                    DisplayData();
                }
                else
                {
                    MessageBox.Show("Thông báo", "Trùng mã khóa chính ");
                }
            }catch(Exception ex)
            {
               
            }
           
        }

        private NhanVien getNhanVienFormFrom()
        {
            bool err = false;
            lbErrMaNV.Text = "";
            lbErrTenNV.Text = "";
            lbErrrLuong.Text = "";
            lbErrTuoi.Text = "";
            lbErrXa.Text = "";
            lbErrHuyen.Text = "";
            lbErrTInh.Text = "";
            lbErrSTD.Text = "";


           string maNV= txtMaNV.Text;
           string tenNv= txtTenNV.Text;
         
           int mtuoi = 0;
           double luong = 0.0;
           string xa=     txtXa.Text;
           string huyen=     txtHuyen.Text;
           string tinh=     txtTinh.Text;
           string std= txtSDT.Text;

            if (String.IsNullOrEmpty(maNV))
            {
                err = true;
                lbErrMaNV.Text = "Mã nhân viên trống !";
            }

            if (String.IsNullOrEmpty(tenNv))
            {
                err = true;
                lbErrTenNV.Text = "Ten nhân viên trống !";
            }

            try
            {
                mtuoi = int.Parse(txtTuoi.Text.Trim());
            }
            catch(Exception ex)
            {
                err = true;
                lbErrTuoi.Text = "TUổi là 1 số";
            }

            try
            {
                luong = int.Parse(txtLuong.Text.Trim());
            }
            catch (Exception ex)
            {
                err = true;
                lbErrrLuong.Text = "Luong là 1 số";
            }

            if (err == true)
                throw new Exception("Lỗi dữ liệu");

            NhanVien nhanVien = new NhanVien(
                maNV,
                tenNv,
                mtuoi,
                luong, xa, huyen, tinh, std);
             

            return nhanVien;
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = getNhanVienFormFrom();
            if (data.findNodeByID(nhanVien.maNV) != null)
            {
                data.Sua(getNhanVienFormFrom());
                DisplayData();
            }
            else
            {
                MessageBox.Show("Thông báo", "Không tìm thấy ");
            }
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Thông báo", "Muốn xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(rs == DialogResult.Yes)
            {
                data.Xoa(txtMaNV.Text.Trim());
                DisplayData();
            }
        }

        private void clear()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtTuoi.Clear();
            txtLuong.Clear();
            txtXa.Clear();
            txtHuyen.Clear();
            txtTinh.Clear();
            txtSDT.Clear();
            txtMaNV.Focus();
        }

        private void DtgridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                NhanVien nhanVien = (NhanVien)dtgridView.CurrentRow.DataBoundItem;
                txtMaNV.Text = nhanVien.maNV;
                txtTenNV.Text = nhanVien.ten;
            }catch(Exception ex)
            {

            }
        }
    }
}
