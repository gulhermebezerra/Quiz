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


        public Command TelaQuestoesCMD { get; set; }
        public Command TelaProdutoQuestaoCMD { get; set; }


        public MeuQuizVM()
        {
            this.TelaQuestoesCMD = new Command(() => this.NavegarPara(new Views.QuestaoView()));
            this.TelaProdutoQuestaoCMD = new Command(
                (object produto_) =>
                this.NavegarPara(new Views.ProdutoQuestaoView((Produto)Enum.Parse(typeof(Produto), produto_.ToString()))));
        }

    }
}
