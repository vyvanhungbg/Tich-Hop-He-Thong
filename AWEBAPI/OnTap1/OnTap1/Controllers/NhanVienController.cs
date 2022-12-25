using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using OnTap1.Models;
namespace OnTap1.Controllers
{
    public class NhanVienController : ApiController
    {
        private static DBUtil db = new DBUtil();

        [HttpGet]
        public IEnumerable<NhanVien> getAll()
        {
            return db.NhanViens;
        }

        [HttpGet]
        public NhanVien getByID(int id)
        {
            return db.NhanViens.FirstOrDefault(x => x.MaNV == id);
        }

        [HttpPost]
        public NhanVien insert(NhanVien nhanVien)
        {
            NhanVien newNhanVien = db.NhanViens.Add(nhanVien);
            db.SaveChanges();
            return newNhanVien;
        }

        [HttpDelete]
        public NhanVien delete(int id)
        {
            NhanVien nhanVien = db.NhanViens.FirstOrDefault(x => x.MaNV == id);
            if (nhanVien != null)
            {
                db.NhanViens.Remove(nhanVien);
                db.SaveChanges();
                return nhanVien;
            }
            return null;
        }

        [HttpPut]
        public NhanVien update(NhanVien newnhanVien)
        {
            NhanVien nhanVien = db.NhanViens.FirstOrDefault(x => x.MaNV == newnhanVien.MaNV);
            if (nhanVien != null)
            {
                nhanVien.TenNV = newnhanVien.TenNV;
                nhanVien.HSLuong = newnhanVien.HSLuong;
                db.SaveChanges();
                return nhanVien;
            }
            return null;
        }

    }
}
