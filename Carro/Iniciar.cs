using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Builder;
using System.Threading.Tasks;

namespace Carro
{
    public class Iniciar
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(MostraOQueIaNaconsole);
            

        }

        public Task MostraOQueIaNaconsole(HttpContext context)
        {
            Veicolo carro = new Veicolo();

            
            return context.Response.WriteAsync(carro.nome);
           
        }
    }
}