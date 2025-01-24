using Cantek.ArgeProjectNTier.Business.DependencyResolvers.Microsoft;
using FluentValidation;
using Cantek.ArgeProjectNTier.UI.Models;
using Cantek.ArgeProjectNTier.UI.ValidationRules;
using AutoMapper;
using Cantek.ArgeProjectNTier.UI.Mappings.AutoMapper;
using Cantek.ArgeProjectNTier.Business.Helpers;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

builder.Host.ConfigureServices((hostContext, services) =>
{
    services.AddRazorPages();
    services.AddDependencies(hostContext.Configuration); // Burada direkt IConfiguration nesnesini gönderiyoruz
});

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(opt =>
    {
        opt.Cookie.Name = "CANTEK-BotanicFungi";
        opt.Cookie.HttpOnly = true;
        opt.Cookie.SameSite = SameSiteMode.Strict;
        opt.Cookie.SecurePolicy = CookieSecurePolicy.SameAsRequest;
        opt.ExpireTimeSpan = TimeSpan.FromDays(5);
        opt.LoginPath = new PathString("/Account/SignIn");
        opt.LogoutPath = new PathString("/Account/LogOut");
        opt.AccessDeniedPath = new PathString("/Account/AccessDenied");
    });
builder.Services.AddControllersWithViews();

var profiles = ProfileHelper.GetProfiles();
profiles.Add(new UserCreateModelProfile());

var configuration = new MapperConfiguration(opt =>
{
    opt.AddProfiles(profiles);
});

var mapper = configuration.CreateMapper();
builder.Services.AddSingleton(mapper);


builder.Services.AddTransient<IValidator<UserCreateModel>, UserCreateModelValidator>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapDefaultControllerRoute();
});

app.MapRazorPages();

app.Run();
