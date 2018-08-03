using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppKilombolas
{
    public class MainPageViewModel
    {
        private ControleApp controle;
        public ICommand DenunciarCommand { get; set; }
        public ICommand CadastrarCommand { get; set; }
        public ICommand SobreCommand { get; set; }
        public ICommand SobreRacismoCommand { get; set; }
        public ICommand ComoCommand { get; set; }

        public MainPageViewModel()
        {
            controle = new ControleApp();
            CadastrarCommand = new Command(Cadastrar_Clicked);
            DenunciarCommand = new Command(Denunciar_Clicked);
            SobreCommand = new Command(Sobre_Clicked);
            SobreRacismoCommand = new Command(SobreRacismo_Clicked);
            ComoCommand = new Command(Como_Clicked);
        }

        private void Cadastrar_Clicked(object obj)
        {
            controle.NavigationApp(new CadastroView());
        }

        private void Denunciar_Clicked(object obj)
        {
            controle.NavigationApp(new FormularioDenuncia());
        }

        private void Sobre_Clicked(object obj)
        {
            controle.NavigationApp(new Sobre());
        }

        private void SobreRacismo_Clicked(object obj)
        {
            controle.NavigationApp(new SobreRacismo());
        }

        private void Como_Clicked(object obj)
        {
            controle.NavigationApp(new Como());
        }

    }
}
