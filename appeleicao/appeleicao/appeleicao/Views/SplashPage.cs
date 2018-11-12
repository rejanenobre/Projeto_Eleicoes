using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;


namespace appeleicao.Views
{
    public class SplashPage:ContentPage
    {
        Image splashImage;
        public SplashPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            splashImage = new Image 
            {
                Source = "logoinclude.png",
                WidthRequest = 100,
                HeightRequest = 100
            };
            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional); // Regula o posicionamento da foto
            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize)); // Regula o posicionamento da foto
            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#ffd700"); // Cor do plano de fundo
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await splashImage.ScaleTo(1, 2000); // Tempo de duração da transição
            Application.Current.MainPage = new NavigationPage(new MainPage()); // Ir para página principal após a apresentação
        }
    }
}
