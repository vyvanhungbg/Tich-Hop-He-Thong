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

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        public static string path = "../../../XMLFile1.xml";
        public Form1()
        {
            InitializeComponent();
        }
        private void load_combobox()
        {
            DataSet dts = new DataSet();
            dts.ReadXml(path);
            cbbChiNhanh.DataSource = dts.Tables["cuocgoi"];
            cbbChiNhanh.DisplayMember = "chinhanh";
            cbbSoGoiDi.DataSource = dts.Tables["cuocgoi"];
            cbbSoGoiDi.DisplayMember = "sodien";
        }
        private void hienthi()
        {
            dataList.Items.Clear();
            DataSet dts = new DataSet();
            DataTable dtl = new DataTable();
            dts.ReadXml(path);
            dtl = dts.Tables["cuocgoi"];
            if (dtl.Rows.Count > 0)
            {
                int i = 0;
                foreach(DataRow dr in dtl.Rows)
                {
                    ListViewItem lvi = new ListViewItem(dtl.Rows[i]["chinhanh"].ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["sodien"].ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["sogoiden"].ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["ngaygoi"].ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["sophut"].ToString());
                    i++;
                    dataList.Items.Add(lvi);
                }
            }
            else
            {
                MessageBox.Show("Khong co du lieu de hien thi", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            load_combobox();
            hienthi();
        }

        private void dataList_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem item in dataList.SelectedItems)
            {
                cbbChiNhanh.Text = item.SubItems[0].Text;
                cbbSoGoiDi.Text = item.SubItems[1].Text;
                txtSoGoiDen.Text = item.SubItems[2].Text;
                txtNgayGoi.Text = item.SubItems[3].Text; 
                txtSoPhut.Text= item.SubItems[4].Text;
            }
        }
        private void them()
        {
            doc.Load(path);
            XmlElement cuocgoi, sogoiden, ngaygoi, sophut;
            XmlAttribute chinhanh, sodien;
            cuocgoi = doc.CreateElement("cuocgoi");
            chinhanh = doc.CreateAttribute("chinhanh");
            sodien = doc.CreateAttribute("sodien");
            sogoiden = doc.CreateElement("sogoiden");
            ngaygoi = doc.CreateElement("ngaygoi");
            sophut = doc.CreateElement("sophut");
            chinhanh.InnerText = cbbChiNhanh.Text;
            sodien.InnerText = cbbSoGoiDi.Text;
            sogoiden.InnerText = txtSoGoiDen.Text;
            ngaygoi.InnerText = txtNgayGoi.Text;
            sophut.InnerText = txtSoPhut.Text;
            cuocgoi.SetAttributeNode(chinhanh);
            cuocgoi.SetAttributeNode(sodien);
            cuocgoi.AppendChild(sogoiden);
            cuocgoi.AppendChild(ngaygoi);
            cuocgoi.AppendChild(sophut);
            doc.DocumentElement.AppendChild(cuocgoi);
            doc.Save(path);
            MessageBox.Show("Them thanh cong", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void sua()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/thongtincuocgoi/cuocgoi[sogoiden='" + (txtSoGoiDen.Text).Trim() + "']");
            if(node != null)
            {
                node.Attributes[0].InnerText = cbbSoGoiDi.Text;
                node.Attributes[1].InnerText = cbbChiNhanh.Text;
                node.ChildNodes[1].InnerText = txtNgayGoi.Text;
                node.ChildNodes[2].InnerText = txtSoPhut.Text;

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
            XmlNode node = doc.SelectSingleNode("/thongtincuocgoi/cuocgoi[sogoiden='" + (txtSoGoiDen.Text).Trim() + "']");
            if(node != null)
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
        private void them_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbbChiNhanh.Text == "" || cbbSoGoiDi.Text == "" || txtSoGoiDen.Text == "" || txtNgayGoi.Text == "" || txtSoPhut.Text == "")
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

        private void btn_sua_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtSoGoiDen.Text == "")
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

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoGoiDen.Text == "")
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

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Ban co that su muon thoat ?", "Thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(a==DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
