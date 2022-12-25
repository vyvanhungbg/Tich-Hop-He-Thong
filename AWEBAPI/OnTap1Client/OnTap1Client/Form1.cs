using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnTap1Client
{
    public partial class Form1 : Form
    {
        private static string baseURL = "http://localhost/ontap1/api/";
        private static string nhanVienURL = baseURL + "NhanVien";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //load();
        }

        private void BtnThem_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien(txtTen.Text.ToString(), float.Parse(txtHeSoLuong.Text.ToString()));
          
            HttpWebRequest request = HttpWebRequest.CreateHttp(nhanVienURL);
            request.Method = "POST";
            request.ContentType = "application/json";
           
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(NhanVien));
            json.WriteObject(request.GetRequestStream(), nhanVien);
            WebResponse response = request.GetResponse();
            load();

        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            string urlDelete = nhanVienURL + "?id=" + txtID.Text;
            HttpWebRequest request = HttpWebRequest.CreateHttp(urlDelete);
            request.Method = "DELETE";
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(NhanVien));       
            WebResponse response = request.GetResponse();
            object data = json.ReadObject(response.GetResponseStream());
            NhanVien sanPhams = data as NhanVien;
            if(sanPhams != null)
            {
                MessageBox.Show("Xóa thành công");
                load();
            }
            else
            {
                MessageBox.Show("Khong tim thay");
            }
            
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            NhanVien nhanVien = new NhanVien(int.Parse(txtID.Text),txtTen.Text.ToString(), float.Parse(txtHeSoLuong.Text.ToString()));
            var data = Encoding.Default.GetBytes(nhanVien.ToString());
            HttpWebRequest request = HttpWebRequest.CreateHttp(nhanVienURL);
            request.Method = "PUT";
            request.ContentType = "application/json";

            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(NhanVien));
            json.WriteObject(request.GetRequestStream(), nhanVien);
            WebResponse response = request.GetResponse();
            load();
        }

        private void load()
        {
            HttpWebRequest request = HttpWebRequest.CreateHttp(nhanVienURL);
            WebResponse response = request.GetResponse();
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(NhanVien[]));
            object data = json.ReadObject(response.GetResponseStream());
            NhanVien[] sanPhams = data as NhanVien[];
            dtgirdView.DataSource = sanPhams;
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            load();
        }
    }
}
