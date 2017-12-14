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
                //Chama a API
                MercadoAPI mercado = new MercadoAPI().Obter();

                //Instancia a TbClube
                ClubeTable tbClube = new ClubeTable();
                
                // Pega todos os ClubesResponse e Cria as Entidades de Clube e Salva na Collection
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
