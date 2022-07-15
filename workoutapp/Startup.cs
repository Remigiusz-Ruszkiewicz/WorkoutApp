using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using VirtualDesk.Models;
using VirtualDesk.Services;
using workoutapp.Contracts;
using workoutapp.Data;
using workoutapp.Services;

namespace workoutapp
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
            services.AddSwaggerGen();
            services.AddDbContext<DataContext>(options => options.UseSqlite("Data Source=Workout.db"));
            services.AddScoped<IExerciseService, ExerciseService>();
            services.AddScoped<IProgressNotificationService, ProgressNotificationService>();
            services.AddScoped<IBodyInfoService, BodyInfoService>();
            services.AddScoped<IProgressNotificationService, ProgressNotificationService>();
            services.AddSingleton<IEmailConfiguration>(Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>());
            services.AddScoped<IMailSenderService, MailSenderService>();
            services.AddScoped<IWorkoutService, WorkoutService>();
            services.AddSwaggerGen(c =>
            {

                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Workout App",
                    Version = "v1",
                    Contact = new OpenApiContact
                    {
                        Name = "KKR DevTeam",
                    },
                    License = new OpenApiLicense
                    {
                        Name = "Use under LICX",
                        Url = new Uri("https://example.com/license"),
                    }
                });
                //var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                //c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
                // Set the comments path for the Swagger JSON and UI.
                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                c.IncludeXmlComments(xmlPath);

                //c.ExampleFilters();
            });

            //services.AddSwaggerExamplesFromAssemblyOf<CategoryRequestExapmle>();
        }
    

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseSwagger();
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
        });
        app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
