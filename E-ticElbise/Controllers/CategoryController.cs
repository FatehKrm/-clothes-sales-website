using BusinesLayer.Abstruct;
using BusinesLayer.ValidationRules;
using EntityLayer.Concrate;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Threading.Tasks;

namespace E_ticElbise.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(Category category, IFormFile imageUpload)
        {
            // Validasyon işlemi
            CategoryValidation validationRules = new CategoryValidation();
            ValidationResult results = validationRules.Validate(category);

            if (!results.IsValid)
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View(category);
            }

            if (imageUpload != null && imageUpload.Length > 0)
            {
                var filePath = Path.Combine("wwwroot/images", Path.GetFileName(imageUpload.FileName));

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageUpload.CopyToAsync(stream);
                }

                category.ImageUrl = $"/images/{Path.GetFileName(imageUpload.FileName)}";
            }

            _categoryService.TAdd(category);

            return RedirectToAction("AdminIndex", "Admin");
        }
    }
}
