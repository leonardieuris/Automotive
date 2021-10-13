using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Automotive
{
    public abstract class Carburante : ICarburante
    {
        private readonly string Nome;

        public Carburante(string nome)
        {
            Nome = nome;
        }
        public string GetNome()
        {
            return Nome;
        }

        public bool Ecologico()
        {
            return GetEcologico();
        }

        protected abstract bool GetEcologico();
    }
}
