using FiveStarRepos.API.Filters;
using FiveStarRepos.Infra.IoC;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;

namespace FiveStarRepos.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration) => Configuration = configuration;

        private const string myAllowedOrigins = "FiveStarReposPolicy";

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers(options =>
            {
                options.Filters.Add(typeof(FiveStarReposExceptionFilter));
            });            

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "FiveStarRepos.API", Version = "v1" });
            });

            services.AddCors(options =>
            {
                options.AddPolicy(myAllowedOrigins,
                                      policy =>
                                      {
                                          policy.AllowAnyOrigin()
                                                .AllowAnyHeader()
                                                .AllowAnyMethod();
                                      });
            });

            services.ConfigureApplicationContext(Configuration);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "FiveStarRepos.API"));
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseCors(myAllowedOrigins);

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
