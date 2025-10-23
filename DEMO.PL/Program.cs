using DEMO.BLL.MappingProfile;
using DEMO.BLL.Services.Classes;
using DEMO.BLL.Services.Interfaces;
using DEMO.DAL.Data.Contexts;
using DEMO.DAL.Models.ApplicationUser;
using DEMO.DAL.Repositories.IRepos;
using DEMO.DAL.Repositories.Repos;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace DEMO.PL
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //builder.Services.AddScoped<ApplicationDbContext>(); // register service

            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                var conString = builder.Configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(conString);
                //var conString = builder.Configuration.GetSection("ConnectionStrings")["DefulatConnection"];
                //var conString = builder.Configuration.GetConnectionString("DefulatConnection"];
            });

            builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
            builder.Services.AddScoped<IDepartmentService, DepartmentService>();

            builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
            builder.Services.AddScoped<IEmployeeServices, EmployeeService>();

            //builder.Services.AddAutoMapper(typeof(MappingProfiles).Assembly); //xxxxxx
            builder.Services.AddAutoMapper(m=>m.AddProfile(new MappingProfiles()));


            builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
            {

            })
                .AddEntityFrameworkStores<ApplicationDbContext>().AddDefaultTokenProviders();

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



            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
