using Automotive;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Veicoli
{
    public class Bus : Autoveicoli
    {
        public Bus(int posti):base(new Gasolio(),posti)
        {

        }

    }
}
