using Cartola.Dominio.Modelos;
using Cartola.Repositorio.Colecoes;
using Cartola.Sincronizador.ContratoServico;
using Cartola.Sincronizador.ModelosAPIs;
using Cartola.Sincronizador.ModelosAPIs.Posicao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cartola.Servico
{
    public class ServicoGerenciadorDeSincronizacao : IServicoGerenciadorDeSincronizacao
    {
        MercadoAPI _APIMercado;

        ClubeTable _tbClube;
        JogadorTable _tbJogador;

        public ServicoGerenciadorDeSincronizacao()
        {
            _tbClube = new ClubeTable();
            _tbJogador = new JogadorTable();
        }

        public void ObterInformacoesClubes()
        {
            _APIMercado = new MercadoAPI().Obter();

            Clube clube;
            Jogador jogador;
            Posicao posicao;

            _APIMercado.Clubes.ToList().ForEach(x => {

                clube = new Clube(x.Value.Id,
                                  x.Value.Nome,
                                  x.Value.Abreviacao,
                                  new Escudo(x.Value.Escudos.Escudo60,
                                             x.Value.Escudos.Escudo45,
                                             x.Value.Escudos.Escudo30));

                _APIMercado.Atletas.ToList()
                               .Where(y => y.Clube == x.Value.Id).ToList()
                                    .ForEach(z => {

                                        PosicoesResponse posResponse = _APIMercado.Posicoes.ToList().First(a => a.Key == z.Posicao.ToString()).Value;

                                        posicao = new Posicao(posResponse.Id,
                                                              posResponse.Nome,
                                                              posResponse.Abreviacaos);


                                        jogador = new Jogador(z.Nome,
                                                              z.Apelido,
                                                              z.Foto,
                                                              z.Atleta,
                                                              clube,
                                                              posicao,
                                                              z.Pontos,
                                                              z.Preco,
                                                              z.Variacao,
                                                              z.Media,
                                                              z.Jogos);

                                        clube.AddJogador(jogador);

                                    });

                _tbClube.Salvar(clube);

            });


        }
    }
}
