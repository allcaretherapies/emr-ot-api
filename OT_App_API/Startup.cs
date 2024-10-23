using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using OT_App_API.Filters;
using OTNotes.Business.Interface;
using OTNotes.DataAccess.DAL;
using Microsoft.AspNetCore.Cors;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;
using Newtonsoft.Json.Serialization;
using OTNotes.Business.Service;
using OT_App_API.Middleware;
using Microsoft.AspNetCore.Authentication;

namespace OT_App_API
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouting();
            app.UseAuthentication();  // This enables authentication (like JWT, Basic Auth, etc.)
            app.UseAuthorization();

            app.UseCors("CorsPolicy");
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();  // Maps controller routes
            });

            app.UseMiddleware<ExceptionHandlingMiddleware>();

            //if (env.IsDevelopment())
            //{
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                   // c.SwaggerEndpoint("/OTAPI/swagger/v1/swagger.json", "OT-Notes-API");
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "OT-Notes-API");
                });
            //}
            // app.UseCors("AllowSpecificOrigins");
            //app.UseCors();
            
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICHGeneralService, CHGeneralService>();
            services.AddScoped<ICHMedicalService, CHMedicalService>();
            services.AddScoped<IAreaOfAssess, AreaOfAssessService>();

            services.AddScoped<CHMedicalDAL>();
            services.AddScoped<CHGeneralDAL>();
            services.AddScoped<AreaOfAssessDAL>();
            services.AddAuthentication("BasicAuthentication")
        .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);


            services.AddMvc(options =>
            {
                options.Filters.Add(typeof(GlobalExceptionFilter));
            });

            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "OT-Notes", // Set your desired title
                    Version = "v1",
                    Description = "API documentation for OT-Notes"
                });
                // Add basic auth scheme
                options.AddSecurityDefinition("basic", new OpenApiSecurityScheme
                {
                    Name = "Authorization",
                    Type = SecuritySchemeType.Http,
                    Scheme = "basic",
                    In = ParameterLocation.Header,
                    Description = "Input your username and password to access this API"
                });

                options.AddSecurityRequirement(new OpenApiSecurityRequirement
        {
            {
                new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Type = ReferenceType.SecurityScheme,
                        Id = "basic"
                    }
                },
                new string[] {}
            }
        });
            });
            // Add the authentication scheme
           

            services.AddControllers()
                     .AddNewtonsoftJson(options =>
                     {
                         // Use the default contract resolver (property names as defined in the model)
                         options.SerializerSettings.ContractResolver = new DefaultContractResolver();
                     });

            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyHeader().AllowAnyMethod().WithOrigins("*");
                });
            });

            services.AddAuthorization();

        }

        [Obsolete]
        public void ConfigureLogging(IHostingEnvironment env, ILoggingBuilder logging)
        {
            logging.AddConsole(); // Log to the console
            // Configure file logging
            //logging.AddFile("path/to/logs/log-{Date}.txt"); // Specify the path to the log file
        }
    }
}
