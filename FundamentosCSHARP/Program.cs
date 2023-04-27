using System;
using FundamentosCSHARP.Models;
using FundamentosCSHARP.Service;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Net.Http;
using System.Linq;

namespace FundamentosCSHARP
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cerveza = new Cerveza()
            { Alcohol = 2.4m, Cantidad = 500, Marca = "Colima", Nombre = "Ticus" };

            var post = new Post() { body = "Soy un body", title = "title", userId = 50 };

            Service.SendRequest<Cerveza> service = new Service.SendRequest<Cerveza>();
            var CervezaRespuesta = await service.Send(cerveza);

        }
    }
}