using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.EF;
using WebApplication1.Entities;

namespace WebApplication2.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles ="Administrator")]
    
    public class SanPhamController : Controller
    {

        JweleryDbcontext dataContext;
       
        public SanPhamController(JweleryDbcontext dataContext)
        {        
            this.dataContext = dataContext;
            
        }
        [HttpGet]
        public IActionResult Index()
        {
            //var mapper = new Mapper(new MapperConfiguration(c => c.CreateMap<Product, ProductModel>()));
            
            List<Sanpham> productss = dataContext.Sanphams.ToList();
            
            return View(productss);
        }
        public IActionResult Add()
        {
            //Sanpham sanpham = new Sanpham();
            List<Loaisanpham> productss = dataContext.Loaisanphams.ToList();
            
            return View(productss);
        }
        [HttpPost]
        public IActionResult Add(Sanpham sanpham, IFormFile photo)
        {
            if (ModelState.IsValid)
            {
                Sanpham newSanpham = new Sanpham();
                if (photo == null || photo.Length == 0)
                {
                    newSanpham.HinhAnh = "abc.png";
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imgs/sanpham", photo.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    photo.CopyToAsync(stream);
                    newSanpham.HinhAnh = photo.FileName;
                }
                newSanpham.TenSP = sanpham.TenSP;
                newSanpham.MaLSP= sanpham.MaLSP;
                newSanpham.DonGia = sanpham.DonGia;
                newSanpham.SoLuong = sanpham.SoLuong;
                newSanpham.TrangThai = sanpham.TrangThai;



                Sanpham p = new Sanpham()
                {
                    TenSP= newSanpham.TenSP,
                   MaLSP= newSanpham.MaLSP,
                    DonGia= newSanpham.DonGia,
                      SoLuong= newSanpham.SoLuong,
                      HinhAnh= newSanpham.HinhAnh,
                                       TrangThai= newSanpham.TrangThai

                };
                dataContext.Sanphams.Add(p);
                dataContext.SaveChanges();
                return RedirectToAction("Index","SanPham");
            }
            else
            {
                return View(sanpham);
            }
        }
        public IActionResult Delete(int id)
        {
            //ProductModel oldProduct = productData.ProductList.FirstOrDefault(p => p.ProductId == id);
            Sanpham sanpham = dataContext.Sanphams.FirstOrDefault(p => p.MaSP == id);
            Sanpham oldProduct = new Sanpham()
            {
               
                TenSP = sanpham.TenSP,
                HinhAnh = sanpham.HinhAnh,
                
            };
            return View(oldProduct);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            // productData.ProductList.RemoveAll(p => p.ProductId == id);
            Sanpham sanpham = dataContext.Sanphams.FirstOrDefault(p => p.MaSP == id);
            dataContext.Sanphams.Remove(sanpham);
            dataContext.SaveChanges();
            return RedirectToAction("Index", "SanPham");
        }
        public IActionResult Edit(int id)
        {
            // ProductModel oldProduct = productData.ProductList.FirstOrDefault(p => p.ProductId == id);

            Sanpham p = dataContext.Sanphams.FirstOrDefault(p => p.MaSP == id);
            Sanpham oldProduct = new Sanpham()
            {
               TenSP= p.TenSP,
           MaLSP= p.MaLSP ,
           DonGia= p.DonGia,
           SoLuong= p.SoLuong ,
           HinhAnh= p.HinhAnh,
           TrangThai= p.TrangThai 
        };

            return View(oldProduct);
        }
        [HttpPost]
        public IActionResult Edit(int id, Sanpham sanpham, IFormFile photo1)
        {
            if (ModelState.IsValid)
            {
                Sanpham p = dataContext.Sanphams.FirstOrDefault(p => p.MaSP == id);
                if (photo1 == null || photo1.Length == 0)
                {
                    p.HinhAnh = "abc.png";
                }
                else
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/imgs/sanpham/", photo1.FileName);
                    var stream = new FileStream(path, FileMode.Create);
                    photo1.CopyToAsync(stream);
                    p.HinhAnh = photo1.FileName;
                }
                p.TenSP = sanpham.TenSP;
                p.MaLSP = sanpham.MaLSP;
                p.DonGia = sanpham.DonGia;
                p.SoLuong = sanpham.SoLuong;
                p.TrangThai = sanpham.TrangThai;



                dataContext.SaveChanges();

                ViewBag.Status = 1;
            }



            return View(sanpham);
        }
    }
}