using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 Criar um Builder
            var builder = WebApplication.CreateBuilder();

            //2 Configurara o Builder
            builder.Services.AddControllers();

            //3 Construir a Aplicação
            var app = builder.Build();

            //4 Rodar a Aplicação
            app.MapControllers();

            //5 Iniciar a Aplicação
            app.Run();
        }
    }
}
