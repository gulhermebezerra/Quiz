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
        private List<Model.Questoes> _lstPergunta;

        public List<Model.Questoes> ListaPergunta
        {
            get { return _lstPergunta; }
            set { _lstPergunta = value; }
        }

        public ProdutoQuestaoView(Produto produto_)
        {
            //Produto produto =(Produto) Enum.Parse(typeof(Produto), produto_.ToString());
            this.BindingContext = new ViewModel.MeuQuizVM();
            Initialize();
        }

        private void Initialize()
        {
            InitializeComponent();
            
        }

    }
}