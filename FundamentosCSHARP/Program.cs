using System;
using FundamentosCSHARP.Models;
namespace FundametosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            Cerveza cerveza = new Cerveza(1000);
            cerveza.Beberse(200);
            Console.WriteLine(cerveza.Cantidad);
        }
    }
}