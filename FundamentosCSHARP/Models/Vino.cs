﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
    class Vino : Bebida, IBebidaAlcoholica
    {
        public decimal Alcohol { get; set; }
        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo permitido son 3 copas");
        }
        //public Vino(int Cantidad, string Nombre = "Vino")
        //    : base(Nombre, Cantidad)
        //{

        //}

    }
}
