using FinalMomento3.Dominio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FinalMomento3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InicioPage : ContentPage
    {
        public InicioPage()
        {
            InitializeComponent();
            CargarProductos();
        }
        private async void CargarProductos()
        {
            HttpClient cartelera = new HttpClient();
            cartelera.BaseAddress = new Uri("http://192.168.56.1");

            var request = await cartelera.GetAsync("/ProyectoYC/api/Producto");

            if (request.IsSuccessStatusCode)
            {
                var responseJson = await request.Content.ReadAsStringAsync();
                var listado = JsonConvert.DeserializeObject<List<Producto>>(responseJson);
                listProductos.ItemsSource = listado;
            }
        }
        private async void Product_Selected(object sender, SelectedItemChangedEventArgs e)
        {
            var funcion = e.SelectedItem as Producto;
            await Navigation.PushAsync(new ComprasPage(funcion));
        }
    }
}