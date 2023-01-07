using EviCRM.Areas.Identity;
using EviCRM.Core.Db.Contexts;
using EviCRM.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<IdentityUser>>();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddDbContext<CoreContext>(_ => _.UseNpgsql(builder.Configuration.GetConnectionString(nameof(CoreContext))));
builder.Services.AddDbContext<AlexandraContext>(_ => _.UseNpgsql(builder.Configuration.GetConnectionString(nameof(AlexandraContext))));
builder.Services.AddDbContext<CacheContext>(_ => _.UseNpgsql(builder.Configuration.GetConnectionString(nameof(CacheContext))));
builder.Services.AddDbContext<IntegrationContext>(_ => _.UseNpgsql(builder.Configuration.GetConnectionString(nameof(IntegrationContext))));
builder.Services.AddDbContext<SecurityContext>(_ => _.UseNpgsql(builder.Configuration.GetConnectionString(nameof(SecurityContext))));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
