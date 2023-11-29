using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Tournament.Data.Data;
using Tournament.Api.Extensions;

namespace Tournament.Api
{
    public class Program
    {
        public static async void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddDbContext<Context>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("Context") ?? throw new InvalidOperationException("Connection string 'Context' not found.")));

            builder.Services.AddControllers();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddControllers(Opt => Opt.ReturnHttpNotAcceptable = true)
                .AddNewtonsoftJson()
                .AddXmlDataContractSerializerFormatters();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
                await app.SeedDataAsync();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
