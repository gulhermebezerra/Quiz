using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMeuQuiz.ViewModel
{
    public class MeuQuizVM : Base.BaseViewModel
    {

        private List<Model.Questoes> _meuQuiz;
        private Model.Questoes _quiz;
        private bool? _estaCerto;


        public bool? EstaCerto
        {
            get { return _estaCerto; }
            set { _estaCerto = value; OnPropertyChanged(); }
        }

        private bool _produtoA;
        private bool _produtoB;
        private bool _produtoC;
        private bool _produtoD;
        private Produto produto_;
        private string _logoQuestao;

        public string LogoQuestao
        {
            get { return _logoQuestao; }
            set { _logoQuestao = value; OnPropertyChanged(); }
        }


        private Color _questao1Color;

        public Color Questao1Color
        {
            get { return _questao1Color; }
            set { _questao1Color = value; OnPropertyChanged(); }
        }


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


        public Command TelaQuestoesCMD { get; set; }
        public Command TelaProdutoQuestaoCMD { get; set; }
        public Command ValidarQuestaoCMD { get; set; }
        public Command SelecionarQuestaoCMD { get; set; }

        public MeuQuizVM()
        {
            this.TelaQuestoesCMD = new Command(() => this.NavegarPara(new Views.QuestaoView()));
            this.TelaProdutoQuestaoCMD = new Command((object produto_) => this.NavegarPara(new Views.ProdutoQuestaoViewA((Produto)Enum.Parse(typeof(Produto), produto_.ToString()))));
                   
        }

        public MeuQuizVM(Produto produto_)
        {
            this.ProdutoA = produto_ == Produto.Filmarray;
            LogoQuestao = produto_ == Produto.Filmarray ? "layout_Film.jpg" : LogoQuestao;

            this.ProdutoB = produto_ == Produto.Real;
            LogoQuestao = produto_ == Produto.Real ? "layout_Real.jpg" : LogoQuestao;

            this.ProdutoC = produto_ == Produto.Vidas;
            LogoQuestao = produto_ == Produto.Vidas ? "layout_Vidas.jpg" : LogoQuestao;

            this.ProdutoD = produto_ == Produto.Virtuo;
            LogoQuestao = produto_ == Produto.Virtuo ? "layout_Virtuo.jpg" : LogoQuestao;

            this.produto_ = produto_;

            this.SelecionarQuestaoCMD = new Command((object obj) => this.SelecionarQuestao(obj));
            this.ValidarQuestaoCMD = new Command(() => ValidarQuestao());
        }

        private void ValidarQuestao()
        {
            if (EstaCerto != null) {
                this.NavegarPara(new Views.ConfirmarView(EstaCerto.Value, produto_));
            }
            else
            {
                var toast = DependencyService.Get<IToastMessage>();
                toast.LongAlert("Selecione uma resposta!");
            }
        }

        public void SelecionarQuestao(object obj)
        {
            this.Questao1Color = Color.Green;
            this.EstaCerto= bool.Parse(obj.ToString());
        }

    }
}
