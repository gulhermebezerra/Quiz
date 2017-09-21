using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMeuQuiz.ViewModel
{
    public class ConfirmarVM : Base.BaseViewModel
    {


        private string imagem;

        public string Imagem
        {
            get { return imagem; }
            set { imagem = value; }
        }


        public Command JogarNovamenteCMD { get; set; }


        private void Selecionar(Produto p)
        {
            this.NavegarPara(new MainPage());
        }

        public ConfirmarVM(bool value, Produto p)
        {
            Imagem = value ? "Acerto.jpg" : "Erro.jpg";
            this.JogarNovamenteCMD = new Command(() => Selecionar(p));
        }
    }
}
