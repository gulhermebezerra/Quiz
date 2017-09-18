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

        private void Button_Clicked(object sender, EventArgs e)
        {
            switch (((Button)sender).CommandParameter.ToString())
            {
                case "Q1":
                    ((Button)sender).BackgroundColor = Color.LightGreen;                    
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = true;
                    this.FindByName<Button>("Q2").BackgroundColor = Color.White;
                    this.FindByName<Button>("Q3").BackgroundColor = Color.White;
                    this.FindByName<Button>("Q4").BackgroundColor = Color.White;
                    break;
                case "Q2":
                    ((Button)sender).BackgroundColor = Color.LightGreen;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    this.FindByName<Button>("Q1").BackgroundColor = Color.White;
                    this.FindByName<Button>("Q3").BackgroundColor = Color.White;
                    this.FindByName<Button>("Q4").BackgroundColor = Color.White;
                    break;
                case "Q3":
                    ((Button)sender).BackgroundColor = Color.LightGreen;
                    this.FindByName<Button>("Q1").BackgroundColor = Color.White;
                    this.FindByName<Button>("Q2").BackgroundColor = Color.White;
                    this.FindByName<Button>("Q4").BackgroundColor = Color.White;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    break;
                case "Q4":
                    ((Button)sender).BackgroundColor = Color.LightGreen;
                    this.FindByName<Button>("Q1").BackgroundColor = Color.White;
                    this.FindByName<Button>("Q2").BackgroundColor = Color.White;
                    this.FindByName<Button>("Q3").BackgroundColor = Color.White;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    break;
                default:
                    break;
            }
        }

        private void Q1_Unfocused(object sender, FocusEventArgs e)
        {

        }

        private void VidasResposta(object sender, EventArgs e)
        {
            switch (((Button)sender).CommandParameter.ToString())
            {
                case "VQ1":
                    ((Button)sender).BackgroundColor = Color.LightGreen;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = true;
                    this.FindByName<Button>("VQ2").BackgroundColor = Color.White;
                    this.FindByName<Button>("VQ3").BackgroundColor = Color.White;
                    this.FindByName<Button>("VQ4").BackgroundColor = Color.White;
                    break;
                case "VQ2":
                    ((Button)sender).BackgroundColor = Color.LightGreen;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    this.FindByName<Button>("VQ1").BackgroundColor = Color.White;
                    this.FindByName<Button>("VQ3").BackgroundColor = Color.White;
                    this.FindByName<Button>("VQ4").BackgroundColor = Color.White;
                    break;
                case "VQ3":
                    ((Button)sender).BackgroundColor = Color.LightGreen;
                    this.FindByName<Button>("VQ1").BackgroundColor = Color.White;
                    this.FindByName<Button>("VQ2").BackgroundColor = Color.White;
                    this.FindByName<Button>("VQ4").BackgroundColor = Color.White;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    break;
                case "VQ4":
                    ((Button)sender).BackgroundColor = Color.LightGreen;
                    this.FindByName<Button>("VQ1").BackgroundColor = Color.White;
                    this.FindByName<Button>("VQ2").BackgroundColor = Color.White;
                    this.FindByName<Button>("VQ3").BackgroundColor = Color.White;
                    ((ViewModel.MeuQuizVM)this.BindingContext).EstaCerto = false;
                    break;
                default:
                    break;
            }
        }
    }
}