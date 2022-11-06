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

namespace onthi2
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        public static string path = "../../../xml.xml";
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
            if (dtl.Rows.Count > 0)
            {
                int i = 0;
                foreach(DataRow dr in dtl.Rows)
                {
                    ListViewItem lvi = new ListViewItem(dtl.Rows[i]["chinhanh"].ToString());
                    lvi.SubItems.Add(dr["makh"].ToString());
                    lvi.SubItems.Add(dr["hoten"].ToString());
                    lvi.SubItems.Add(dr["diachi"].ToString());
                    lvi.SubItems.Add(dr["sodt"].ToString());

                    i++;
                    dataList.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            load_combo();
            hienthi();
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
        private void them()
        {
            XmlNode node = doc.SelectSingleNode("/danhsachkhachhang/khachhang[@makh='" + txtMa.Text.Trim() + "']");
            if(node != null)
            {
                MessageBox.Show("Mã khách hàng đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                doc.Load(path);
                XmlElement khachhang, hoten, diachi, sodt;
                XmlAttribute chinhanh, makh;

                khachhang = doc.CreateElement("khachhang");
                hoten = doc.CreateElement("hoten");
                diachi = doc.CreateElement("diachi");
                sodt = doc.CreateElement("sodt");

                chinhanh = doc.CreateAttribute("chinhanh");
                makh = doc.CreateAttribute("makh");

                chinhanh.InnerText = cbbChiNhanh.Text;
                makh.InnerText = txtMa.Text;
                hoten.InnerText = txtTen.Text;
                diachi.InnerText = txtMa.Text;
                sodt.InnerText = txtSDT.Text;

                khachhang.SetAttributeNode(makh);
                khachhang.SetAttributeNode(chinhanh);
                khachhang.AppendChild(hoten);
                khachhang.AppendChild(diachi);
                khachhang.AppendChild(sodt);

                doc.DocumentElement.AppendChild(khachhang);
                doc.Save(path);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }
        private void sua()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/danhsachkhachhang/khachhang[@makh='" + txtMa.Text.Trim() + "']");
            if(node != null)
            {
                node.Attributes[1].InnerText = cbbChiNhanh.Text;

                node.ChildNodes[0].InnerText = txtTen.Text;
                node.ChildNodes[1].InnerText = txtDC.Text;
                node.ChildNodes[2].InnerText = txtSDT.Text;

                doc.Save(path);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có khách hàng trong csdl", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có khách hàng trong csdl", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbbChiNhanh.Text == "" || txtMa.Text == "" || txtTen.Text == "" || txtDC.Text == "" ||txtSDT.Text == "")
                {
                    MessageBox.Show("Dữ liệu không được để trống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    them();
                    hienthi();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Có lỗi, không thể thêm", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMa.Text == "")
                {
                    MessageBox.Show("Nhập mã khách hàng cần sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    sua();
                    hienthi();
                }    
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi, không thể sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text == "")
                {
                    MessageBox.Show("Nhập mã khách hàng cần xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    xoa();
                    hienthi();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
