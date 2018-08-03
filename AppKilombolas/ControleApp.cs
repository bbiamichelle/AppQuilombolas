using System;
using Xamarin.Forms;

namespace AppKilombolas
{
    public class ControleApp
    {
        public void Message(string msg)
        {
            App.Current.MainPage.DisplayAlert("Atenção!", msg,"Ok");
        }

        public async void NavigationApp(Page page){
            await App.Current.MainPage.Navigation.PushAsync(page,true);
        }
    }
}
