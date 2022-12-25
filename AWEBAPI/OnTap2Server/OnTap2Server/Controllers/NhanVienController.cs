using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace OnTap2Server.Controllers
{
    public class NhanVienController : ApiController
    {
        private DataUtil db = new DataUtil();
        [HttpGet]
        public List<NhanVien> getAll()
        {
            return db.NhanViens.ToList();
        }

        [HttpGet]
        public NhanVien getByID(int id)
        {
            return db.NhanViens.FirstOrDefault(x => x.MaNV == id);
        }

        [HttpPost]
        public string insert(NhanVien nhanVien)
        {
            try
            {
                db.NhanViens.Add(nhanVien);
                db.SaveChanges();
                return "Thêm thành công";
            }catch(Exception ex)
            {
                return "Thêm thất bại";
            }
            
         
        }

        [HttpPut]
        public string update(NhanVien nhanVien)
        {
            try
            {
                NhanVien old = db.NhanViens.FirstOrDefault(x => x.MaNV == nhanVien.MaNV);
                if(old != null)
                {
                    old.TenNV = nhanVien.TenNV;
                    old.HSLuong = nhanVien.HSLuong;
                    db.SaveChanges();
                    return "Cập nhật thành công !";
                }
                else
                {
                    return "Cập nhật thất bại !. Không tìm thấy nhân viên với mã id = " + nhanVien.MaNV;
                }
            }catch(Exception ex)
            {

                return "Cập nhật thất bại !";
            }
        }

        [HttpDelete]
        public string delete(int id)
        {
            try
            {
                NhanVien old = db.NhanViens.FirstOrDefault(x => x.MaNV == id);
                if (old != null)
                {
                    db.NhanViens.Remove(old);
                    db.SaveChanges();
                    return "Xóa thành công !";
                }
                else
                {
                    return "Xóa thất bại !. Không tìm thấy nhân viên với mã id = " + id;
                }
            }
            catch (Exception ex)
            {

                return "Xóa thất bại !";
            }
        }
    }
}
