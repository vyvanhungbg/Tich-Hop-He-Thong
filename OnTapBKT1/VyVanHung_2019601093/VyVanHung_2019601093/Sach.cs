using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyVanHung_2019601093
{
    class Sach
    {
        public string maSach { get; set; }
        public string nhaXuatBan { get; set; }
        public string tenSach { get; set; }
        public double giaBan { get; set; }
        public string tacGia{ get; set; }


        public const string ROOT = "danhsachsach";
        public const string SACH = "sach";
        public const string MA_SACH = "mas";
        public const string NHA_XB = "nhaxb";
        public const string TEN_SACH = "tensach";
        public const string GIA_BAN = "giaban";
        public const string TAC_GIA = "tacgia";

        public Sach(string maSach, string nhaXuatBan, string tenSach, double giaBan, string tacGia)
        {
            this.maSach = maSach;
            this.nhaXuatBan = nhaXuatBan;
            this.tenSach = tenSach;
            this.giaBan = giaBan;
            this.tacGia = tacGia;
        }

        public Sach()
        {
        }
    }
}
