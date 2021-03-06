﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppMeuQuiz.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfirmarView : ContentPage
    {
        public ConfirmarView()
        {
            InitializeComponent();
        }

        public ConfirmarView(bool value_,Produto produto_)
        {
            InitializeComponent();
            this.BindingContext = new ViewModel.ConfirmarVM(value_, produto_);
        }
    }
}