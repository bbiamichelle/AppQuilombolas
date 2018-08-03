using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace AppKilombolas
{
    public partial class FormularioDenuncia : ContentPage
    {
        public FormularioDenuncia()
        {
            InitializeComponent();
        }

        private bool ValidarFormNaoNulo (List<Picker> combo){

            foreach (Picker item in combo){
                if (item.SelectedIndex == -1){
                    DisplayAlert("Atenção", "Selecione um item", "Ok");
                    return false;
                }
            }

            if (!emailValidator.IsValid)
            {
                tipo.BackgroundColor = Color.Red;
                DisplayAlert("Atenção", "Digite um e-mail valído", "Ok");
                return false;
            }

            return true;
        }

        private  void Button_Clicked(object sender, EventArgs e)
        {
            List<Picker> combo = new List<Picker>();
            combo.Add(pessoa);
            combo.Add(tipo);
            combo.Add(etnia);
            combo.Add(genero);
            combo.Add(localQueOcorreu);
            combo.Add(lugaresInformados);

            if (ValidarFormNaoNulo(combo) == true){
                DisplayAlert("Atenção", "Denúncia enviada com sucesso!", "Ok");
            }
        }
    }
}
