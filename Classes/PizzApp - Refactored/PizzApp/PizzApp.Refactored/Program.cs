using PizzaApp.Helpers;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.InjectServices();
builder.Services.InjectRepositories();

string connString = builder.Configuration.GetConnectionString("PizzaAppDbConnSQLExpress"); 
//PizzaAppDbConnection se kopira od appsettings.json
builder.Services.InjectDbContext(connString);


// KADE NI E KRIERANA APP DB KLASATA TAMU BARAME PACKAGE MANAGE CONSOLE kaj Default project vo consolata
//dotnet ef migrations add Init
//add - migration Init
// update-database
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
