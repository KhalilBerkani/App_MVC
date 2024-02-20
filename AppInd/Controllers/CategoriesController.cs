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
            if(ModelState.IsValid) 
            { 
                _db.Categoriess.Add(obj);
                _db.SaveChanges();
                TempData["succes"]= "Categorie ajouter avec succes";
                return RedirectToAction("Index");
            }
            return View();
            
        }
        public IActionResult Edit(int? id)
        {
            if(id==null || id == 0)
            {
                return NotFound();
            }
            Categories categoriesDB = _db.Categoriess.Find(id);
            if(categoriesDB == null)
            {
                return NotFound();
            }
            return View(categoriesDB);
        }
        [HttpPost]
        public IActionResult Edit(Categories obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categoriess.Update(obj);
                _db.SaveChanges();
                TempData["succes"] = "Categorie modifer avec succes";
                return RedirectToAction("Index");
            }
            return View();

        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Categories categoriesDB = _db.Categoriess.Find(id);
            if (categoriesDB == null)
            {
                return NotFound();
            }
            Categories obj = _db.Categoriess.Find(id); if (obj == null) { return NotFound(); }
            _db.Categoriess.Remove(obj);
            _db.SaveChanges();
            TempData["succes"] = "Categorie supprimer avec succes";
            return RedirectToAction("Index");
        }
    }
}
