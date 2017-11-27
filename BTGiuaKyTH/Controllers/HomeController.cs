using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebClient.Models;

namespace BTGiuaKyTH.Controllers
{
    public class HomeController : ApiController
    {

        [HttpGet]
        [Route("dsnxs")]
        public IHttpActionResult DSNSX()
        {
            List<NSX> data = null;
            List<NSXUI> dt = new List<NSXUI>();
            using(var db = new DataDataContext())
            {
                db.DeferredLoadingEnabled = false;

                foreach (var item in db.NSXes.ToList())
                {
                    dt.Add(new NSXUI
                    {
                        Id = item.Id,
                        TenNSX = item.TenNSX
                    });
                }
               
            }
            return Ok(dt);
        }

        [HttpGet]
        [Route("DSSP/{MaNSX}")]
        public IHttpActionResult DSSPByMaSX(int MaNSX)
        {
            using (var db = new DataDataContext())
            {
                db.DeferredLoadingEnabled = false;
                return Ok(db.SanPhams.Where(x => x.IDLoaiSp == MaNSX).ToList<SanPham>());
            }
        }

        
    }
}
