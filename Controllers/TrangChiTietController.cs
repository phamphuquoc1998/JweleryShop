using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.EF;
using WebApplication1.Entities;
using WebApplication2.Helper_và_session;
using WebApplication2.Models.Entities;

namespace WebApplication2.Controllers
{
    public class TrangChiTietController : Controller
    {
        JweleryDbcontext dataContext;
        public TrangChiTietController(JweleryDbcontext dataContext)
        {
            this.dataContext = dataContext;
        }
        [HttpGet("Detail/{id}/{name}")]
        public IActionResult Index(int id)
        {
            List<Sanpham> sanphams = dataContext.Sanphams.ToList();
            Sanpham sanphamss = sanphams.FirstOrDefault(p => p.MaSP == id);
            
            
            
            List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");

            if (cart == null)
            {
                ViewBag.sl = 0;
            }
            else
            {
                ViewBag.sl = cart.Count;
            }

            return View(sanphamss);
        }
        public IActionResult Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart") == null)
            {
                List<ProductToCart> cart = new List<ProductToCart>();
                List<Sanpham> sanphams = dataContext.Sanphams.ToList();
                cart.Add(new ProductToCart
                {
                    Sanpham = sanphams.FirstOrDefault(p => p.MaSP == id),
                    Quantity = 1,

                });
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart",
                cart);
            }
            else
            {
                List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
                List<Sanpham> sanphams = dataContext.Sanphams.ToList();
                int index = isExist(id);
                if (index != -1)
                {
                    cart[index].Quantity++;
                }
                else
                {
                    cart.Add(new ProductToCart
                    {
                        Sanpham = sanphams.FirstOrDefault(p => p.MaSP == id),
                        Quantity = 1,
                    });
                }
                SessionHelper.SetObjectAsJson(HttpContext.Session, "cart",
                cart);
            }
            return RedirectToAction("Index", "GioHang");
        }
        private int isExist(int id)
        {
            List<ProductToCart> cart =
            SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            List<Sanpham> sanphams = dataContext.Sanphams.ToList();
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Sanpham.MaSP == id)
                {
                    return i;
                }
            }
            return -1;
        }
        [HttpPost]
        public IActionResult ThemDanhGia(Danhgia danhgia)
        {
            if (ModelState.IsValid)
            {
                Danhgia newdanhgia = new Danhgia();

                newdanhgia.BinhLuan = danhgia.BinhLuan;
                newdanhgia.NgayBL= DateTime.Now;
                newdanhgia.MaSP = danhgia.MaSP;


                Danhgia p = new Danhgia()
                {                  
                    BinhLuan=newdanhgia.BinhLuan,
                    NgayBL=newdanhgia.NgayBL,
                    MaSP=newdanhgia.MaSP

                    
                };
                dataContext.Danhgias.Add(p);
                dataContext.SaveChanges();

                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View(danhgia);
            }
        }
       

    }
}