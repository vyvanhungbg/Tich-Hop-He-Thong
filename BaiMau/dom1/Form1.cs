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

namespace dom1
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
            cbbMa.DataSource = dts.Tables["sinhvien"];
            cbbMa.DisplayMember = "masv";
            cbbMon.DataSource = dts.Tables["sinhvien"];
            cbbMon.DisplayMember = "monhoc";
        }
        private void hienthi()
        {
            dataList.Items.Clear();
            DataSet dts = new DataSet();
            DataTable dtl = new DataTable();
            dts.ReadXml(path);
            dtl = dts.Tables["sinhvien"];
            if(dtl.Rows.Count > 0)
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
                    dataList.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để hiển thị!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                cbbMa.Text = item.SubItems[1].Text;
                cbbMon.Text = item.SubItems[2].Text;
                txtDiem1.Text = item.SubItems[3].Text;
                txtDiem2.Text = item.SubItems[4].Text;
            }
        }
        private void them()
        {
            doc.Load(path);
            XmlElement sinhvien, diemlan1, diemlan2;
            XmlAttribute masv, monhoc;
            sinhvien = doc.CreateElement("sinhvien");
            diemlan1 = doc.CreateElement("diemlan1");
            diemlan2 = doc.CreateElement("diemlan2");
            masv = doc.CreateAttribute("masv");
            monhoc = doc.CreateAttribute("monhoc");

            masv.InnerText = cbbMa.Text;
            monhoc.InnerText = cbbMon.Text;
            diemlan1.InnerText = txtDiem1.Text;
            diemlan2.InnerText = txtDiem2.Text;
            sinhvien.SetAttributeNode(masv);
            sinhvien.SetAttributeNode(monhoc);
            sinhvien.AppendChild(diemlan1);
            sinhvien.AppendChild(diemlan2);
            doc.DocumentElement.AppendChild(sinhvien);
            doc.Save(path);
            MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbbMa.Text == ""|| cbbMon.Text == "" || txtDiem1.Text==""||txtDiem2.Text=="")
                {
                    MessageBox.Show("Thong tin khong duoc de trong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    them();
                    hienthi();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Co loi xay ra, khong the them", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void sua()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/bangdiem/sinhvien[@masv='" + cbbMa.Text.Trim() + "']");
            if (node != null)
            {
                node.Attributes[1].InnerText = cbbMon.Text;

                node.ChildNodes[0].InnerText = txtDiem1.Text;
                node.ChildNodes[1].InnerText = txtDiem2.Text;
                doc.Save(path);
                MessageBox.Show("Sua thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Co loi xay ra", "thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Button_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbbMa.Text == "")
                {
                    MessageBox.Show("Sinh vien khong ton tai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);  
                }
                else
                {
                    sua();
                    hienthi();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Co loi xay ra, khong the sua", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void xoa()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/bangdiem/sinhvien[masv='" + cbbMa.Text.Trim() + "']");
            if(node != null)
            {
                doc.DocumentElement.RemoveChild(node);

                doc.Save(path);
                MessageBox.Show("Xoa thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Co loi xay ra", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbbMa.Text == "")
                {
                    MessageBox.Show("Sinh vien khong ton tai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void Button_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
