using Automotive;
using System;
using System.Collections.Generic;
using Veicoli;

namespace StazioneDiServizio
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = Test();

            foreach (var veicolo in lista)
            {
                Console.WriteLine(veicolo.GetTipologia());
            }

        }

        private static List<Autoveicoli> Test()
        {
            var ibridoBenzina = new List<ICarburante>();
            var ibridoGPL = new List<ICarburante>();
            

            var gasolio = new Gasolio();
            var benzina = new Benzina();
            var elettrico = new Elettrico();
            var gpl = new GPL();

            ibridoBenzina.Add(benzina);
            ibridoBenzina.Add(elettrico);


            ibridoGPL.Add(benzina);
            ibridoGPL.Add(gpl);



            var autoibrida = new Automobile(ibridoBenzina,5);
            var autoibrida2 = new Automobile(ibridoGPL, 4);
            var autobenzina = new Automobile(benzina, 2);

            var autogasolio = new Automobile(gasolio, 5);
            var autobus = new Bus(55);

            var tesla = new Automobile(elettrico, 5);

            var listaAuto = new List<Autoveicoli>();

            listaAuto.Add(autoibrida);
            listaAuto.Add(autoibrida2);
            listaAuto.Add(autobenzina);
            listaAuto.Add(autogasolio);
            listaAuto.Add(autobus);
            listaAuto.Add(tesla);

            return listaAuto;

        }
    }
}
