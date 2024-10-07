using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
// builder.WebHost.UseUrls("https://localhost:9002");

builder.Services.AddRazorPages();

builder.Services.AddControllersWithViews();

builder.Services.AddHttpClient(); 

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}


app.UseHttpsRedirection();
app.UseStaticFiles(); 

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();
