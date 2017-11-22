using Cartola.Sincronizador.ModelosAPIs;
using Cartola.Sincronizador.ServicoRest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Sincronizador.Console
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Requisitor<Mercado> requisitor = new Requisitor<Mercado>("https://api.cartolafc.globo.com");

            try
            {
                Mercado j = new Mercado().Obter();
            }
            catch (Exception e)
            {

                throw e;
            }

            
        }
    }
}
