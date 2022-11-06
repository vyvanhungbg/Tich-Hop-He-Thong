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

namespace bai10
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        public static string path = "../../thongtin.xml";
        public Form1()
        {
            InitializeComponent();
           
        }
        private void load_combobox()
        {
            DataSet dts = new DataSet();
            dts.ReadXml(path);
            cbbChiNhanh.DataSource = dts.Tables["khachhang"];
            cbbChiNhanh.DisplayMember = "chinhanh";
        }
        private void hienthi()
        {
            listView1.Items.Clear();
            DataSet dts = new DataSet();
            DataTable dtl = new DataTable();
            dts.ReadXml(path);
            dtl = dts.Tables["khachhang"];
            if (dtl.Rows.Count > 0)
            {
                int i = 0;
                foreach (DataRow dr in dtl.Rows)
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
                MessageBox.Show("Khong co du lieu de hien thi", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void them()
        {
            doc.Load(path);
            XmlElement khachhang, ten, dc,sdt;
            XmlAttribute chinhanh, ma;
            khachhang = doc.CreateElement("khachhang");
            ma = doc.CreateAttribute("makh");
            chinhanh = doc.CreateAttribute("chinhanh");
            ten = doc.CreateElement("hoten");
            dc = doc.CreateElement("diachi");
            sdt = doc.CreateElement("sodt");
            chinhanh.InnerText = cbbChiNhanh.Text;
            ma.InnerText = txtMa.Text;
            ten.InnerText = txtTen.Text;
            dc.InnerText = txtDC.Text;
            sdt.InnerText = txtSDT.Text;
            khachhang.SetAttributeNode(ma);
            khachhang.SetAttributeNode(chinhanh);
            khachhang.AppendChild(ten);
            khachhang.AppendChild(dc);
            khachhang.AppendChild(sdt);
            doc.DocumentElement.AppendChild(khachhang);
            doc.Save(path);
            MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void sua()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/danhsachkhachhang/khachhang[@makh='" + (txtMa.Text).Trim() + "']");
            if (node != null)
            {
                node.Attributes[1].InnerText = cbbChiNhanh.Text;
                node.ChildNodes[0].InnerText = txtTen.Text;
                node.ChildNodes[1].InnerText = txtDC.Text;
                node.ChildNodes[2].InnerText = txtSDT.Text;

                doc.Save(path);
                MessageBox.Show("Sua thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("So goi den muon sua khong co trong CSDL", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void xoa()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/danhsachkhachhang/khachhang[@makh='" + (txtMa.Text).Trim() + "']");
            if (node != null)
            {
                doc.DocumentElement.RemoveChild(node);
                doc.Save(path);
                MessageBox.Show("Xoa thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("So goi den muon xoa khong co trong CSDL", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                cbbChiNhanh.Text = item.SubItems[0].Text;
                txtMa.Text = item.SubItems[1].Text;
                txtTen.Text = item.SubItems[2].Text;
                txtDC.Text = item.SubItems[3].Text;
                txtSDT.Text = item.SubItems[4].Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbChiNhanh.Text == "" || txtMa.Text == "" || txtTen.Text == "" || txtDC.Text == "" || txtSDT.Text == "")
                {
                    MessageBox.Show("Vui long nhap day du thong tin muon them", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    them();
                    hienthi();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Co loi xay ra, khong the them", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text == "")
                {
                    MessageBox.Show("Vui long nhap vao so goi den muon xoa", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    xoa();
                    hienthi();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Co loi xay ra, khong the xoa", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text == "")
                {
                    MessageBox.Show("Vui long nhap vao so goi den muon sua", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    sua();
                    hienthi();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Co loi xay ra, khong the sua", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Ban co that su muon thoat ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_combobox();
            hienthi();
        }

        /*        private void Form1_Load(object sender, EventArgs e)
                {
                    load_combobox();
                    hienthi();
                }*/
    }
}
