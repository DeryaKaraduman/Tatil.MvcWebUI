using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Tatil.MvcWebUI.Entity;
using Tatil.MvcWebUI.Models;

namespace Tatil.MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();


        // GET: Home
        public ActionResult Index()
        {
            var urunler = _context.Products
                                .Where(i => i.IsHome && i.IsApproved)
                                .Select(i => new ProductModel()
                                {
                                    Id=i.Id,
                                    Name=i.Name,
                                    Description=i.Description.Length>12?i.Description.Substring(0,12):i.Description,
                                    Price=i.Price,
                                    Stock=i.Stock,
                                    Image=i.Image,
                                    CategoryId=i.CategoryId
                                }).ToList();

            return View(urunler);
        }
        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id==id).FirstOrDefault());
        }
        public ActionResult List(int? id)
        {
            var urunler = _context.Products
                                .Where(i => i.IsApproved)
                                .Select(i => new ProductModel()
                                {
                                    Id = i.Id,
                                    Name = i.Name,
                                    Description = i.Description.Length > 12 ? i.Description.Substring(0, 12) : i.Description,
                                    Price = i.Price,
                                    Stock = i.Stock,
                                    Image = i.Image,
                                    CategoryId = i.CategoryId
                                }).AsQueryable();

            if (id != null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }

            return View(urunler.ToList());
        }

        public PartialViewResult GetCategories()
        {
            return PartialView(_context.Categories.ToList());
        }

    }
}