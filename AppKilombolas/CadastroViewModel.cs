using System;
using System.Windows.Input;
using Xamarin.Forms;
using System.Net;
using System.Net.Http;

namespace AppKilombolas
{
    public class CadastroViewModel : ViewModelBase
    {
        private ControleApp _controle;
        private string txtNome;
        private string txtEmail;
        private string txtSexo;
        private DateTime txtDataNascimento;
        public ICommand EnviarCommand { get; set; }

        public string TxtNome
        {
            get { return txtNome; }
            set{
                txtNome = value;
                Notify("TxtNome");
                
            }

        }

        public string TxtEmail
        {
            get { return txtEmail; }
            set
            {
                txtEmail = value;
                Notify("TxtEmail");

            }

        }
        public string TxtSexo
        {
            get { return txtSexo; }
            set
            {
                txtSexo = value;
                Notify("TxtSexo");

            }

        }
        public DateTime TxtDataNascimento
        {
            get { return txtDataNascimento; }
            set
            {
                txtDataNascimento = value;
                Notify("TxtDataNascimento");

            }

        }

         public CadastroViewModel()
        {
            _controle = new ControleApp();
            EnviarCommand = new Command(Enviar_Clicked);
        }

        private void Enviar_Clicked(object obj)
        {
            using( var client = new HttpClient()){
                
            }
        }
     
    }
}
