using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.EF;
using WebApplication1.Entities;
using WebApplication2.Helper_và_session;
using WebApplication2.Models.Domain;
using WebApplication2.Models.Entities;

namespace WebApplication2.Controllers
{
    [Authorize]
    public class GioHangController : Controller
    {
        private readonly UserManager<User> _userManager;
        JweleryDbcontext dataContext;
        public GioHangController(JweleryDbcontext dataContext, UserManager<User> userManager)
        {
            this.dataContext = dataContext;
            _userManager = userManager;
        }
        public IActionResult Index()
        {

           
            ViewBag.id = _userManager.GetUserId(User);
            var cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            ViewBag.cart = cart;                          
            if (cart == null)
            {
                ViewBag.sl = 0;
                ViewBag.total = 0;
            }
            else
            {
                ViewBag.sl = cart.Count;
                ViewBag.total = cart.Sum(item => item.Sanpham.DonGia * item.Quantity);
            }
            return View();
        }
        [Route("buy/{id}")]
        public IActionResult Buy(int id)
        {
            if (SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart") == null)
            {
                List<ProductToCart> cart = new List<ProductToCart>();
                List<Sanpham> sanphams = dataContext.Sanphams.ToList();
                cart.Add(new ProductToCart
                {
                    Sanpham =sanphams.FirstOrDefault(p => p.MaSP == id),
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
            return RedirectToAction("Index");
        }
        [Route("remove/{id}")]
        public IActionResult Remove(int id)
        {
            List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            int index = isExist(id);
            cart.RemoveAt(index);
            SessionHelper.SetObjectAsJson(HttpContext.Session,
            "cart", cart);
            return RedirectToAction("Index");
        }
        private int isExist(int id)
        {
            List<ProductToCart> cart =
            SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
            List<Sanpham> sanphams = dataContext.Sanphams.ToList();
            for (int i = 0; i < cart.Count; i++)
            {
                if (cart[i].Sanpham.MaSP== id)
                {
                    return i;
                }
            }
            return -1;
        }
        [HttpPost]
        public IActionResult themdonhang(Hoadon hoadon)
        {
            
            if (ModelState.IsValid)
            {
                
                Hoadon newHoadon = new Hoadon( );
                newHoadon.NgayLap = DateTime.Now;
                newHoadon.NguoiNhan = hoadon.NguoiNhan;
                newHoadon.SDT = hoadon.SDT;
                newHoadon.TongTien = hoadon.TongTien;
                newHoadon.MaUser = hoadon.MaUser;
                newHoadon.DiaChi = hoadon.DiaChi;




                Hoadon p = new Hoadon()
                {
                    SDT=newHoadon.SDT,
                    NguoiNhan=newHoadon.NguoiNhan,
                    NgayLap=newHoadon.NgayLap,
                    TongTien=newHoadon.TongTien,
                    MaUser=newHoadon.MaUser,
                    DiaChi=newHoadon.DiaChi


                };

                
                dataContext.Hoadons.Add(p);
                dataContext.SaveChanges();
                List<ProductToCart> cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
                cart.Clear();
                SessionHelper.SetObjectAsJson(HttpContext.Session,"cart", cart);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        //public IActionResult Inhoadon()
        //{
        //    var cart = SessionHelper.GetObjectFromJson<List<ProductToCart>>(HttpContext.Session, "cart");
        //ViewBag.cart = cart;
        //    ViewBag.total = cart.Sum(item => item.Sanpham.DonGia* item.Quantity);
        //    int day = DateTime.Now.Day;
        //    ViewBag.day = day;
        //    int month = DateTime.Now.Month;
        //    ViewBag.month = month;
        //    int year = DateTime.Now.Year;
        //    ViewBag.year = year;
        //    return View();
        //}
    }
}