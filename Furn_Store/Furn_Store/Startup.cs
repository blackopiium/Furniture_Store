using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BenchmarkDotNet.Validators;
using FluentValidation;
using Furniture_Store.Business.DTO;
using Furniture_Store.Business.Interfaces;
using Furniture_Store.Business.Services;
using Furniture_Store.Business.Validators;
using Furniture_Store.Data;
using Furniture_Store.Data.Data.EFCore;
using Furniture_Store.Data.EFCore;
using Furniture_Store.Data.Helpers;
using Furniture_Store.Data.Interfaces;
using Furniture_Store.Data.Models;
using Furniture_Store.Interfaces;
using Furniture_Store.Models;
using Furniture_Store.UnitOfWorkFolder;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace Furn_Store
{
    public class Startup
    {
        private const string SecretKey = "iNivDmHLpUA223sqsfhqGbMRdRj1PVkH";
        private readonly SymmetricSecurityKey _signingKey = new SymmetricSecurityKey(Encoding.ASCII.GetBytes(SecretKey));
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<RepositoryContext>(opts => opts.UseSqlServer(Configuration["ConnectionString:FurnitureStoreDB"]));
            services.AddControllers();
            services.AddControllersWithViews();

          /*  services.AddDbContext<RepositoryContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("RepositoryContext")));*/
            services.AddMvc();
            #region automapper
            services.AddAutoMapper(cfg=>
            {
                cfg.CreateMap<Item, ItemDTO>();
                cfg.CreateMap<Category, CategoryDTO>();
                cfg.CreateMap<Factory, FactoryDTO>();
                cfg.CreateMap<Order, OrderDTO>();
                cfg.CreateMap<Charachteristics_Item, Charachteristic_Item_DTO>();
                cfg.CreateMap<Client, ClientDTO>();
                cfg.CreateMap<Order_Items, Order_Items_DTO>();
            },typeof(Startup));
            #endregion
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            #region Repositories
            services.AddScoped<IItemRepository, ItemRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IFactoryRepository, FactoryRepository>();
            services.AddScoped<IClientRepository, CLientRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICharachteristics_ItemRepository, Charachteristics_ItemRepository>();
            services.AddScoped<IOrder_Items_Repository, Order_ItemsRepository>();
            #endregion
            #region Services
            services.AddTransient<IItemService, ItemService>();
            services.AddTransient<ICategoryService, CategoryService>();
            services.AddTransient<IFactoryService, FactoryService>();
            services.AddTransient<ICharachteristics_Service, Charachteristics_Item_Service>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IOrder_Items_Service, Order_Items_Service>();
            services.AddTransient<IOrderService, OrderService>();
            #endregion
            services.AddIdentity<User, IdentityRole>(opt =>
            {
                opt.Password.RequiredLength = 6;
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
                opt.Password.RequireNonAlphanumeric = false;
            })
                .AddEntityFrameworkStores<RepositoryContext>()
                .AddDefaultTokenProviders();
            #region validators
            services.AddSingleton<IValidator<ItemDTO>, ItemDTOValidator>();
            services.AddSingleton<IValidator<CategoryDTO>, CategoryDTOValidator>();
            services.AddSingleton<IValidator<FactoryDTO>, FactoryDTOValidator>();
            services.AddSingleton<IValidator<ClientDTO>, ClientDTOValidator>();
            services.AddSingleton<IValidator<OrderDTO>, OrderDTOValidator>();
            services.AddSingleton<IValidator<Order_Items_DTO>, Order_Items_DTO_Validator>();
            services.AddSingleton<IValidator<Charachteristic_Item_DTO>, Charachteristircs_Item_DTO_Validator>();
            #endregion
            services.AddTransient<ISortHepler<Item>, SortHelper<Item>>();

            // api user claim policy
            /*services.AddAuthorization(options =>
            {
                options.AddPolicy("ApiUser", policy => policy.RequireClaim(Constants.Strings.JwtClaimIdentifiers.Rol, Constants.Strings.JwtClaims.ApiAccess));
            });*/

            services.AddMvc();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCors(x => x.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

            app.UseRouting();
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
