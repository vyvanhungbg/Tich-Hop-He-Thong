using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VyVanHung_2019601093_Bai7_Phieu1
{
    public partial class Form1 : Form
    {
        private DataUtil data = new DataUtil();
        public Form1()
        {
            InitializeComponent();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            TaiKhoan taiKhoan = data.findTaiKhoanByID(txtSTK.Text);
            if(taiKhoan == null)
            {
                MessageBox.Show("Không tìm thấy", "Thông báo");
            }
            else
            {
                List<TaiKhoan> tmp = new List<TaiKhoan>();
                tmp.Add(taiKhoan);
                dtgrView.DataSource = tmp;
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            
            try
            {
                TaiKhoan taiKhoan = getTaiKhoanFromForm();
                if(data.findNodeByID(taiKhoan.soTaiKhoan) != null)
                {
                    throw new Exception("Trùng mã khóa chính");
                }
                data.ThemTaiKhoan(taiKhoan);
                lbError.Text = "Thêm thành công";
                clear();
                displayData();
            }
            catch(Exception ex)
            {
                lbError.Text = "Thêm thất bại ("+ex.Message+")";
            }
            
        }

        private TaiKhoan getTaiKhoanFromForm()
        {

            bool error = false;
            string soTaiKhoan = txtSTK.Text.ToString().Trim();
            string tenTaiKhoan = txtTenTaiKhoan.Text.ToString().Trim();
            TaiKhoan tmp = (TaiKhoan)cbbDiaChi.SelectedItem;
            string diaChi = tmp.diaChi.ToString().Trim();
            string dienThoai = txtDienThoai.Text.ToString().Trim();
            string soTien = txtSoTien.Text.ToString().Trim();
            double mSoTien = 0.0;

            lbErrorSTK.Text = "";
            lbErrorTenTaiKhoan.Text = "";
            lbErrorDiaChi.Text = "";
            lbErrorDienThoai.Text = "";
            lbErrorSoTien.Text = "";
            if (String.IsNullOrEmpty(soTaiKhoan))
            {
                error = true;
                lbErrorSTK.Text = "STK trống";
            }
          

            if (String.IsNullOrEmpty(tenTaiKhoan))
            {
                error = true;
                lbErrorTenTaiKhoan.Text = "Tên tài khoản  trống";
            }
            

            if (String.IsNullOrEmpty(diaChi))
            {
                error = true;
                lbErrorDiaChi.Text = "Địa chỉ trống";
            }
           

            if (String.IsNullOrEmpty(dienThoai))
            {
                error = true;
                lbErrorDienThoai.Text = "Điện thoại trống";
            }
           

            try
            {
                mSoTien = Double.Parse(soTien);
               
            }
            catch(Exception ex)
            {
                error = true;
                lbErrorSoTien.Text = "Số tiền không hợp lệ";
            }

            if (error == true)
                throw new Exception("Dữ liệu không hợp lệ");

            TaiKhoan taiKhoan = new TaiKhoan(
               soTaiKhoan,
                tenTaiKhoan,
                diaChi,
                dienThoai,
                mSoTien
                );

            return taiKhoan;
        }

        private void displayData()
        {
            dtgrView.DataSource = data.getAll();
            dtgrView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgrView.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgrView.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgrView.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dtgrView.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
      
        private void clear()
        {
            cbbDiaChi.SelectedIndex = 1;
            txtSTK.Clear();
            txtTenTaiKhoan.Clear();
            txtDienThoai.Clear();
            txtSoTien.Clear();
            txtSTK.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            list.Add(new TaiKhoan("10", "", "Bắc Giang", "", 2.0));
            list.Add(new TaiKhoan("20", "", "Hà Nội", "", 2.0));
            list.Add(new TaiKhoan("30", "", "Hải Phòng", "", 2.0));

            cbbDiaChi.DataSource = list;
            cbbDiaChi.DisplayMember = "diaChi";
            cbbDiaChi.ValueMember = "soTaiKhoan";

            displayData();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                TaiKhoan taiKhoan = getTaiKhoanFromForm();
                
                data.Update(taiKhoan);
                lbError.Text = "Cập nhật thành công";
                clear();
                displayData();
            }
            catch (Exception ex)
            {
                lbError.Text = "Cập nhật thất bại (" + ex.Message + ")";
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult messageBox = MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(messageBox == DialogResult.Yes)
            {
                data.Delete(txtSTK.Text);
                displayData();
            }
        }

        private void DtgrView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                TaiKhoan taiKhoan = (TaiKhoan)dtgrView.CurrentRow.DataBoundItem;
                txtSTK.Text = taiKhoan.soTaiKhoan;
                txtTenTaiKhoan.Text = taiKhoan.tenTaiKhoan;
                cbbDiaChi.SelectedItem = taiKhoan;
                txtDienThoai.Text = taiKhoan.dienThoai;
                txtSoTien.Text = taiKhoan.soTien.ToString();
            }catch(Exception ex)
            {

            }
        }
    }
}
