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

            // -----------------------------
            // Add services to the container
            // -----------------------------

            // Application & Infrastructure DI
            builder.Services.AddApplication();
            builder.Services.AddInfrastructure(builder.Configuration);

            // OData + Controllers
            builder.Services.AddControllers()
                .AddOData(opt =>
                    opt.Select().Filter().OrderBy().Expand().Count().SetMaxTop(100)
                       .AddRouteComponents("odata", EdmModelBuilder.GetEdmModel()));

            // Swagger/OpenAPI
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // -----------------------------
            // Configure the HTTP pipeline
            // -----------------------------

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseRouting();
            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
