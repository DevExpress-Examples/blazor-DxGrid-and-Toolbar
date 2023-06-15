using SampleBlazorApp.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using Grid.Northwind;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDevExpressBlazor(configure => configure.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5);
builder.Services.AddSingleton<WeatherForecastService>();
builder.Services.Configure<DevExpress.Blazor.Configuration.GlobalOptions>(options => {
    options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
});
builder.Services.AddDbContextFactory<NorthwindContext>((sp, options) => {
    var env = sp.GetRequiredService<IWebHostEnvironment>();
    var dbPath = Path.Combine(env.ContentRootPath, "Northwind.mdf");
    options.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Integrated Security=true;AttachDbFileName=" + dbPath);
});

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