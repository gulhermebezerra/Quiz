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
        private bool _estaCerto;


        public bool EstaCerto
        {
            get { return _estaCerto; }
            set { _estaCerto = value; OnPropertyChanged(); }
        }       


        
        public Command TelaQuestoesCMD { get; set; }
        public Command TelaProdutoQuestaoCMD { get; set; }
        public Command ValidarQuestaoCMD { get; set; }
        public Command SelecionarQuestaoCMD { get; set; }

        public MeuQuizVM()
        {
            this.TelaQuestoesCMD = new Command(() => this.NavegarPara(new Views.QuestaoView()));
            this.TelaProdutoQuestaoCMD = new Command((object produto_) => this.NavegarPara(new Views.ProdutoQuestaoView((Produto)Enum.Parse(typeof(Produto), produto_.ToString()))));
            
            this.SelecionarQuestaoCMD = new Command((object obj) => this.SelecionarQuestao(obj));
            this.ValidarQuestaoCMD = new Command(() => this.NavegarPara(new Views.ConfirmarView(EstaCerto)));            
        }


        private void SelecionarQuestao(object obj)
        {
            this.EstaCerto= bool.Parse(obj.ToString());
        }

    }
}
