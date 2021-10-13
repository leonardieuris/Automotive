using Automotive;
using System.Collections.Generic;
using System.Linq;

namespace Veicoli
{
    public class Autoveicoli : IVeicolo
    {

        private readonly List<ICarburante> Carburanti;
        private readonly int Posti;

        public Autoveicoli(List<ICarburante> carburanti,int posti)
        {
            Carburanti = carburanti;
            Posti = posti;            
        }

        public Autoveicoli(ICarburante carburante, int posti)
        {
            Carburanti = new List<ICarburante> { carburante };
            Posti = posti;
        }

        public int GetPosti() => Posti;

        public TipologiaVeicolo GetTipologia()
        {
            if (Carburanti.Count > 1)
                return TipologiaVeicolo.Ibrido;
            if (Carburanti.Count < 1)
                return TipologiaVeicolo.Flinstones;

            return Carburanti.First().Ecologico() ? TipologiaVeicolo.Ecologico : TipologiaVeicolo.Non_Ecologico;
        }
    }
}
