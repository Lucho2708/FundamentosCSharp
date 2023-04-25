using System;
using FundamentosCSHARP.Models;
namespace FundametosCSHARP
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[10] {1,2,3,4,5,6,7,8,9,10};

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);
            }

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("****************************************");
            List<int> lista = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8};
            lista.Add(9);
            lista.Add(10);
            lista.Remove(2);

            foreach (var item in lista)
            {
                Console.WriteLine("Elemento: "+item);
            }

            List<Cerveza> cervezas = new List<Cerveza>() { new Cerveza(10, "Cerveza premiun") };
            cervezas.Add(new Cerveza(500, "Aguila"));
            Cerveza erdinger = new Cerveza(500, "Cerveza de trigo");
            cervezas.Add(erdinger);

            foreach (var item in cervezas)
            {
                Console.WriteLine("Cerveza: " + item.Nombre);
            }
        }
    }
}