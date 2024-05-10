global using CurrencyExchangeCalculator.Model;
global using CurrencyExchangeCalculator.Data;
global using Microsoft.EntityFrameworkCore;
global using Microsoft.AspNetCore.Components;
global using Radzen;

namespace CurrencyExchangeCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddHttpClient();
            //database connection
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection")
                ));
            //connection with nbp api
            builder.Services.AddHttpClient("nbp", a =>
            {
                a.BaseAddress = new Uri("https://api.nbp.pl/api/exchangerates/tables/A/?format=json");
            });
            //Blazored Radzen components
            builder.Services.AddRadzenComponents();

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

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}
