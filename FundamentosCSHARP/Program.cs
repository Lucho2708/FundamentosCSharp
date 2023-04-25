using System;
using FundamentosCSHARP.Models;
namespace FundametosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
           CervezaBD cervezaBD = new CervezaBD();
            var cervezas = cervezaBD.Get();

            foreach (var item in cervezas)
            {
                Console.WriteLine(item.Nombre);
            }
        }
    }
}