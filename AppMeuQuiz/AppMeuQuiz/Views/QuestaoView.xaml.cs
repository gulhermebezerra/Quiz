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
    public partial class QuestaoView : ContentPage
    {
        public QuestaoView()
        {
            InitializeComponent();
            this.BindingContext = new ViewModel.MeuQuizVM();
        }
    }
}