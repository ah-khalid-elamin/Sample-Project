using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Sample_Project.AppContext;
using Sample_Project.Data;
using Sample_Project.Services;

var builder = WebApplication.CreateBuilder(args);
var configurationBuilder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())  //location of the exe file
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

IConfigurationRoot configuration = configurationBuilder.Build();

builder.Services.AddDbContext<ApplicationContext>(opt =>
    opt.UseSqlServer(configuration.GetConnectionString("SampleDB")));

builder.Services.AddTransient<IPersonService, PersonService>();

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
