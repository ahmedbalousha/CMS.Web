using CMS.Data;
using CMS.Data.Models;
using CMS.Infrastructure.AutoMapper;
using CMS.Infrastructure.Middlewares;
using CMS.Infrastructure.Services;
using CMS.Infrastructure.Services.Advertisements;
using CMS.Infrastructure.Services.Categories;
using CMS.Infrastructure.Services.Notifications;
using CMS.Infrastructure.Services.Posts;
using CMS.Infrastructure.Services.Tracks;
using CMS.Infrastructure.Services.Users;
using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.IO;

namespace CMS.Web
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
            services.AddDbContext<CMSDbContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("DefaultConnection")));
            services.AddDatabaseDeveloperPageExceptionFilter();
            services.AddIdentity<User, IdentityRole>(config =>
            {
                config.User.RequireUniqueEmail = true;
                config.Password.RequireDigit = false;
                config.Password.RequiredLength = 6;
                config.Password.RequireLowercase = false;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;
                config.SignIn.RequireConfirmedEmail = false;
            }).AddEntityFrameworkStores<CMSDbContext>()
               .AddDefaultTokenProviders()
               .AddDefaultUI();

           
            services.AddRazorPages();
            services.AddAutoMapper(typeof(AutoMapperProfile).Assembly);
            services.AddTransient<IEmailService,EmailService>();
            services.AddTransient<IFileService, FileService>();
            services.AddTransient<IUserService,UserService>();
            services.AddTransient<ICategoryService,CategoryService>();
            services.AddTransient<IAdvertisementService, AdvertisementService>();
            services.AddTransient<ITrackService, TrackService>();
            services.AddTransient<IPostService, PostService>();
            services.AddTransient<IDashboardService, DashboardService>();
            services.AddTransient<INotificationService, NotificationService>();





            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseExceptionHandler(opts => opts.UseMiddleware<ExceptionHandler>());

            FirebaseApp.Create(new AppOptions()
            {
                Credential = GoogleCredential.FromFile(Path.Combine(env.WebRootPath, "cmsweb-8cec4-firebase-adminsdk-o3vdn-284231053f.json")),
            });



            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}
