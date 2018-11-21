using FinalMomento3.Dominio;
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
	public partial class ComprasPage : ContentPage
	{
        Producto globalproductos;
        public ComprasPage(Producto producto)
        {
            InitializeComponent();
            BindingContext = producto;
            globalproductos = producto;
        }


        private async void Button_Clicked(object sender, EventArgs e)
        {
            int valor = Convert.ToInt32(MiEntry.Text);
            await Navigation.PushAsync(new DetallePage(globalproductos, valor));
        }
    }
}