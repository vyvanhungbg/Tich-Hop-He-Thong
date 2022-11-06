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

namespace Bai9
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
            cboMaSV.DataSource = dts.Tables["sinhvien"];
            cboMaSV.DisplayMember = "masv";
            cboMonHoc.DataSource = dts.Tables["sinhvien"];
            cboMonHoc.DisplayMember = "monhoc";
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
                    ListViewItem lvi = new ListViewItem((i+1).ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["masv"].ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["monhoc"].ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["diemlan1"].ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["diemlan2"].ToString());
                    i++;
                    listView1.Items.Add(lvi);
                }
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
                cboMaSV.Text = item.SubItems[1].Text;
                cboMonHoc.Text = item.SubItems[2].Text;
                txtDiemLan1.Text = item.SubItems[3].Text;
                txtDiemLan2.Text = item.SubItems[4].Text;
            }
        }
        private void them()
        {
            doc.Load(path);
            XmlAttribute masv, monhoc;
            XmlElement sinhvien, diemlan1, diemlan2;
            sinhvien = doc.CreateElement("sinhvien");
            masv = doc.CreateAttribute("masv");
            monhoc = doc.CreateAttribute("monhoc");
            diemlan1 = doc.CreateElement("diemlan1");
            diemlan2 = doc.CreateElement("diemlan2");
            masv.InnerText = cboMaSV.Text;
            monhoc.InnerText = cboMonHoc.Text;
            diemlan1.InnerText = txtDiemLan1.Text;
            diemlan2.InnerText = txtDiemLan2.Text;
            sinhvien.SetAttributeNode(masv);
            sinhvien.SetAttributeNode(monhoc);
            sinhvien.AppendChild(diemlan1);
            sinhvien.AppendChild(diemlan2);
            doc.DocumentElement.AppendChild(sinhvien);
            doc.Save(path);
            MessageBox.Show("Thêm kết quả học tập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void sua()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/bangdiem/sinhvien[@masv='" + (cboMaSV.Text).Trim() + "']");
            if(node != null)
            {
                node.Attributes[1].InnerText = cboMonHoc.Text;
                node.ChildNodes[0].InnerText = txtDiemLan1.Text;
                node.ChildNodes[1].InnerText = txtDiemLan2.Text;
                doc.Save(path);
                MessageBox.Show("Sửa kết quả học tập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa kết quả học tập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void xoa()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/bangdiem/sinhvien[@masv='" + (cboMaSV.Text).Trim() + "']");
            if (node != null)
            {
                doc.DocumentElement.RemoveChild(node);
                doc.Save(path);
                MessageBox.Show("Xoá kết quả học tập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xoá kết quả học tập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
