using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VyVanHung_2019601093_Bai8_Phieu3
{
   
    class DataUtil
    {
        private const string filename = "congty.xml";
        private XmlDocument doc;
        private XmlElement root;

        public DataUtil()
        {
            doc = new XmlDocument();
            if (!File.Exists(filename))
            {
                XmlElement congty = doc.CreateElement(NhanVien.ROOT);
                doc.AppendChild(congty);
                doc.Save(filename);
            }
            doc.Load(filename);
            root = doc.DocumentElement;
        }

        public void Them(NhanVien nhanVienMoi)
        {
            XmlElement nhanVien = doc.CreateElement(NhanVien.NHAN_VIEN);
            XmlElement hoten = doc.CreateElement(NhanVien.HO_TEN);
            XmlElement tuoi = doc.CreateElement(NhanVien.TUOI);
            XmlElement luong = doc.CreateElement(NhanVien.LUONG);
            XmlElement diachi = doc.CreateElement(NhanVien.DIA_CHI);
            XmlElement xa = doc.CreateElement(NhanVien.XA);
            XmlElement huyen = doc.CreateElement(NhanVien.HUYEN);
            XmlElement tinh = doc.CreateElement(NhanVien.TINH);
            XmlElement dienthoai = doc.CreateElement(NhanVien.DIEN_THOAI);

            nhanVien.SetAttribute(NhanVien.MA_NV, nhanVienMoi.maNV);
            hoten.InnerText = nhanVienMoi.ten;
            tuoi.InnerText = nhanVienMoi.tuoi.ToString();
            luong.InnerText = nhanVienMoi.luong.ToString();
           
            xa.InnerText = nhanVienMoi.xa;
            huyen.InnerText = nhanVienMoi.huyen;
            tinh.InnerText = nhanVienMoi.tinh;
            dienthoai.InnerText = nhanVienMoi.std;

            nhanVien.AppendChild(hoten);
            nhanVien.AppendChild(tuoi);
            nhanVien.AppendChild(luong);

            diachi.AppendChild(xa);
            diachi.AppendChild(huyen);
            diachi.AppendChild(tinh);

            nhanVien.AppendChild(diachi);
            nhanVien.AppendChild(dienthoai);

            root.AppendChild(nhanVien);
            doc.Save(filename);
        }

        public XmlNode findNodeByID(string manv)
        {
           
            XmlNodeList list = root.SelectNodes(NhanVien.NHAN_VIEN);
            foreach (XmlNode item in list)
            {
                if (item.Attributes[0].Value.Equals(manv))
                    return item;
            }
            return null;
        }

        public List<NhanVien> getAll()
        {
            List<NhanVien> nhanViens = new List<NhanVien>();
            XmlNodeList list = root.SelectNodes(NhanVien.NHAN_VIEN);
            foreach (XmlNode item in list)
            {
                XmlNode diachi = item.SelectSingleNode(NhanVien.DIA_CHI);
                NhanVien nhanVien = new NhanVien(item.Attributes[0].Value,
                    item.SelectSingleNode(NhanVien.HO_TEN).InnerText,
                    int.Parse(item.SelectSingleNode(NhanVien.TUOI).InnerText),
                    Double.Parse(item.SelectSingleNode(NhanVien.LUONG).InnerText),
                    diachi.SelectSingleNode(NhanVien.XA).InnerText,
                    diachi.SelectSingleNode(NhanVien.HUYEN).InnerText,
                    diachi.SelectSingleNode(NhanVien.TINH).InnerText,
                    item.SelectSingleNode(NhanVien.DIEN_THOAI).InnerText
                   );
                nhanViens.Add(nhanVien);
            }

            return nhanViens;
        }

        public bool Sua(NhanVien nhanVienMoi)
        {
            XmlNode old = findNodeByID(nhanVienMoi.maNV);
            if(old != null)
            {
                XmlElement nhanVien = doc.CreateElement(NhanVien.NHAN_VIEN);
                XmlElement hoten = doc.CreateElement(NhanVien.HO_TEN);
                XmlElement tuoi = doc.CreateElement(NhanVien.TUOI);
                XmlElement luong = doc.CreateElement(NhanVien.LUONG);
                XmlElement diachi = doc.CreateElement(NhanVien.DIA_CHI);
                XmlElement xa = doc.CreateElement(NhanVien.XA);
                XmlElement huyen = doc.CreateElement(NhanVien.HUYEN);
                XmlElement tinh = doc.CreateElement(NhanVien.TINH);
                XmlElement dienthoai = doc.CreateElement(NhanVien.DIEN_THOAI);

                nhanVien.SetAttribute(NhanVien.MA_NV, nhanVienMoi.maNV);
                hoten.InnerText = nhanVienMoi.ten;
                tuoi.InnerText = nhanVienMoi.tuoi.ToString();
                luong.InnerText = nhanVienMoi.luong.ToString();

                xa.InnerText = nhanVienMoi.xa;
                huyen.InnerText = nhanVienMoi.huyen;
                tinh.InnerText = nhanVienMoi.tinh;
                dienthoai.InnerText = nhanVienMoi.std;

                nhanVien.AppendChild(hoten);
                nhanVien.AppendChild(tuoi);
                nhanVien.AppendChild(luong);

                diachi.AppendChild(xa);
                diachi.AppendChild(huyen);
                diachi.AppendChild(tinh);

                nhanVien.AppendChild(diachi);
                nhanVien.AppendChild(dienthoai);

                root.ReplaceChild(nhanVien, old);
                doc.Save(filename);
                return true;
            }
            return false;
        }
        
        public bool Xoa(string manv)
        {
            XmlNode old = findNodeByID(manv);
            if (old != null)
            {
                root.RemoveChild(old);
            }
            return false;
        }
    }
}
