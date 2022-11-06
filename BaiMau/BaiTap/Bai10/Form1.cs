using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Bai10
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        public static string path = "../../XMLFile1.xml";
        public Form1()
        {
            InitializeComponent();
        }
        private void load_combobox()
        {
            DataSet dts = new DataSet();
            dts.ReadXml(path);
            cboChiNhanh.DataSource = dts.Tables["khachhang"];
            cboChiNhanh.DisplayMember = "chinhanh";
        }
        private void hienthi()
        {
            listView1.Items.Clear();
            DataSet dts = new DataSet();
            DataTable dtl = new DataTable();
            dts.ReadXml(path);
            dtl = dts.Tables["khachhang"];
            if(dtl.Rows.Count > 0)
            {
                int i = 0;
                foreach(DataRow dr in dtl.Rows)
                {
                    ListViewItem lvi = new ListViewItem(dtl.Rows[i]["chinhanh"].ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["makh"].ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["hoten"].ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["diachi"].ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["sodt"].ToString());
                    i++;
                    listView1.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ kiệu để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_combobox();
            hienthi();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                cboChiNhanh.Text = item.SubItems[0].Text;
                txtMaKH.Text = item.SubItems[1].Text;
                txtHoTen.Text = item.SubItems[2].Text;
                txtDiaChi.Text = item.SubItems[3].Text;
                txtSoDienThoai.Text = item.SubItems[4].Text;
            }
        }
        private void them()
        {
            doc.Load(path);
            XmlAttribute makh, chinhanh;
            XmlElement khachhang, hoten, diachi, sodt;
            khachhang = doc.CreateElement("khachhang");
            makh = doc.CreateAttribute("makh");
            chinhanh = doc.CreateAttribute("chinhanh");
            hoten = doc.CreateElement("hoten");
            diachi = doc.CreateElement("diachi");
            sodt = doc.CreateElement("sodt");
            makh.InnerText = txtMaKH.Text;
            chinhanh.InnerText = cboChiNhanh.Text;
            hoten.InnerText = cboChiNhanh.Text;
            diachi.InnerText = txtDiaChi.Text;
            sodt.InnerText = txtSoDienThoai.Text;
            khachhang.SetAttributeNode(makh);
            khachhang.SetAttributeNode(chinhanh);
            khachhang.AppendChild(hoten);
            khachhang.AppendChild(diachi);
            khachhang.AppendChild(sodt);
            doc.DocumentElement.AppendChild(khachhang);
            doc.Save(path);
            MessageBox.Show("Thêm khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void sua()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/danhsachkhachhang/khachhang[@makh='" + (txtMaKH.Text).Trim() + "']");
            if(node != null)
            {
                node.Attributes[1].InnerText = cboChiNhanh.Text;
                node.ChildNodes[0].InnerText = txtHoTen.Text;
                node.ChildNodes[1].InnerText = txtDiaChi.Text;
                node.ChildNodes[2].InnerText = txtSoDienThoai.Text;
                doc.Save(path);
                MessageBox.Show("Sửa thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có mã khách hàng cần sửa trong CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void xoa()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/danhsachkhachhang/khachhang[@makh='" + (txtMaKH.Text).Trim() + "']");
            if (node != null)
            {
                doc.DocumentElement.RemoveChild(node);
                doc.Save(path);
                MessageBox.Show("Xoá thông tin khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có mã khách hàng cần xoá trong CSDL!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            them();
            hienthi();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sua();
            hienthi();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            xoa();
            hienthi();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
