using DjValeting.DAL.Settings;
using DjValeting.WebUI.Utils;

var builder = WebApplication.CreateBuilder(args);

AppSettings.ConnectionString = builder.Configuration.GetSection("ConnectionStrings")["DjValetingConString"];
builder.Services.InstallServicesInAssemblies(builder.Configuration);
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

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
