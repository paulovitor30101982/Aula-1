using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace Aula1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder();
            // Adiciona na Injeção de Dependência
            builder.Services.AddControllers();
            builder.Services.AddRazorPages();
            builder.Services.AddSignalR();

            var app = builder.Build();
            app.MapControllers();
            app.MapRazorPages();
            app.MapHub<ChatHub>("/chathub");
            app.Run();
        }
    }
}
