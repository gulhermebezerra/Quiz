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
    public partial class ProdutoQuestaoView : ContentPage
    {


        public ProdutoQuestaoView(Produto produto_)
        {
            this.BindingContext = new ViewModel.MeuQuizVM(produto_);
            Initialize();
        }

        private void Initialize()
        {
            InitializeComponent();
            
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            switch (((Button)sender).CommandParameter.ToString())
            {
                case "Q1":
                    ((Button)sender).BackgroundColor = Color.LightGreen;
                    var vm  = new ViewModel.MeuQuizVM();
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = true;                    
                    break;
                case "Q2":
                    ((Button)sender).BackgroundColor = Color.LightGreen;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    break;
                case "Q3":
                    ((Button)sender).BackgroundColor = Color.LightGreen;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    break;
                case "Q4":
                    ((Button)sender).BackgroundColor = Color.LightGreen;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    break;
                default:
                    break;
            }
        }

        private void Q1_Unfocused(object sender, FocusEventArgs e)
        {

        }
    }
}