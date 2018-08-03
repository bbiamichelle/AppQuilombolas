using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppKilombolas
{
    public partial class CadastroView : ContentPage
    {
        public CadastroView()
        {
            InitializeComponent();
            BindingContext = new CadastroViewModel();

        }

       
    }
}
