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
        private List<Resposta> _resposta;
        private Produto _produto;

        public Produto Produto
        {
            get { return _produto; }
            set { _produto = value; OnPropertyChanged(); }
        }

        public List<Resposta> Resposta
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

    public class Resposta : Base.ModelBase
    {
        private string _texto;
        private bool _estaCerto;

        public bool EstaCerto
        {
            get { return _estaCerto; }
            set { _estaCerto = value; OnPropertyChanged(); }
        }


        public string Texto
        {
            get { return _texto; }
            set { _texto = value; OnPropertyChanged(); }
        }

    }
}
