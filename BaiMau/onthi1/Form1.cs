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

namespace onthi1
{
    public partial class Form1 : Form
    {
        XmlDocument doc = new XmlDocument();
        public static string path = "../../../thongtincuocgoi.xml";
        public Form1()
        {
            InitializeComponent();
        }
        private void load_combo()
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
            if(dtl.Rows.Count > 0)
            {
                int i = 0;
                foreach(DataRow dr in dtl.Rows)
                {
                    ListViewItem lvi = new ListViewItem((i+1).ToString());
                    lvi.SubItems.Add(dtl.Rows[i]["chinhanh"].ToString());
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
                cbbChiNhanh.Text = item.SubItems[1].Text;
                cbbSoGoiDi.Text = item.SubItems[2].Text;
                txtSoGoiDen.Text = item.SubItems[3].Text;
                txtNgayGoi.Text = item.SubItems[4].Text;
                txtSoPhut.Text = item.SubItems[5].Text;
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

            cuocgoi.SetAttributeNode(sodien);
            cuocgoi.SetAttributeNode(chinhanh);
            cuocgoi.AppendChild(sogoiden);
            cuocgoi.AppendChild(ngaygoi);
            cuocgoi.AppendChild(sophut);

            doc.DocumentElement.AppendChild(cuocgoi);
            doc.Save(path);
            MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sua()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/thongtincuocgoi/cuocgoi[sogoiden='" + txtSoGoiDen.Text.Trim() + "']");
            if(node != null)
            {
                node.Attributes[0].InnerText = cbbSoGoiDi.Text;
                node.Attributes[1].InnerText = cbbChiNhanh.Text;

                node.ChildNodes[1].InnerText = txtNgayGoi.Text;
                node.ChildNodes[2].InnerText = txtSoPhut.Text;

                doc.Save(path);
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Số gọi đến không có trong csdl", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void xoa()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/thongtincuocgoi/cuocgoi[sogoiden='" + txtSoGoiDen.Text.Trim() + "']");
            if(node != null)
            {
                doc.DocumentElement.RemoveChild(node);

                doc.Save(path);
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Số gọi đến không có trong csdl", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbbChiNhanh.Text == "" || cbbSoGoiDi.Text == "" || txtNgayGoi.Text == "" || txtSoGoiDen.Text == "" || txtSoPhut.Text == "")
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
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoGoiDen.Text == "")
                {
                    MessageBox.Show("Nhap so goi den muon sua", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    sua();
                    hienthi();
                }
            }
            catch(Exception)
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoGoiDen.Text == "")
                {
                    MessageBox.Show("Nhap so goi den muon xoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    xoa();
                    hienthi();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Có lỗi xảy ra", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
