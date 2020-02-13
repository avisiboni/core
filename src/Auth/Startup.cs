﻿using Codidact.Infrastructure.Persistence;
using Codidact.Infrastructure.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Codidact.Auth.Services;
using IdentityServer4.Services;
using Codidact.Infrastructure;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Codidact.Application;
using Microsoft.AspNetCore.Identity;

namespace Codidact.Auth
{
    public class Startup
    {
        public Startup(IConfiguration configuration, IWebHostEnvironment environment)
        {
            Configuration = configuration;
            Environment = environment;
        }

        public IConfiguration Configuration { get; }

        public IWebHostEnvironment Environment { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(Microsoft.AspNetCore.Mvc.CompatibilityVersion.Version_2_1);

            services.AddHttpContextAccessor();

            services.AddApplication();
            services.AddInfrastructure(Configuration);

            services.AddDefaultIdentity<ApplicationUser>()
                    .AddEntityFrameworkStores<ApplicationDbContext>()
                    .AddDefaultTokenProviders();

            services.AddSingleton<IProfileService, CustomProfileService>();
            services.AddTransient<ModelBuilder>();

            var builder = services.AddIdentityServer(options =>
            {
                options.Events.RaiseErrorEvents = true;
                options.Events.RaiseInformationEvents = true;
                options.Events.RaiseFailureEvents = true;
                options.Events.RaiseSuccessEvents = true;
            })
                .AddDeveloperSigningCredential()
                .AddInMemoryClients(Configuration.GetSection("IdentityServer:Clients"))
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryApiResources(Configuration.GetSection("IdentityServer:ApiResources"))
                // this adds the operational data from DB (codes, tokens, consents)
                .AddAspNetIdentity<ApplicationUser>()
                .AddProfileService<CustomProfileService>();

            services.AddAuthentication();
        }

        public async void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseIdentityServer();

            app.UseStaticFiles();
            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "Identity/{controller=Home}/{action=Index}/{id?}");
            });

            await app.InitializeIdentityData();
        }
    }
}