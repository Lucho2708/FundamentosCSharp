using System;
using FundamentosCSHARP.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using System.Linq;

namespace FundametosCSHARP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            List<Cerveza> cervezas = new List<Cerveza>()
            {
                new Cerveza(){Alcohol=7, Cantidad=10, Nombre="Pale Ale", Marca="Minerva"},
                new Cerveza(){Alcohol=4.5m, Cantidad=20, Nombre="Aguila", Marca="Bavaria"},
                new Cerveza(){Alcohol=4.5m, Cantidad=50, Nombre="Brava", Marca="Red"},
                new Cerveza(){Alcohol=4.5m, Cantidad=100, Nombre="Poker", Marca="Poker"}

            };
            
            var cervesasOrdenadas = from d in cervezas
                                    orderby d.Nombre
                                    select d;

            foreach (var cerveza in cervesasOrdenadas)
            {
                Console.WriteLine($" {cerveza.Nombre} {cerveza.Marca}");
            }

        }
    }
}