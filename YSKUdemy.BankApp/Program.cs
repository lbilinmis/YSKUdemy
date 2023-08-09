using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using YSKUdemy.BankApp.Data.Contexts;
using YSKUdemy.BankApp.Data.Interfaces;
using YSKUdemy.BankApp.Data.Repositories;
using YSKUdemy.BankApp.Mappings;

var builder = WebApplication.CreateBuilder(args);


{
    // Add services to the container.
    builder.Services.AddDbContext<AppDbContext>(opt =>
    {
        opt.UseSqlServer(@"Data source=IGU-NB-0884;initial catalog=YSK_BankAppDB;user id=sa;password=s123456*-;");

    });

    builder.Services.AddScoped<IAppUserRepository, AppUserRepository>();
    builder.Services.AddScoped<IAccountRepository, AccountRepository>();
    builder.Services.AddScoped<IAppUserMapping,AppUserMapping>();
    builder.Services.AddScoped<IAccountMapping, AccountMapping>();

    //Generic olduðu zaman aþaðýdaki þekilde tanýmlanmalý

    builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

    builder.Services.AddControllersWithViews();
}
var app = builder.Build();

// Configure the HTTP request pipeline.
{
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");
    }
    app.UseStaticFiles();
    app.UseStaticFiles(new StaticFileOptions
    {
        FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/frontend")),
        RequestPath = "/frontend"
    });

    app.UseRouting();

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");

    app.Run();
}
