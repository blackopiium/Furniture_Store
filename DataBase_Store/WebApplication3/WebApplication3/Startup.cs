using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Furnit.Interfaces.SQLInterfaces.ISQLRepositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Furnit.Services;
using Furnit.Repositories.SQL_Repositories;
using Furnit.Interfaces.SQLInterfaces.ISQLServices;
using Furnit.Services.SQL_Services;
using Furnit.Interfaces;
using Furnit.UnitOfWork;
using Furnit.Infrastructure;

namespace Furn_Store
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
            services.AddControllers();
            #region SQL repositories
            services.AddTransient<ISQLItemsRepository, SQLItemRepository>();
            #endregion
            #region SQL services
            services.AddTransient<ISQLItemServices, SQLItemService>();
            #endregion
            services.AddTransient<ISQLUnitOfWork, SQLsqlUnitOfWork>();

            services.AddTransient<IConnectionFactory, ConnectionFactory>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
