using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace appeleicao.ViewModels
{
    public class MainPageViewModel : BindableBase
    {
        INavigationService _navigationService;

        public DelegateCommand Cadastro{ get; set; }// Comando para ir para o cadastro

        public DelegateCommand Eleicao{get; set;} //Comando para ir para criação da eleição

        public DelegateCommand login { get; set; }

        public MainPageViewModel(INavigationService navigationService)   
        {
            _navigationService = navigationService;  //Instânciando navigationService, para acessar a página do cadastro
            Cadastro = new DelegateCommand(ExecuteCadastro);
            Eleicao = new DelegateCommand(ExecuteEleicao);
            login = new DelegateCommand(ExecuteLogin);
        }

        private void ExecuteLogin()
        {
            _navigationService.NavigateAsync("LoginPage"); // Acessando a página do Login
        }

        private void ExecuteEleicao()
        {
            _navigationService.NavigateAsync("CriarEleicao"); //Acessando a página Eleição
        }

        private void ExecuteCadastro()
        {
            _navigationService.NavigateAsync("CadastroPage"); // Acessando a página cadastro.
        }

    

    }
}
