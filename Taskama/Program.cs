using DotNetEnv;
using Microsoft.EntityFrameworkCore;
using Taskama;
using Taskama.Context;

// Load .env file
EnvLoader.LoadEnv();
Env.Load();

var builder = WebApplication.CreateBuilder(args);

// Thay thế connection string từ biến môi trường
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection")
    ?.Replace("${DB_HOST}", Environment.GetEnvironmentVariable("DB_HOST"))
    ?.Replace("${DB_NAME}", Environment.GetEnvironmentVariable("DB_NAME"))
    ?.Replace("${DB_USER}", Environment.GetEnvironmentVariable("DB_USER"))
    ?.Replace("${DB_PASS}", Environment.GetEnvironmentVariable("DB_PASS"));

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddDbContext<TaskamaContext>(options =>
    options.UseSqlServer(connectionString)
);

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

app.UseAuthorization();

app.MapRazorPages();

app.Run();