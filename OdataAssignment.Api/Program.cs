using Microsoft.AspNetCore.OData;
using OdataAssignment.Api.ModelBuilder;
using OdataAssignment.Application.DI;
using OdataAssignment.Infrastructure.DI;

namespace OdataAssignment.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Application & Infrastructure DI
            builder.Services.AddApplication();
            builder.Services.AddInfrastructure(builder.Configuration);

            // OData + Controllers
            builder.Services.AddControllers()
                .AddOData(opt =>
                    opt.Select()
                       .Filter()
                       .OrderBy()
                       .Expand()
                       .Count()
                       .SetMaxTop(null)
                       .EnableQueryFeatures()
                       .AddRouteComponents("odata", EdmModelBuilder.GetEdmModel()));

            // Swagger/OpenAPI
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowVite",
                    policy => policy
                        .WithOrigins("http://localhost:5173") 
                        .AllowAnyHeader()
                        .AllowAnyMethod()
                        .AllowCredentials());
            });

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("AllowVite");

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
