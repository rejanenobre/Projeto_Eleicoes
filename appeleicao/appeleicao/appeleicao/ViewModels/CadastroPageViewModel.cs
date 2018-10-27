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
    public class CadastroPageViewModel: BindableBase
    {
        INavigationService _navigationService;

        public DelegateCommand mainpage{ get; set; }

        public CadastroPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            mainpage = new DelegateCommand(acess_mainpage);

        }

        private void acess_mainpage()
        {
            _navigationService.NavigateAsync("MainPage"); // Voltar para página principal
        }
    }
}
