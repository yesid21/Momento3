using FinalMomento3.Dominio;
using FinalMomento3.Resources;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalMomento3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();

        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var usuario = new Login
            {
                Usuario = UsuarioEntry.Text,
                Password = PasswordEntry.Text
            };

            var isValid = AreCredentialsCorrect(usuario);
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new InicioPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
               await DisplayAlert(AppResources.Compra, AppResources.ElUsuarioYOContraseñaNoEsPermitido, AppResources.Continuar);
                PasswordEntry.Text = string.Empty;
            }
        }

        bool AreCredentialsCorrect(Login usuario)
        {
            return usuario.Usuario == Constants.Username && usuario.Password == Constants.Password;

        }
    }
}