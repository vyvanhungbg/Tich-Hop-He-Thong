using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VyVanHung_2019601093_Bai7_Phieu1
{
    class TaiKhoan
    {
        public string soTaiKhoan { get; set; }
        public string tenTaiKhoan { get; set; }
        public string diaChi { get; set; }
        public string dienThoai { get; set; }
        public double soTien { get; set; }


        public const string ROOT_NAME = "nganhang";
        public const string TAI_KHOAN = "taikhoan";
        public const string SO_TAI_KHOAN = "sotaikhoan";
        public const string TEN_TAI_KHOAN = "tentaikhoan";
        public const string DIA_CHI = "diachi";
        public const string DIEN_THOAI = "dienthoai";
        public const string SO_TIEN = "sotien";

        public TaiKhoan(string soTaiKhoan, string tenTaiKhoan, string diaChi, string dienThoai, double soTien)
        {
            this.soTaiKhoan = soTaiKhoan;
            this.tenTaiKhoan = tenTaiKhoan;
            this.diaChi = diaChi;
            this.dienThoai = dienThoai;
            this.soTien = soTien;
        }

        public TaiKhoan()
        {
        }
    }
}
