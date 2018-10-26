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
        public Command Cadastro{ get; set; }
        public MainPageViewModel()   
        {

            Cadastro = new Command(ExecuteCadastro);
        }

        private void ExecuteCadastro(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
