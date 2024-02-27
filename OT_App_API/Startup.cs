using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using OT_App_API.Filters;
using OTNotes.Business.Interface;
using OTNotes.DataAccess.DAL;
using IHostingEnvironment = Microsoft.Extensions.Hosting.IHostingEnvironment;

namespace OT_App_API
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
        }
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
           
            if (env.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI(c =>
                {
                   // c.SwaggerEndpoint("/OTAPI/swagger/v1/swagger.json", "OT-Notes-API");
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "OT-Notes-API");
                });
            }
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ICHGeneralService, CHGeneralService>();
            services.AddScoped<ICHMedicalService, CHMedicalService>();

            services.AddScoped<CHMedicalDAL>();
            services.AddScoped<CHGeneralDAL>();

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
            });

            //// Add authentication
            //services.AddAuthentication(options =>
            //{
            //    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //}).AddJwtBearer(options =>
            //{
            //    // Configure JWT authentication parameters
            //    options.TokenValidationParameters = new TokenValidationParameters
            //    {
            //        ValidateIssuer = true,
            //        ValidateAudience = true,
            //        ValidateIssuerSigningKey = true,
            //        ValidIssuer = "your_issuer",
            //        ValidAudience = "your_audience",
            //        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("your_secret_key"))
            //    };
            //});

            //// Add authorization
            //services.AddAuthorization();

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
