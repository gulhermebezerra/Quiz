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
        private bool _produtoA;
        private bool _produtoB;
        private bool _produtoC;
        private bool _produtoD;

        public bool ProdutoA
        {
            get { return _produtoA; }
            set { _produtoA = value; OnPropertyChanged(); }
        }

        public bool ProdutoB
        {
            get { return _produtoB; }
            set { _produtoB = value; OnPropertyChanged(); }
        }

        public bool ProdutoC
        {
            get { return _produtoC; }
            set { _produtoC = value; OnPropertyChanged(); }
        }

        public bool ProdutoD
        {
            get { return _produtoD; }
            set { _produtoD = value; OnPropertyChanged(); }
        }

        public ProdutoQuestaoView(Produto produto_)
        {
            this.ProdutoA = produto_ == Produto.Filmarray;
            this.ProdutoB = false;
            this.ProdutoC = false;
            this.ProdutoD = false;

            this.BindingContext = new ViewModel.MeuQuizVM();
            Initialize();
        }

        private void Initialize()
        {
            InitializeComponent();
            
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

        }
    }
}