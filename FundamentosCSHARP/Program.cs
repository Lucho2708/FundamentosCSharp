using System;
using FundamentosCSHARP.Models;
namespace FundametosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {

            CervezaBD cervezaBD = new CervezaBD();
            //Incertamos nueva cerveza
            //{
            //    Cerveza cerveza = new Cerveza(15, "Pale ale");
            //    cerveza.Marca = "Minerva";
            //    cerveza.Alcohol = 6;
            //    cervezaBD.Add(cerveza);
            //}

            {
                cervezaBD.Delete(12);
                
            }

            var cervezas = cervezaBD.Get();

            foreach (var item in cervezas)
            {
                Console.WriteLine(item.Nombre);
            }
        }
    }
}