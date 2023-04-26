using System;
using FundamentosCSHARP.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
namespace FundametosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cerveza cerveza = new Cerveza(10, "Cerveza");

            //string miJson = JsonSerializer.Serialize(cerveza);
            //File.WriteAllText("Objeto.txt", miJson);

            string miJson = File.ReadAllText("Objeto.txt");
            Cerveza cerveza = JsonSerializer.Deserialize<Cerveza>(miJson);

        }
    }
}