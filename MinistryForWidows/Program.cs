using Azure.Identity;
using Microsoft.EntityFrameworkCore;
using MinistryForWidows.Domain.Repositories;
using MinistryForWidows.Persistence;
using MinistryForWidows.Persistence.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Configuration
    .AddEnvironmentVariables()
    .AddAzureKeyVault(
        new Uri(builder.Configuration["AzureKeyVault"].ToString()),
        new DefaultAzureCredential()
    );

builder.Services.AddDbContext<MinistryForWidowsDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddScoped<IPageRepository, PageRepository>();


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
