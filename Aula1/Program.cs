using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder();
            builder.Services.AddControllers();

            var app = builder.Build();
            app.MapControllers();

            app.Run();
        }
    }
}
