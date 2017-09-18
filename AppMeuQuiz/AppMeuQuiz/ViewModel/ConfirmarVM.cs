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


        public Command JogarNovamente { get; set; }


        public ConfirmarVM()
        {
            this.JogarNovamente = new Command(() => Application.Current.MainPage.SendBackButtonPressed());
        }

        public ConfirmarVM(bool value)
        {
            Imagem = value ? "Acerto.jpg" : "Erro.jpg";
        }
    }
}
