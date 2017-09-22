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
        static readonly MainPage _instance = new MainPage();
        public static MainPage Instance
        {
            get
            {
                return _instance;
            }
        }
        private MainPage()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel.MeuQuizVM();
            NavigationPage.SetHasNavigationBar(this, false);

        }
    }
}
