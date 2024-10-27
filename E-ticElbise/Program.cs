using BusinesLayer.Abstruct;
using BusinesLayer.Concrate;
using DataAccessLayer.Abstruct;
using DataAccessLayer.Context;
using DataAccessLayer.EntityFrameWork;

namespace E_ticElbise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<EticElbiseContext>();


         builder.Services.AddScoped<IAdminDal,EfAdminRepository>();
         builder.Services.AddScoped<IAdminService,AdminManager>();

         builder.Services.AddScoped<ICategoryDal, EfCategoryDal>();
         builder.Services.AddScoped<ICategoryService, CategoryManager>();

         builder.Services.AddScoped<IProductsDal, EfProductsDal>();
         builder.Services.AddScoped<IProductsService, ProductsManager>();

         builder.Services.AddScoped<IColorsDal, EfColorsDal>();
         builder.Services.AddScoped<IColorsService, ColorsManager>();

         builder.Services.AddScoped<ISizeDal, EfSizeDal>();
         builder.Services.AddScoped<ISizeService, SizeManager>();

         builder.Services.AddScoped<ITemporanyColorsDal, EfTemporanyColorsDal>();
         builder.Services.AddScoped<ITemporanyColorsService, TemporanyColorsManager>();

         builder.Services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Session timeout süresi
                options.Cookie.HttpOnly = true;
                options.Cookie.IsEssential = true;
            });

            builder.Services.AddControllersWithViews();


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseSession();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=AdminController}/{action=AdminIndex}/{id?}");

            app.Run();
        }
    }
}