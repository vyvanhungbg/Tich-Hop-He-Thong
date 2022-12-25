namespace OnTap2Cilent
{
    public class NhanVien
    {
        public int MaNV { get; set; }
        public string TenNV { get; set; }
        public float HSLuong { get; set; }

        public NhanVien()
        {
        }

        public NhanVien(int maNV, string tenNV, float hSLuong)
        {
            MaNV = maNV;
            TenNV = tenNV;
            HSLuong = hSLuong;
        }

        public NhanVien(string tenNV, float hSLuong)
        {
            TenNV = tenNV;
            HSLuong = hSLuong;
        }
    }
}