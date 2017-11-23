using Cartola.Dominio.Modelos;
using Cartola.Repositorio.Colecoes;
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
                MercadoAPI mercado = new MercadoAPI().Obter();
                ClubeTable tbClube = new ClubeTable();
                

                mercado.Clubes.ToList().ForEach(x => {
                    tbClube.Salvar(new Clube(x.Value.Id,
                                             x.Value.Nome,
                                             x.Value.Abreviacao,
                                             new Escudo(x.Value.Escudos.Escudo60,
                                                        x.Value.Escudos.Escudo45,
                                                        x.Value.Escudos.Escudo30)));
                });
      

            }
            catch (Exception e)
            {

                throw e;
            }

            
        }
    }
}
