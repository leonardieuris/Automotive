using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotive
{
    public class Gasolio : Carburante
    {
        public Gasolio(): base("Gasolio")
        {

        }
        protected override bool GetEcologico()
        {
            return false;
        }
    }
}
