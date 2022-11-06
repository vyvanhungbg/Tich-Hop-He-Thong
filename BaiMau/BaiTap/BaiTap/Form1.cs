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

namespace BaiTap
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
            cboChiNhanh.DataSource = dts.Tables["cuocgoi"];
            cboChiNhanh.DisplayMember = "chinhanh";
            cboSoGoiDen.DataSource = dts.Tables["cuocgoi"];
            cboSoGoiDen.DisplayMember = "sodien";
        }
        private void hienthi()
        {
            listView1.Items.Clear();
            DataSet dts = new DataSet();
            DataTable dtl = new DataTable();
            dts.ReadXml(path);
            dtl = dts.Tables["cuocgoi"];
            if(dtl.Rows.Count > 0)
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
            foreach(ListViewItem item in listView1.SelectedItems)
            {
                cboChiNhanh.Text = item.SubItems[0].Text;
                cboSoGoiDen.Text = item.SubItems[1].Text;
                txtSoGoiDen.Text = item.SubItems[2].Text;
                txtNgayGoi.Text = item.SubItems[3].Text;
                txtSoPhut.Text = item.SubItems[4].Text;
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
            chinhanh.InnerText = cboChiNhanh.Text;
            sodien.InnerText = cboSoGoiDen.Text;
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
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void sua()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/thongtincuocgoi/cuocgoi[sogoiden='" + (txtSoGoiDen.Text).Trim() + "']");
            if (node != null)
            {
                node.Attributes[0].InnerText = cboSoGoiDen.Text;
                node.Attributes[1].InnerText = cboChiNhanh.Text;
                node.ChildNodes[1].InnerText = txtNgayGoi.Text;
                node.ChildNodes[2].InnerText = txtSoPhut.Text;
                doc.Save(path);
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Số gọi đến muốn sửa không có trong CSDL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void xoa()
        {
            doc.Load(path);
            XmlNode node = doc.SelectSingleNode("/thongtincuocgoi/cuocgoi[@sodien='" + (cboSoGoiDen.Text).Trim() + "']");
            if(node != null)
            {
                doc.DocumentElement.RemoveChild(node);
                doc.Save(path);
                MessageBox.Show("Xoá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Số gọi đến muốn xoá không có trong CSDL", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(cboChiNhanh.Text == "" || cboSoGoiDen.Text==""|txtSoGoiDen.Text==""| txtNgayGoi.Text == "" | txtSoPhut.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin muốn thêm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    them();
                    hienthi();
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! không thể thêm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoGoiDen.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin muốn sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    sua();
                    hienthi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! không thể sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSoGoiDen.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin muốn xoá!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    xoa();
                    hienthi();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra! không thể xoá.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Bạn có thực sự muốn thoát?", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if(a == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
