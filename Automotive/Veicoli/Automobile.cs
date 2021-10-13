using Automotive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli
{
    public class Automobile : Autoveicoli
    {
        public Automobile(List<ICarburante> carburanti, int posti) : base(carburanti, posti)
        {
        }

        public Automobile(ICarburante carburante, int posti) : base(carburante, posti)
        {
        }
    }
}
