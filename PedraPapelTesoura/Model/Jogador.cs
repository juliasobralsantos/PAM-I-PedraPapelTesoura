using PedraPapelTesoura.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedraPapelTesoura.Model
{
    public class Jogador
    {
        public string NomeJogador { get; set; }
        public int PontuacaoJogador { get; set; }
        public EscolhaEnum Escolha { get; set; }

        public Jogador(string nomeJogador, int pontuacaoJogador, EscolhaEnum escolha)
        {
            NomeJogador = nomeJogador;
            PontuacaoJogador = pontuacaoJogador;
            Escolha = escolha;
        }
    }
}
