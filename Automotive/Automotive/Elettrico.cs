using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotive
{
    public class Elettrico : Carburante
    {
        public Elettrico() : base("Elettricità")
        {

        }
        protected override bool GetEcologico()
        {
            return true;
        }
    }
}
