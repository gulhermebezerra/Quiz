using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMeuQuiz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Questao3View : ContentPage
    {
        string Resposta;
        string Texto;

        public Questao3View()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            switch (((Button)sender).CommandParameter.ToString())
            {
                case "1":
                    Resposta = "Correto";
                    Texto = "Parabéns! você acertou!";
                    break;

                case "2":
                case "3":
                case "4":
                case "5":
                    Resposta =
                        "Errou";
                    Texto = "Você errou :-(";
                    break;

                default:
                    break;
            }


            await ShowMessage(Resposta, Texto, "Ok", async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new MainPage());
            });
        }

        public async Task ShowMessage(string message, string title, string buttonText, Action afterHideCallback)
        {
            await DisplayAlert(title, message, buttonText);
            afterHideCallback?.Invoke();
        }
    }
}