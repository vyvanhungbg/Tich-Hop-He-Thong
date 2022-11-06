using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyVanHung_2019601093_Bai8_Phieu3
{
    class NhanVien
    {
        public string  maNV { get; set; }
        public string  ten { get; set; }
        public int  tuoi { get; set; }
        public double  luong { get; set; }
        public string  xa { get; set; }
        public string  huyen { get; set; }
        public string  tinh{ get; set; }
        public string  std{ get; set; }


        public const string MA_NV = "manv";
        public const string HO_TEN = "hoten";
        public const string TUOI = "tuoi";
        public const string LUONG = "luong";
        public const string DIA_CHI = "diachi";
        public const string XA = "xa";
        public const string HUYEN = "huyen";
        public const string TINH = "tinh";
        public const string DIEN_THOAI = "dienthoai";
        public const string NHAN_VIEN = "nhanvien";
        public const string ROOT = "congty";

        public NhanVien(string maNV, string ten, int tuoi, double luong, string xa, string huyen, string tinh, string std)
        {
            this.maNV = maNV;
            this.ten = ten;
            this.tuoi = tuoi;
            this.luong = luong;
            this.xa = xa;
            this.huyen = huyen;
            this.tinh = tinh;
            this.std = std;
        }

        public NhanVien()
        {
        }
    }
}
