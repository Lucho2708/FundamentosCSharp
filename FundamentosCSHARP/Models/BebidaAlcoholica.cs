using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
    interface IBebidaAlcoholica
    {
        public decimal Alcohol { get; set; }

        public void MaxRecomendado();
    }
}
