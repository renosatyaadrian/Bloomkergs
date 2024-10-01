using Bloomkergs.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddRazorPages(); // Enable Razor Pages
builder.Services.AddControllers(); // Enable API Controllers
builder.Services.AddHttpClient(); // This registers HttpClient for dependency injection


var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Serve static files

app.UseRouting();
app.UseAuthorization();

app.MapControllers(); // Map API Controllers
app.MapRazorPages();  // Map Razor Pages

app.Run();
