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
    public class CriarEleicaoViewModel : BindableBase
    {
        INavigationService _navigationService;

        public DelegateCommand CriarVot{ get; set; } 

         
        public CriarEleicaoViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            CriarVot = new DelegateCommand(ExecuteCriarVot); 
        }

        private void ExecuteCriarVot()
        {
            _navigationService.NavigateAsync("EleicaoPage"); // Acessando página da eleição
        }
    }
}
