using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace api.Controllers
{
    public class SanPhamController : ApiController
    {
        // GET: SanPham
        [HttpGet]
        public List<SanPham> LayToanBoSanPham()
        {
            CSDLTestDataContext context = new CSDLTestDataContext();
            List<SanPham> dsSP = context.SanPhams.ToList();
            foreach (SanPham sp in dsSP)
                sp.DanhMuc = null;
            return dsSP;
        }
        [HttpGet]
        public List<SanPham> LayToanBoTheoMa(int madm)
        {
            CSDLTestDataContext db = new CSDLTestDataContext();
            List<SanPham> dsSP = db.SanPhams.Where(x => x.MaDanhMuc == madm).ToList(); ;
            foreach (SanPham sp in dsSP)
                sp.DanhMuc = null;
            return dsSP;
        }

        [HttpGet]
        public List<SanPham> LayToanBoTheoDoan(int a, int b)
        {
            CSDLTestDataContext db = new CSDLTestDataContext();
            List<SanPham> dsSP = db.SanPhams.Where(x => x.DonGia >= a && x.DonGia <= b).ToList(); ;
            foreach (SanPham sp in dsSP)
                sp.DanhMuc = null;
            return dsSP;
        }

    }
}