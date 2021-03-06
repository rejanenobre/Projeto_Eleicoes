﻿using Prism;
using Prism.Ioc;
using appeleicao.ViewModels;
using appeleicao.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace appeleicao
{
    public partial class App
    {
        /* 
         * The Xamarin Forms XAML Previewer in Visual Studio uses System.Activator.CreateInstance.
         * This imposes a limitation in which the App class must have a default constructor. 
         * App(IPlatformInitializer initializer = null) cannot be handled by the Activator.
         */
        public App() : this(null) { }

        public App(IPlatformInitializer initializer) : base(initializer) { }

        protected override async void OnInitialized()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new SplashPage());
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Criando o registro para conseguir navegar pelas páginas

            containerRegistry.RegisterForNavigation<NavigationPage>();
            containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();  
            containerRegistry.RegisterForNavigation<CadastroPage>();
            containerRegistry.RegisterForNavigation<CriarEleicao>();
            containerRegistry.RegisterForNavigation<LoginPage>();
            containerRegistry.RegisterForNavigation<EleicaoPage>();
        }
    }
}
