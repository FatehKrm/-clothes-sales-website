using BusinesLayer.Abstruct;
using E_ticElbise.Models.Classes;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace E_ticElbise.Controllers
{
    public class ProductController1 : Controller
    {
        private readonly IProductsService _ProductService;
        private readonly ICategoryService _CategoryService;
        private readonly IColorsService _ColorService;
        private readonly ISizeService _SizeService;
        private readonly ITemporanyColorsService _TemColorService;

        // Tek bir constructor kullanarak her iki servisi de enjekte ettik
        public ProductController1(ICategoryService categoryService, IProductsService productService, IColorsService colorsService, ISizeService sizeService , ITemporanyColorsService temColorService)
        {
            _CategoryService = categoryService;
            _ProductService = productService;
            _ColorService = colorsService;
            _SizeService = sizeService;
            _TemColorService = temColorService;
        }

        public IActionResult AddProduct()
        {
            var values = _CategoryService.TGetAll();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddProductS2(int id)           
        {


            var color = _ColorService.TGetAll();
            var size = _SizeService.TGetAll();
            var TemporanyColor = _TemColorService.TGetAll();

            var ViewModel = new PCSViewModel
            {
                ProductVm = new Products { p_Categry_Id = id },
                ColorsVm = color,
                SizesVm = size ,
                T_Colors = TemporanyColor
            };
            return View("AddProductS2", ViewModel);
        }


       [HttpPost]
        public async Task<IActionResult> AddProductS2Async(Products product, List<string>SelectedSize, IFormFile imageUpload)
        {
            
            string ColorCodeValue = HttpContext.Session.GetString("ColorCodeValue");
            string ColorNameValue = HttpContext.Session.GetString("ColorNameValue");
            string AddSizeToDb = string.Join(",", SelectedSize);
           
            product.P_Size = AddSizeToDb;

            product.P_ColorCode = ColorCodeValue;
            product.P_Color = ColorNameValue;

            if (imageUpload != null && imageUpload.Length > 0)
            {
                var filePath = Path.Combine("wwwroot/images", Path.GetFileName(imageUpload.FileName));

                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    await imageUpload.CopyToAsync(stream);
                }

             product.ImageURL = $"/images/{Path.GetFileName(imageUpload.FileName)}";
            }


            _TemColorService.TClearAllFromTColors();

            // verileri view modele eklemek için yazılan kod 
            var color = _ColorService.TGetAll();
            var size = _SizeService.TGetAll();
            var TemporanyColor = _TemColorService.TGetAll();
            var ViewModl = new PCSViewModel
            {
                ProductVm = product ,
                ColorsVm = color,
                SizesVm = size,
                T_Colors = TemporanyColor
            };

            _ProductService.TAdd(product);

            return View("AddProductS2", ViewModl);
        }

        [HttpPost]
        public IActionResult TemporanyColor(TemporanyColors TemColor)
        {
            // çok güzel bir yöntem : 
            List<string> CodeList = HttpContext.Session.GetString("ColorCodeValue")?.Split(',').ToList() ?? new List<string>();
            List<string> NameList = HttpContext.Session.GetString("ColorNameValue")?.Split(',').ToList() ?? new List<string>();

            CodeList.Add(TemColor.TemporanyColorCode);
            NameList.Add(TemColor.TemporanyColorName);

            _TemColorService.TAdd(TemColor);
           
            HttpContext.Session.SetString("ColorCodeValue", string.Join(",", CodeList));
            HttpContext.Session.SetString("ColorNameValue", string.Join(",", NameList));

            var color = _ColorService.TGetAll();
            var size = _SizeService.TGetAll();
            var TemporanyColor = _TemColorService.TGetAll();
            var ViewModel = new PCSViewModel
            {
                ProductVm = new Products(),
                ColorsVm = color,
                 SizesVm= size,
                T_Colors = TemporanyColor
            };

            return View("AddProductS2", ViewModel);


        }
       

    }
}
