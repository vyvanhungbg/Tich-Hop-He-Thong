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


namespace dom2
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        public static string path = "../../../XMLFile1.xml";
        public Form1()
        {
            InitializeComponent();
        }
        private void load_combo()
        {
            DataSet dts = new DataSet();
            dts.ReadXml(path);
            cbbChiNhanh.DataSource = dts.Tables["khachhang"];
            cbbChiNhanh.DisplayMember = "chinhanh";
        }
        private void hienthi()
        {
            dataList.Items.Clear();
            DataSet dts = new DataSet();
            DataTable dtl = new DataTable();
            dts.ReadXml(path);
            dtl = dts.Tables["khachhang"];
            if(dtl.Rows.Count > 0)
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
                    dataList.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("Khong co du lieu de hien thi", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in dataList.SelectedItems)
            {
                cbbChiNhanh.Text = item.SubItems[0].Text;
                txtMa.Text = item.SubItems[1].Text;
                txtTen.Text = item.SubItems[2].Text;
                txtDC.Text = item.SubItems[3].Text;
                txtSDT.Text = item.SubItems[4].Text;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_combo();
            hienthi();
        }
        private void them()
        {
            doc.Load(path);
            XmlAttribute chinhanh, makh;
            XmlElement khachhang, hoten, diachi, sodt;

            khachhang = doc.CreateElement("khachhang");
            hoten = doc.CreateElement("hoten");
            diachi = doc.CreateElement("diachi");
            sodt = doc.CreateElement("sodt");

            chinhanh = doc.CreateAttribute("chinhanh");
            makh = doc.CreateAttribute("makh");

            chinhanh.InnerText = cbbChiNhanh.Text;
            makh.InnerText = txtMa.Text;
            hoten.InnerText = txtTen.Text;
            diachi.InnerText = txtDC.Text;
            sodt.InnerText = txtSDT.Text;

            khachhang.SetAttributeNode(makh);
            khachhang.SetAttributeNode(chinhanh);

            khachhang.AppendChild(hoten);
            khachhang.AppendChild(diachi);
            khachhang.AppendChild(sodt);

            doc.DocumentElement.AppendChild(khachhang);

            doc.Save(path);
            MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void bt_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbbChiNhanh.Text == "" || txtMa.Text ==""||txtTen.Text==""||txtDC.Text==""||txtSDT.Text=="")
                {
                    MessageBox.Show("du lieu khong duoc de trong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    them();
                    hienthi();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("co loi khi them", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void sua()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/danhsachkhachhang/khachhang[@makh='" + txtMa.Text.Trim()+ "']");
            if(node!= null)
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
                MessageBox.Show("khach hang khong co trong csdl", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void bt_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMa.Text =="")
                {
                    MessageBox.Show("nhap ma khach hang muon sua", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    sua();
                    hienthi();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Co loi khi sua", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void xoa()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/danhsachkhachhang/khachhang[@makh='" + txtMa.Text.Trim() + "']");
            if(node != null)
            {
                doc.DocumentElement.RemoveChild(node);

                doc.Save(path);
                MessageBox.Show("Xoa thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("khach hang khong co trong csdl", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text == "")
                {
                    MessageBox.Show("nhap ma khach hang muon xoa", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    xoa();
                    hienthi();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Co loi khi xoa", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
