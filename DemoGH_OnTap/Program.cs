using DemoGH_OnTap.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<SD18406CartDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
//khai b�o d?ch v? cho session
builder.Services.AddSession(option =>
{
    option.IdleTimeout = TimeSpan.FromSeconds(60); // khai b�o kho?ng th?i gian ?? session timeout
    //n?u k th?c hi?n ti?p y�u c?u n�o th� session s? bi h?t han trong 60s
    //n?u th?c hi?n ti?p th� b? ??m c?a sesion s? reset d? li?u l?u v�o web server
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
