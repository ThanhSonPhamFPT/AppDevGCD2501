using AppDevGCD2501.Data;
using AppDevGCD2501.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppDevGCD2501.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDBContext dbContext;
        public CategoryController(ApplicationDBContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public IActionResult Index()
        {
            List<Category> listCategory = dbContext.Categories.ToList();
            return View(listCategory);
        }
		public IActionResult Add()
		{
			return View();
		}
        [HttpPost]
		public IActionResult Add(Category category)
		{
            if (ModelState.IsValid)
            {
				dbContext.Categories.Add(category);
				dbContext.SaveChanges();
				return RedirectToAction("Index");
			}
            return View();
		}
		public IActionResult Edit(int id)
		{
            Category category = dbContext.Categories.Find(id);
            if (category == null)
            {
                return NotFound();
            }
			return View(category);
		}
		[HttpPost]
		public IActionResult Edit(Category category)
		{
			if (ModelState.IsValid)
			{
				dbContext.Categories.Update(category);
				dbContext.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}
		public IActionResult Delete(int id)
		{
			Category category = dbContext.Categories.Find(id);
			if (category == null)
			{
				return NotFound();
			}
			return View(category);
		}
		[HttpPost]
		public IActionResult Delete(Category category)
		{			
				dbContext.Categories.Remove(category);
				dbContext.SaveChanges();
				return RedirectToAction("Index");
		}
		public IActionResult Hello()
        {
            return View();
        }
    }
}
