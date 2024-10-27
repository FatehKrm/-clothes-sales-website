using BusinesLayer.Abstruct;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;

namespace E_ticElbise.Controllers
{
    public class CategoryListController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryListController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult CategoryList()
        {
            var Categories = _categoryService.TGetAll();
            return View(Categories);
        } 

         // category delete 

       public IActionResult DeleteCategory(int id)
        {
            _categoryService.TDelete(id);

            return RedirectToAction("CategoryList");
        }

        // category update 

        [HttpGet]
        public IActionResult UpdateCategory(int id)
        {
            var values = _categoryService.TgetById(id);
            return View(values);
        }
        [HttpPost]
        public IActionResult UpdateCategory(Category category, IFormFile imageUpload)
        {
            var existingCategory = _categoryService.TgetById(category.CategoryId);
            if (existingCategory == null)
            {
                return NotFound("Kategori Bulunamadı!");
            }

            existingCategory.CategoryName = category.CategoryName;
            existingCategory.CategoryDiscription = category.CategoryDiscription;

            if (imageUpload != null && imageUpload.Length > 0)
            {
                var fileName = Path.GetFileName(imageUpload.FileName);
                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", fileName);

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    imageUpload.CopyTo(stream);
                }
                existingCategory.ImageUrl = "/images/" + fileName;
            }

            existingCategory.IsActive = category.IsActive;

            _categoryService.TUpdate(existingCategory);

            return RedirectToAction("CategoryList");
        }





    }
}
