using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lecture3.Data;
using Lecture3.Data.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Lecture3
{
    public class Startup
    {

        private IConfiguration configuration;

        public Startup()
        {
            var builder = new ConfigurationBuilder();
            builder.AddUserSecrets<Startup>();
            configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            var connection = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<Lecture3DbContext>(options => options.UseSqlServer(connection));

            services.AddIdentity<User, IdentityRole>()
                .AddEntityFrameworkStores<Lecture3DbContext>()
                .AddDefaultTokenProviders();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
                app.UseBrowserLink();
            }

            app.UseAuthentication();
            app.UseMvcWithDefaultRoute();
        }
    }
}
