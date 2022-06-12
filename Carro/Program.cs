using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carro
{
    class Program
    {
        static void Main(string[] args)
        {
            new Veicolo();

            Console.WriteLine("teste");

            IWebHost hospedeiro = new WebHostBuilder()
                .UseKestrel()
                .UseStartup<Iniciar>()
                .Build();

            hospedeiro.Run();

        }
    }
}
