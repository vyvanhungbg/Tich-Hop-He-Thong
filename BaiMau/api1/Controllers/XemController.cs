using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace api1.Controllers
{
    public class XemController : ApiController
    {
        [HttpGet]
        public List<SanPham> LayToanBoSanPham()
        {
            CDSLTestDataContext context = new CDSLTestDataContext();
            List<SanPham> dsSP = context.SanPhams.ToList();
            foreach (SanPham sp in dsSP)
                sp.DanhMuc = null;
            return dsSP;
        }
        [HttpGet]
        public List<SanPham> LayToanBoTheoMa(int madm)
        {
            CDSLTestDataContext db = new CDSLTestDataContext();
            List<SanPham> dsSP = db.SanPhams.Where(x => x.MaDanhMuc == madm).ToList(); ;
            foreach (SanPham sp in dsSP)
                sp.DanhMuc = null;
            return dsSP;
        }

        [HttpGet]
        public List<SanPham> LayToanBoTheoDoan(int a, int b)
        {
            CDSLTestDataContext db = new CDSLTestDataContext();
            List<SanPham> dsSP = db.SanPhams.Where(x => x.DonGia >= a && x.DonGia <= b).ToList(); ;
            foreach (SanPham sp in dsSP)
                sp.DanhMuc = null;
            return dsSP;
        }
    }
}
