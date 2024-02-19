using AppInd.Data;
using AppInd.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppInd.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoriesController(ApplicationDbContext db) 
        { 
            _db= db;
        }
        public IActionResult Index()
        {
            var objCategoriesList = _db.Categoriess.ToList();
            return View(objCategoriesList);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Categories obj)
        {
            _db.Categoriess.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
