using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using WebApplication1.EF;
using WebApplication1.Entities;

namespace WebApplication2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Administrator")]
    public class LoaiSanPhamController : Controller
    {
        private readonly IHubContext<SignalServer> context;
        JweleryDbcontext dataContext;

        public LoaiSanPhamController(JweleryDbcontext dataContext, IHubContext<SignalServer> context)
        {
            this.dataContext = dataContext;
            this.context = context;

        }
     
        public IActionResult Index()
        {
            //var mapper = new Mapper(new MapperConfiguration(c => c.CreateMap<Product, ProductModel>()));

            List<Loaisanpham> productss = dataContext.Loaisanphams.ToList();

            return View(productss);
        }
        public IActionResult Add()
        {
            Loaisanpham loaisanpham = new Loaisanpham();
            return View(loaisanpham);
        }
        [HttpPost]
        public IActionResult Add(Loaisanpham loaisanpham, IFormFile photo, IFormFile tenlsp)
        {
            if (ModelState.IsValid)
            {
                Loaisanpham newLoaisanpham = new Loaisanpham();
                if (photo == null || photo.Length == 0)
                {
                    newLoaisanpham.HinhAnh = "abc.png";
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imgs/menuProducts", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    photo.CopyToAsync(stream);
                    newLoaisanpham.HinhAnh = photo.FileName;
                }
                newLoaisanpham.TenLSP = loaisanpham.TenLSP;
                newLoaisanpham.MoTa = loaisanpham.MoTa;

                Loaisanpham p = new Loaisanpham()
                {
                    TenLSP = newLoaisanpham.TenLSP,
                    MoTa=newLoaisanpham.MoTa,
                    HinhAnh=newLoaisanpham.HinhAnh,                   
                };               
                dataContext.Loaisanphams.Add(p);
                dataContext.SaveChanges();
                context.Clients.All.SendAsync("refreshProducts");
                return RedirectToAction("Index", "LoaiSanPham");
            }
            else
            {
                return View(loaisanpham);
            }
        }
        public IActionResult Delete(string id)
        {
            //ProductModel oldProduct = productData.ProductList.FirstOrDefault(p => p.ProductId == id);
            Loaisanpham loaisp = dataContext.Loaisanphams.FirstOrDefault(p => p.MaLSP == id);
            Loaisanpham oldProduct = new Loaisanpham()
            {
                MaLSP = loaisp.MaLSP,
                TenLSP =loaisp.TenLSP,
                HinhAnh=loaisp.HinhAnh,
                MoTa=loaisp.MoTa
            };
            return View(oldProduct);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(string id)
        {
            // productData.ProductList.RemoveAll(p => p.ProductId == id);
            Loaisanpham loaisp = dataContext.Loaisanphams.FirstOrDefault(p => p.MaLSP == id);
            dataContext.Loaisanphams.Remove(loaisp);
            dataContext.SaveChanges();
            context.Clients.All.SendAsync("refreshProducts");
            return RedirectToAction("Index", "LoaiSanPham");
        }
        public IActionResult Edit(string id)
        {
            // ProductModel oldProduct = productData.ProductList.FirstOrDefault(p => p.ProductId == id);

            Loaisanpham p = dataContext.Loaisanphams.FirstOrDefault(p => p.MaLSP == id);
            Loaisanpham oldProduct = new Loaisanpham() 
            {
               TenLSP = p.TenLSP,
                HinhAnh=p.HinhAnh,
                MoTa=p.MoTa

            };

            return View(oldProduct);
        }
        [HttpPost]
        public IActionResult Edit(string id, Loaisanpham loaisanpham, IFormFile photo1)
        {
            if (ModelState.IsValid)
            {
                Loaisanpham p = dataContext.Loaisanphams.FirstOrDefault(p => p.MaLSP == id);
                if (photo1 == null || photo1.Length == 0)
                {
                    p.HinhAnh = "abc.png";
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imgs/menuProducts", photo1.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    photo1.CopyToAsync(stream);
                    p.HinhAnh = photo1.FileName;
                }
                p.TenLSP = loaisanpham.TenLSP;
                p.MoTa = loaisanpham.MoTa;
                

                
                dataContext.SaveChanges();
                context.Clients.All.SendAsync("refreshProducts");
                ViewBag.Status = 1;
            }



            return View(loaisanpham);
        }
        public IActionResult Layloaisanphams()
        {


            return Ok(dataContext.Loaisanphams.ToList());
        }
    }
}