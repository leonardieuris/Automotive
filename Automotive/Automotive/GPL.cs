using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotive
{
    public class GPL : Carburante
    {
        public GPL() : base("Gpl")
        {

        }
        protected override bool GetEcologico()
        {
            return true;
        }
    }
}
