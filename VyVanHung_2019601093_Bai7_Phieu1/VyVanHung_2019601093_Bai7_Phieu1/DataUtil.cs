using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VyVanHung_2019601093_Bai7_Phieu1
{
    class DataUtil
    {
        private const string filename = "NganHang.xml";
        private XmlDocument doc;
        private XmlElement root;

        public DataUtil()
        {
            this.doc = new XmlDocument();
            if (!File.Exists(filename))
            {
                XmlElement nganHang = doc.CreateElement(TaiKhoan.ROOT_NAME);
                doc.AppendChild(nganHang);
                doc.Save(filename);
            }
            doc.Load(filename);
            root = doc.DocumentElement;
        }

        public void ThemTaiKhoan(TaiKhoan taiKhoanMoi)
        {
            
            root.AppendChild(createNewNode(taiKhoanMoi));
            doc.Save(filename);
        }

        private XmlElement createNewNode(TaiKhoan taiKhoanMoi)
        {
            XmlElement taikhoan = doc.CreateElement(TaiKhoan.TAI_KHOAN);
            XmlElement soTaiKhoan = doc.CreateElement(TaiKhoan.SO_TAI_KHOAN);
            XmlElement tenTaiKhoan = doc.CreateElement(TaiKhoan.TEN_TAI_KHOAN);
            XmlElement diaChi = doc.CreateElement(TaiKhoan.DIA_CHI);
            XmlElement dienthoai = doc.CreateElement(TaiKhoan.DIEN_THOAI);
            XmlElement soTien = doc.CreateElement(TaiKhoan.SO_TIEN);

            soTaiKhoan.InnerText = taiKhoanMoi.soTaiKhoan;
            tenTaiKhoan.InnerText = taiKhoanMoi.tenTaiKhoan;
            dienthoai.InnerText = taiKhoanMoi.dienThoai;
            diaChi.InnerText = taiKhoanMoi.diaChi;
            soTien.InnerText = taiKhoanMoi.soTien.ToString();

            taikhoan.AppendChild(soTaiKhoan);
            taikhoan.AppendChild(tenTaiKhoan);
            taikhoan.AppendChild(diaChi);
            taikhoan.AppendChild(dienthoai);
            taikhoan.AppendChild(soTien);

            return taikhoan;
        }

        public List<TaiKhoan> getAll()
        {
            List<TaiKhoan> taiKhoans = new List<TaiKhoan>();

            XmlNodeList nodes = root.SelectNodes(TaiKhoan.TAI_KHOAN);
            foreach (XmlNode item in nodes)
            {
                TaiKhoan taiKhoan = new TaiKhoan(
                    item.SelectSingleNode(TaiKhoan.SO_TAI_KHOAN).InnerText,
                    item.SelectSingleNode(TaiKhoan.TEN_TAI_KHOAN).InnerText,
                    item.SelectSingleNode(TaiKhoan.DIA_CHI).InnerText,
                    item.SelectSingleNode(TaiKhoan.DIEN_THOAI).InnerText,
                    Double.Parse(item.SelectSingleNode(TaiKhoan.SO_TIEN).InnerText));
                taiKhoans.Add(taiKhoan);
            }

            return taiKhoans;
        }

        public XmlNode findNodeByID(string stk)
        {
            XmlNodeList nodes = root.SelectNodes(TaiKhoan.TAI_KHOAN);
            foreach (XmlNode item in nodes)
            {
                if (item.SelectSingleNode(TaiKhoan.SO_TAI_KHOAN).InnerText.Equals(stk))
                {
                    return item;
                }
            }
            return null;
        }

        public TaiKhoan findTaiKhoanByID(string stk)
        {
            XmlNode node = findNodeByID(stk);
            if(node != null)
            {
                TaiKhoan taiKhoan = new TaiKhoan(
                    node.SelectSingleNode(TaiKhoan.SO_TAI_KHOAN).InnerText,
                    node.SelectSingleNode(TaiKhoan.TEN_TAI_KHOAN).InnerText,
                    node.SelectSingleNode(TaiKhoan.DIA_CHI).InnerText,
                    node.SelectSingleNode(TaiKhoan.DIEN_THOAI).InnerText,
                    Double.Parse(node.SelectSingleNode(TaiKhoan.SO_TIEN).InnerText));
                return taiKhoan;
            }
            return null;
        }

        public bool Update(TaiKhoan taiKhoanMoi)
        {
            XmlNode node = findNodeByID(taiKhoanMoi.soTaiKhoan);
            if (node != null)
            {
                XmlNode newNode = createNewNode(taiKhoanMoi);
                root.ReplaceChild(newNode, node);
                doc.Save(filename);
                return true;
            }
            return false;
        }

        public bool Delete(string stk)
        {
            XmlNode node = findNodeByID(stk);
            if (node != null)
            {
                root.RemoveChild(node);
                doc.Save(filename);
                return true;
            }
            return false;
        }
    }
}
