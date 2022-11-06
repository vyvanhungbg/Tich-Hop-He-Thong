using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace VyVanHung_2019601093
{
    class DataUtil
    {
        private const string filename = "danhsachsach.xml";
        private XmlDocument doc;
        private XmlElement root;

        public DataUtil()
        {
            this.doc = new XmlDocument();
            if (!File.Exists(filename))
            {
                XmlElement danhsachsach = doc.CreateElement(Sach.ROOT);
                doc.AppendChild(danhsachsach);
                doc.Save(filename);
            }

            doc.Load(filename);
            root = doc.DocumentElement;
        }

        public void ThemSach(Sach sachMoi)
        {
            XmlElement sach = doc.CreateElement(Sach.SACH);
            XmlElement tenSach = doc.CreateElement(Sach.TEN_SACH);
            XmlElement giaBan = doc.CreateElement(Sach.GIA_BAN);
            XmlElement tacGia = doc.CreateElement(Sach.TAC_GIA);

            sach.SetAttribute(Sach.MA_SACH, sachMoi.maSach);
            sach.SetAttribute(Sach.NHA_XB, sachMoi.nhaXuatBan);
            tenSach.InnerText = sachMoi.tenSach;
            giaBan.InnerText = sachMoi.giaBan.ToString();
            tacGia.InnerText = sachMoi.tacGia;

            sach.AppendChild(tenSach);
            sach.AppendChild(giaBan);
            sach.AppendChild(tacGia);

            root.AppendChild(sach);
            doc.Save(filename);
        }


        public List<Sach> getAll()
        {
            List<Sach> dsSach = new List<Sach>();

            XmlNodeList list = root.SelectNodes(Sach.SACH);

            foreach (XmlNode item in list)
            {
                Sach sach = new Sach(
                    item.Attributes[0].Value,     
                    item.Attributes[1].Value,
                    item.SelectSingleNode(Sach.TEN_SACH).InnerText,
                   Double.Parse(item.SelectSingleNode(Sach.GIA_BAN).InnerText),
                    item.SelectSingleNode(Sach.TAC_GIA).InnerText
                    
               );
                dsSach.Add(sach);
            }

            return dsSach;
        }

        public XmlNode findNodeByID(string masach)
        {
            XmlNodeList list = root.SelectNodes(Sach.SACH);
            foreach (XmlNode item in list)
            {
                if (item.Attributes[0].Value.Equals(masach))
                    return item;
            }
            return null;
        }

        public bool Sua(Sach sachMoi)
        {
            XmlNode old = findNodeByID(sachMoi.maSach);
            if(old != null)
            {

                XmlElement sach = doc.CreateElement(Sach.SACH);
                XmlElement tenSach = doc.CreateElement(Sach.TEN_SACH);
                XmlElement giaBan = doc.CreateElement(Sach.GIA_BAN);
                XmlElement tacGia = doc.CreateElement(Sach.TAC_GIA);

                sach.SetAttribute(Sach.MA_SACH, sachMoi.maSach);
                sach.SetAttribute(Sach.NHA_XB, sachMoi.nhaXuatBan);
                tenSach.InnerText = sachMoi.tenSach;
                giaBan.InnerText = sachMoi.giaBan.ToString();
                tacGia.InnerText = sachMoi.tacGia;

                sach.AppendChild(tenSach);
                sach.AppendChild(giaBan);
                sach.AppendChild(tacGia);

                root.ReplaceChild(sach, old);
                doc.Save(filename);
                return true;
            }
            return false;
        }

        public bool Xoa(string mas)
        {
            XmlNode old = findNodeByID(mas);
            if (old != null)
            {
                root.RemoveChild(old);
                doc.Save(filename);
                return true;
            }
                return false;
        }
    }
}
