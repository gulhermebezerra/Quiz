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

        private void Button_Clicked(object sender, TappedEventArgs e)
        {
            switch (((TappedEventArgs)e).Parameter.ToString())
            {
                case "Q1":
                    ((Label)sender).BackgroundColor = Color.LightGreen;                    
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = true;
                    this.FindByName<Label>("Q2").BackgroundColor = Color.White;
                    this.FindByName<Label>("Q3").BackgroundColor = Color.White;
                    this.FindByName<Label>("Q4").BackgroundColor = Color.White;
                    break;
                case "Q2":
                    ((Label)sender).BackgroundColor = Color.LightGreen;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    this.FindByName<Label>("Q1").BackgroundColor = Color.White;
                    this.FindByName<Label>("Q3").BackgroundColor = Color.White;
                    this.FindByName<Label>("Q4").BackgroundColor = Color.White;
                    break;
                case "Q3":
                    ((Label)sender).BackgroundColor = Color.LightGreen;
                    this.FindByName<Label>("Q1").BackgroundColor = Color.White;
                    this.FindByName<Label>("Q2").BackgroundColor = Color.White;
                    this.FindByName<Label>("Q4").BackgroundColor = Color.White;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    break;
                case "Q4":
                    ((Label)sender).BackgroundColor = Color.LightGreen;
                    this.FindByName<Label>("Q1").BackgroundColor = Color.White;
                    this.FindByName<Label>("Q2").BackgroundColor = Color.White;
                    this.FindByName<Label>("Q3").BackgroundColor = Color.White;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    break;
                default:
                    break;
            }
        }

        private void VidasResposta(object sender, TappedEventArgs e)
        {
            switch (((TappedEventArgs)e).Parameter.ToString())
            {
                case "VQ1":
                    ((Label)sender).BackgroundColor = Color.LightGreen;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = true;
                    this.FindByName<Label>("VQ2").BackgroundColor = Color.White;
                    this.FindByName<Label>("VQ3").BackgroundColor = Color.White;
                    this.FindByName<Label>("VQ4").BackgroundColor = Color.White;
                    break;
                case "VQ2":
                    ((Label)sender).BackgroundColor = Color.LightGreen;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    this.FindByName<Label>("VQ1").BackgroundColor = Color.White;
                    this.FindByName<Label>("VQ3").BackgroundColor = Color.White;
                    this.FindByName<Label>("VQ4").BackgroundColor = Color.White;
                    break;
                case "VQ3":
                    ((Label)sender).BackgroundColor = Color.LightGreen;
                    this.FindByName<Label>("VQ1").BackgroundColor = Color.White;
                    this.FindByName<Label>("VQ2").BackgroundColor = Color.White;
                    this.FindByName<Label>("VQ4").BackgroundColor = Color.White;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    break;
                case "VQ4":
                    ((Label)sender).BackgroundColor = Color.LightGreen;
                    this.FindByName<Label>("VQ1").BackgroundColor = Color.White;
                    this.FindByName<Label>("VQ2").BackgroundColor = Color.White;
                    this.FindByName<Label>("VQ3").BackgroundColor = Color.White;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    break;
                default:
                    break;
            }
        }

        private void RealResposta(object sender, TappedEventArgs e)
        {
            switch (((TappedEventArgs)e).Parameter.ToString())
            {
                case "RQ1":
                    ((Label)sender).BackgroundColor = Color.LightGreen;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = true;
                    this.FindByName<Label>("RQ2").BackgroundColor = Color.White;

                    break;
                case "RQ2":
                    ((Label)sender).BackgroundColor = Color.LightGreen;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    this.FindByName<Label>("RQ1").BackgroundColor = Color.White;

                    break;
                default:
                    break;
            }
        }

        private void VirtuoResposta(object sender, TappedEventArgs e)
        {
            switch (((TappedEventArgs)e).Parameter.ToString())
            {
                case "VVQ1":
                    ((Label)sender).BackgroundColor = Color.LightGreen;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    this.FindByName<Label>("VVQ2").BackgroundColor = Color.White;
                    this.FindByName<Label>("VVQ3").BackgroundColor = Color.White;
                    this.FindByName<Label>("VVQ4").BackgroundColor = Color.White;
                    break;
                case "VVQ2":
                    ((Label)sender).BackgroundColor = Color.LightGreen;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = true;
                    this.FindByName<Label>("VVQ1").BackgroundColor = Color.White;
                    this.FindByName<Label>("VVQ3").BackgroundColor = Color.White;
                    this.FindByName<Label>("VVQ4").BackgroundColor = Color.White;
                    break;
                case "VVQ3":
                    ((Label)sender).BackgroundColor = Color.LightGreen;
                    this.FindByName<Label>("VVQ1").BackgroundColor = Color.White;
                    this.FindByName<Label>("VVQ2").BackgroundColor = Color.White;
                    this.FindByName<Label>("VVQ4").BackgroundColor = Color.White;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    break;
                case "VVQ4":
                    ((Label)sender).BackgroundColor = Color.LightGreen;
                    this.FindByName<Label>("VVQ1").BackgroundColor = Color.White;
                    this.FindByName<Label>("VVQ2").BackgroundColor = Color.White;
                    this.FindByName<Label>("VVQ3").BackgroundColor = Color.White;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    break;
                default:
                    break;
            }
        }

        private void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {

        }
    }
}