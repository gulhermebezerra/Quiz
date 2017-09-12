using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMeuQuiz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            switch (((Button)sender).CommandParameter.ToString())
            {
                case "1":
                    App.Current.MainPage.Navigation.PushAsync(new Views.Questao1View());
                    break;

                case "2":
                    App.Current.MainPage.Navigation.PushAsync(new Views.Questao2View());
                    break;

                case "3":
                    App.Current.MainPage.Navigation.PushAsync(new Views.Questao3View());
                    break;

                case "4":
                    App.Current.MainPage.Navigation.PushAsync(new Views.Questao4View());
                    break;

                default:
                    break;
            }
        }
    }
}
