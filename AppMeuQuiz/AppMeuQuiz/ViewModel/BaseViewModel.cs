using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppMeuQuiz.ViewModel.Base
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected void NavegarPara(Page Tela)
        {
            Xamarin.Forms.Application.Current.MainPage.Navigation.PushAsync(Tela, true);
            NavigationPage.SetHasNavigationBar(Tela, false);
        }

        public async Task ShowMessage(string message, string title, string buttonText, Action afterHideCallback)
        {            
            await Xamarin.Forms.Application.Current.MainPage.DisplayAlert(title, message, buttonText);
            afterHideCallback?.Invoke();
        }
    }
}
