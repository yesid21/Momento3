using FinalMomento3.Dominio;
using FinalMomento3.Resources;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalMomento3.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetallePage : ContentPage
    {
        public DetallePage( Producto producto, int valor)
        {
            int total = valor * (producto.Precio);
            InitializeComponent();
            carteleral.BindingContext = producto;
            lbltotal.Text = Convert.ToString(total);
            Label21.Text = Convert.ToString(valor);
            stackLayout.BindingContext = producto;
        }

        private void Confirmar(object sender, EventArgs e)
        {
            DisplayAlert(AppResources.Compra, AppResources.LaCompraSeAhGeneradoCorrectamente, AppResources.Continuar);

        }

        private async void Camara_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Camara ());
        }
    }
}