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

namespace Buoi9
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        public static string path = "C:\\Users\\Nguyen Duy\\Desktop\\DOM\\BaiTap\\Buoi9\\XMLFile1.xml";
        public Form1()
        {
            InitializeComponent();
        }

        private void load_combobox()
        {
            DataSet dts = new DataSet();
            dts.ReadXml(path);
            maSV_cbb.DataSource = dts.Tables["sinhvien"];
            maSV_cbb.DisplayMember = "masv";
            monhoc_cbb.DataSource = dts.Tables["sinhvien"];
            monhoc_cbb.DisplayMember = "monhoc";
        }

        private void hienthi()
        {
            listView1.Items.Clear();
            DataSet dts = new DataSet();
            DataTable dtl = new DataTable();
            dts.ReadXml(path);
            dtl = dts.Tables["sinhvien"];
            if (dtl.Rows.Count > 0)
            {
                int i = 0;
                foreach(DataRow dr in dtl.Rows)
                {
                    ListViewItem lvi = new ListViewItem((i + 1).ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["masv"].ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["monhoc"].ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["diemlan1"].ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["diemlan2"].ToString());
                    i++;
                    listView1.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiện thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_combobox();
            hienthi();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                maSV_cbb.Text = item.SubItems[1].Text;
                monhoc_cbb.Text = item.SubItems[2].Text;
                lan1_txt.Text = item.SubItems[3].Text;
                lan2_txt.Text = item.SubItems[4].Text;
            }
        }
        private void them()
        {
            doc.Load(path);
            XmlElement sinhvien, diemlan1, diemlan2;
            XmlAttribute masv, monhoc;
            sinhvien = doc.CreateElement("sinhvien");
            masv = doc.CreateAttribute("masv");
            monhoc = doc.CreateAttribute("monhoc");
            diemlan1 = doc.CreateElement("diemlan1");
            diemlan2 = doc.CreateElement("diemlan2");
            masv.InnerText = maSV_cbb.Text;
            monhoc.InnerText = monhoc_cbb.Text;
            diemlan1.InnerText = lan1_txt.Text;
            diemlan2.InnerText = lan2_txt.Text;
            sinhvien.SetAttributeNode(masv);
            sinhvien.SetAttributeNode(monhoc);
            sinhvien.AppendChild(diemlan1);
            sinhvien.AppendChild(diemlan2);
            doc.DocumentElement.AppendChild(sinhvien);
            doc.Save(path);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void sua()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/bangdiem/sinhvien['" + (maSV_cbb.Text).Trim() + "']");
            if (node != null)
            {
                node.ChildNodes[0].InnerText = lan1_txt.Text;
                node.ChildNodes[1].InnerText = lan2_txt.Text;
                doc.Save(path);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void xoa()
        {
            doc.LoadXml(path);
            XmlNode node = doc.SelectSingleNode("/bangdiem/sinhvien[@masv='" + (maSV_cbb.Text).Trim() + "']");
            if (node != null)
            {
                doc.DocumentElement.RemoveChild(node);
                doc.Save(path);
                MessageBox.Show("Xoá thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("xoá thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
