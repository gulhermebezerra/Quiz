using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppMeuQuiz
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();           
            MainPage = new NavigationPage(AppMeuQuiz.MainPage.Instance);            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }


    }

    public enum Produto
    {
        Filmarray,
        Vidas,
        Virtuo,
        Real

    }
}
