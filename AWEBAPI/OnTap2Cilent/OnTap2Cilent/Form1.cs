using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap2Cilent
{
    public partial class Form1 : Form
    {
        private static string baseURL = "http://localhost/OnTap2/api/NhanVien";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getAll();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void getAll()
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(baseURL);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(NhanVien []));
            var data = json.ReadObject(response.GetResponseStream());
            NhanVien[] list = data as NhanVien[];
            dtgridView.DataSource = list;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            NhanVien newNhanvien = new NhanVien(txtTenNV.Text, float.Parse(txtHSLuong.Text));

            HttpWebRequest request = HttpWebRequest.CreateHttp(baseURL);
           
            request.Method = "POST";
            request.ContentType = "application/json";
            DataContractJsonSerializer convert = new DataContractJsonSerializer(typeof(NhanVien));
            convert.WriteObject(request.GetRequestStream(), newNhanvien);

            WebResponse response = request.GetResponse();
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(string));
            var data = json.ReadObject(response.GetResponseStream());
            string mess = data as string;
            MessageBox.Show(mess);
            getAll();
            clear();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            NhanVien newNhanVien = new NhanVien(int.Parse(txtMaNV.Text), txtTenNV.Text, float.Parse(txtHSLuong.Text));
            HttpWebRequest request = HttpWebRequest.CreateHttp(baseURL);

            request.Method = "PUT";
            request.ContentType = "application/json";
            DataContractJsonSerializer formater = new DataContractJsonSerializer(typeof(NhanVien));
            formater.WriteObject(request.GetRequestStream(), newNhanVien);

            WebResponse response = request.GetResponse();
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(string));
            var data = json.ReadObject(response.GetResponseStream());
            string mess = data as string;
            MessageBox.Show(mess);
            getAll();

        }

        public void clear()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtHSLuong.Clear();
        }

        private void DtgridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                NhanVien nhanVien = (NhanVien)dtgridView.CurrentRow.DataBoundItem;
                txtMaNV.Text = nhanVien.MaNV.ToString();
                txtTenNV.Text = nhanVien.TenNV;
                txtHSLuong.Text = nhanVien.HSLuong.ToString();
            }
            catch (Exception ex)
            {

            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string url = baseURL + "?id=" + txtMaNV.Text;
            HttpWebRequest request = HttpWebRequest.CreateHttp(url);
            request.Method = "DELETE";
            WebResponse response = request.GetResponse();

            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(string));
            var data = json.ReadObject(response.GetResponseStream());
            string mess = data as string;
            MessageBox.Show(mess);
            getAll();
        }
    }
}
