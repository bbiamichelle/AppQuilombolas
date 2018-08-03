using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AppKilombolas
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            BindingContext = new MainPageViewModel();
          
        }


      //  private  void Button_Clicked(object sender, EventArgs e)
        //{
          //  Navigation.PushAsync(new FormularioDenuncia());
        //}

        //private void Cadastrar_Clicked(object sender, EventArgs e)
        //{
          //  Navigation.PushAsync(new CadastroView());
        //}

    }
}
