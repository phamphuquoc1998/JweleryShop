using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.EF;
using WebApplication1.Entities;
using WebApplication2.Models;
using PagedList;
using X.PagedList;
using WebApplication2.Models.Entities;
using WebApplication2.Helper_và_session;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        JweleryDbcontext dataContext;
        public HomeController(JweleryDbcontext dataContext)
        {
            this.dataContext = dataContext;
        }
        public IActionResult Index(int? page)
        {
            if (page == null) page = 1;
            var links = (from l in dataContext.Sanphams
                         select l).OrderBy(x => x.MaLSP);
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            
            if (cart == null)
            {
                ViewBag.sl = 0;
            }
            else
            {
                ViewBag.sl = cart.Count;
            }
            return View(links.ToPagedList(pageNumber, pageSize));

            //List<Sanpham> sanphams = dataContext.Sanphams.ToList();


            //return View(sanphams);

        }

        public IActionResult ProductList(int? page)
        {
            if (page == null) page = 1;
            var links = (from l in dataContext.Sanphams
                         select l).OrderBy(x => x.MaLSP);
            int pageSize = 12;
            int pageNumber = (page ?? 1);
            List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");

            if (cart == null)
            {
                ViewBag.sl = 0;
            }
            else
            {
                ViewBag.sl = cart.Count;
            }
            return View(links.ToPagedList(pageNumber, pageSize));

            //List<Sanpham> sanphams = dataContext.Sanphams.ToList();


            //return View(sanphams);

        }
        [HttpGet]
        public async Task<IActionResult> timsanpham(string searchString)
        {

            var dssanpham = from m in dataContext.Sanphams
                         select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                dssanpham = dssanpham.Where(s => s.TenSP.Contains(searchString));
            }
            ViewBag.tentim = searchString;
            return View(await dssanpham.ToListAsync());


            //var dssanpham = dataContext.Sanphams.Where(c => c.TenSP == searchString);
            //ViewBag.Tensp= searchString;
            //return View(dssanpham.ToList());
        }


        [HttpGet]
        public async Task<IActionResult> timloaisp(string masearch)
        {

            var dssanpham = from m in dataContext.Sanphams
                            select m;

            if (!String.IsNullOrEmpty(masearch))
            {
                dssanpham = dssanpham.Where(s => s.MaLSP.Contains(masearch));
            }
            ViewBag.tentim = masearch;
            return View(await dssanpham.ToListAsync());
        }


        [HttpGet]
        public async Task<IActionResult> sortbyBracw()
        {
            string maBrace = "Ma1";
            var dssanpham = from m in dataContext.Sanphams
                            select m;

            if (!String.IsNullOrEmpty(maBrace))
            {
                dssanpham = dssanpham.Where(s => s.MaLSP.Contains(maBrace));
            }
            ViewBag.tentim = maBrace;
            return View(await dssanpham.ToListAsync());
        }


        [HttpGet]
        public async Task<IActionResult> sortbyEar()
        {
            string maBrace = "Ma2";
            var dssanpham = from m in dataContext.Sanphams
                            select m;

            if (!String.IsNullOrEmpty(maBrace))
            {
                dssanpham = dssanpham.Where(s => s.MaLSP.Contains(maBrace));
            }
            ViewBag.tentim = maBrace;
            return View(await dssanpham.ToListAsync());
        }


        [HttpGet]
        public async Task<IActionResult> sortbyNeck()
        {
            string maBrace = "Ma3";
            var dssanpham = from m in dataContext.Sanphams
                            select m;

            if (!String.IsNullOrEmpty(maBrace))
            {
                dssanpham = dssanpham.Where(s => s.MaLSP.Contains(maBrace));
            }
            ViewBag.tentim = maBrace;
            return View(await dssanpham.ToListAsync());
        }
        [HttpGet]
        public async Task<IActionResult> timgia(string searchString)
        {
            var dssanpham = from m in dataContext.Sanphams
                            select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                dssanpham = dssanpham.Where(s => s.DonGia<=Convert.ToInt32(searchString));
            }
            ViewBag.tentim = searchString;
            return View(await dssanpham.ToListAsync());
        }
        public IActionResult gioithieu()
        {
            return View();
        }
    }
}
