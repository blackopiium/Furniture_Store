using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furniture_Store.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Furniture_Store.Data;
using Furniture_Store.Data.EFCore;
using Furniture_Store.Interfaces;
using Furniture_Store.Data.Interfaces;
using Furniture_Store.Data.Data.EFCore;
using Furniture_Store.Business.Interfaces;
using Furniture_Store.Business.Services;
using Furniture_Store.Data.Models;
using Microsoft.AspNetCore.Identity;
using Furniture_Store.UnitOfWorkFolder;
using AutoMapper;

namespace Furniture_Store
{
    public class Startup
    {
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

            services.AddDbContext<RepositoryContext>(options =>
                    options.UseSqlServer(Configuration.GetConnectionString("RepositoryContext")));
            services.AddMvc();
            services.AddAutoMapper(typeof(Startup));
            services.AddIdentity<User, IdentityRole>()
        .AddEntityFrameworkStores<RepositoryContext>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IItemRepository, ItemRepository>();
           services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IFactoryRepository, FactoryRepository>();
            services.AddScoped<IClientRepository, CLientRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<ICharachteristics_ItemRepository, Charachteristics_ItemRepository>();
            services.AddScoped<IOrder_Items_Repository, Order_ItemsRepository>();
            services.AddTransient<IItemService, ItemService>();
            services.AddIdentity<User, IdentityRole>(opt =>
            {
                opt.Password.RequiredLength = 6;
                opt.Password.RequireDigit = false;
                opt.Password.RequireUppercase = false;
            })
                .AddEntityFrameworkStores<RepositoryContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseCors("CorsPolicy");

            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.All
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
