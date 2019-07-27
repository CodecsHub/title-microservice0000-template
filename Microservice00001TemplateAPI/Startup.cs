using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microservice00001TemplateAPI.DataAccessLayers;
using Microservice00001TemplateAPI.Models;
using Microservice00001TemplateAPI.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Microservice00001TemplateAPI
{
    public class Startup
    {
        //@referrence: https://exceptionnotfound.net/using-dapper-asynchronously-in-asp-net-core-2-1/
        private readonly IHostingEnvironment _environment;
        private readonly IConfiguration _configuration;
        private readonly ILoggerFactory _loggerFactory;

        public Startup(IHostingEnvironment environment, IConfiguration configuration, ILoggerFactory loggerFactory)
        {

            _environment = environment;
            _configuration = configuration;
            _loggerFactory = loggerFactory;

            var builder = new ConfigurationBuilder()
                .SetBasePath(_environment.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddJsonFile($"appsettings.{_environment.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            //if (_environment.IsDevelopment())
            //{
            //    builder.AddUserSecrets<Startup>();
            //}

            _configuration = builder.Build();
        }

        public IConfiguration Configuration { get; }

        public IContainer ApplicationContainer { get; private set; }


        // This method gets called by the runtime. Use this method to add services to the container.
        // not sure sa autofac, to remove the nugget dependency, kindly change the iserviceporvider to void
        // and the line of autofac starts here and end here
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // Global service registration of conne
            services.Configure<UtilityAppSettings>(_configuration.GetSection("ConnectionStrings"));

            // autofac starts here
            // Create the container builder.
            // @ implemented autofac https://dotnetcorecentral.com/blog/autofac-in-asp-net-core-web-application/
            //services.AddTransient<IV1ActivityRepositories, V1ActivityRepositories>();
            var builder = new ContainerBuilder();
            builder.Populate(services);
            builder.RegisterType<V1ActivityRepositories>().As<IV1ActivityRepositories>();

            // Create the IServiceProvider based on the container.
            this.ApplicationContainer = builder.Build();
            return new AutofacServiceProvider(this.ApplicationContainer);
            // autofac ends here
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
