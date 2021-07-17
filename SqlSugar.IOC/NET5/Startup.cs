using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SqlSugar.IOC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace NET5
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
            services.AddSqlSugar(new IocConfig()
            {
                ConfigId="1",
                ConnectionString = "server=.;uid=sa;pwd=sasa;database=SQLSUGAR4XTEST",
                DbType = IocDbType.SqlServer,
                IsAutoCloseConnection = true
            });
            services.AddSqlSugar(new IocConfig()
            {
                ConfigId = "2",
                ConnectionString = "server=.;uid=sa;pwd=sasa;database=SQLSUGAR4XTEST",
                DbType = IocDbType.SqlServer,
                IsAutoCloseConnection = true
            });
            services.ConfigurationSugar(db =>
            {
                db.GetConnection("1").Aop.OnLogExecuting = (sql, p) =>
                {
                    Console.WriteLine(1+sql);
                };
                db.GetConnection("2").Aop.OnLogExecuting = (sql, p) =>
                {
                    Console.WriteLine(2+sql);
                };
            });
            services.AddIoc(this,"BizTest", it => it.Name.Contains("Test"));
            services.AddIoc(this, "DalTest", it => it.Name.Contains("Test"));
            services.AddIoc(this,"NET5", it => it.Name.Contains("Controller"));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
