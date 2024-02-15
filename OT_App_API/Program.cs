using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OT_App_API;
using OTNotes.Business;
using OTNotes.Business.Interface;
using OTNotes.DataAccess;
using OTNotes.DataAccess.DAL;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup();
startup.ConfigureServices(builder.Services);
// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

builder.Services.AddDbContext<OtnotesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OTConString")));


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
//builder.Services.AddScoped<ICHGeneralService, CHGeneralService>();
//builder.Services.AddScoped<CHGeneralDAL>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
startup.Configure(app);
startup.Configure(app, builder.Environment);

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
