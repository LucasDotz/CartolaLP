using Cartola.Sincronizador.ModelosAPIs;
using Cartola.Sincronizador.ModelosAPIs.Clube;
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
            try
            {
                MercadoAPI j = new MercadoAPI().Obter();
      

            }
            catch (Exception e)
            {

                throw e;
            }

            
        }
    }
}
