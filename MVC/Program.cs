// Program.cs
using Data.Data;
using Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Voeg services toe aan de container.
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();

// Configureer applicatiecookie
builder.Services.ConfigureApplicationCookie(options =>
{
    options.LoginPath = "/Account/Login";
    options.AccessDeniedPath = "/Account/AccessDenied";
});

// Voeg MVC toe met Views
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Seed de rollen
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    try
    {
        await DbInitializer.InitializeAsync(services);
    }
    catch (Exception ex)
    {
        // Log fouten bij het seeden
        var logger = services.GetRequiredService<ILogger<Program>>();
        logger.LogError(ex, "Er is een fout opgetreden tijdens het seeden van de rollen.");
    }
}

// Configureer de HTTP-request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

// Voeg authenticatie en autorisatie toe
app.UseAuthentication();
app.UseAuthorization();

// Wijzig de standaardroute naar Home/Index
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
