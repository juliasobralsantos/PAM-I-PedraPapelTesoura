using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedraPapelTesoura.Model;
using System.Collections.ObjectModel;
using System.Windows.Input;
using PedraPapelTesoura.Model.Enum;

namespace PedraPapelTesoura.ViewModel
{
    public partial class PedraPapelTesouraViewModel : ObservableObject
    {
        public PedraPapelTesouraViewModel()
        {
            JogarCommand = new Command(Jogar);
        }

        [ObservableProperty]
        private string _nomeJogador;
        [ObservableProperty]
        private int _pontuacaoJogador;
        [ObservableProperty]
        private EscolhaEnum _escolha;

        private ObservableCollection<int> _jogadores = new ObservableCollection<int>();
        public ObservableCollection<int> Jogadores
        {
            get { return _jogadores; }
            set { _jogadores = value; }
        }

        public ICommand JogarCommand { get; }

        public void Jogar()
        {
          Jogador jogador = new Jogador(NomeJogador, PontuacaoJogador, Escolha);
          Jogador maquina = new Jogador("maquina", PontuacaoJogador, Escolha);
        }
    }


}
