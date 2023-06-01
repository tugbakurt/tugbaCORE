using DataAccessLayerT.Concrete;
using EntityLayerT.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.EntityFrameworkCore;

namespace tugbaCORE
{
    public class Startup
    {
        public IConfiguration Configuration { get; set; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<Context>();
            services.AddIdentity<AppUser,AppRole>().AddEntityFrameworkStores<Context>();
            services.AddControllersWithViews();
			
            services.AddIdentity<AppUser, IdentityRole>()
		   .AddEntityFrameworkStores<Context>()
		   .AddDefaultTokenProviders();
			services.AddDbContext<Context>(options =>
	options.UseSqlServer(Configuration.GetConnectionString("server=.;database=TugbaCoreDB;,ntegrated security=true")));
			services.AddMvc(
                config =>
                {
                    var policy = new AuthorizationPolicyBuilder()
                    .RequireAuthenticatedUser()
                    .Build();
                    config.Filters.Add(new AuthorizeFilter(policy));
                });
            services.AddMvc();

        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
            {
                if (env.IsDevelopment())
                {
                    app.UseDeveloperExceptionPage();
                }
                else
                {
                app.UseExceptionHandler("Home/Error");
                app.UseHsts();
                }
                app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseAuthentication();



            app.UseRouting();
            app.UseAuthorization();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id}");
            });
        }
    }
}
