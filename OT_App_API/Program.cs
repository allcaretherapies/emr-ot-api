using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using OT_App_API;
using OTNotes.Business;
using OTNotes.Business.Interface;
using OTNotes.DataAccess;
using OTNotes.DataAccess.DAL;
using Microsoft.AspNetCore.Cors;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup();
startup.ConfigureServices(builder.Services);

builder.Services.AddControllers();

builder.Services.AddAutoMapper(typeof(MappingProfile).Assembly);

builder.Services.AddDbContext<OtnotesContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("OTConString")));

var app = builder.Build();
app.UseHttpsRedirection();
startup.Configure(app);
startup.Configure(app, builder.Environment);

app.MapControllers();

app.Run();
