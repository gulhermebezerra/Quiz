using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppMeuQuiz.Model
{
    public class Questoes : Base.ModelBase
    {
        private string _questao;
        private string _resposta;
        private bool _estaCerto;

        public bool EstaCerto
        {
            get { return _estaCerto; }
            set { _estaCerto = value; OnPropertyChanged(); }
        }


        public string Resposta
        {
            get { return _resposta; }
            set { _resposta = value; OnPropertyChanged(); }
        }


        public string Questao
        {
            get { return _questao; }
            set { _questao = value; OnPropertyChanged(); }
        }

    }
}
