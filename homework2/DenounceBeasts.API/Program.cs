using Microsoft.EntityFrameworkCore;
using Consultorio.Infrastructure.Context;
using Consultorio.Infrastructure.Interface;
using Consultorio.Infrastructure.Repositories;
using Consultorio.Application.Contract;
using Consultorio.Application.Service;

namespace Consultorio.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

 
            builder.Services.AddDbContext<ConsultorioDbContext>(options =>
            {
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            });


            builder.Services.AddScoped<IMedicoRepository, MedicoRepository>();

            
            builder.Services.AddScoped<IMedicoService, MedicoService>();


           
            builder.Services.AddControllers();


            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
