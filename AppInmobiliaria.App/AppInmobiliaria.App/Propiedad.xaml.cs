using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppInmobiliaria.App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Propiedad : ContentPage
    {
        private const string Url = "https://192.168.0.109:44380/api/Servicios/ObtenerClientes";
        private readonly HttpClient client = new HttpClient();
        private ObservableCollection<DatosPropiedad> _post;

        public Propiedad()//(string user)
        {
            InitializeComponent();
            //lblUser.Text = "Bienvenido " + user;
        }

        private void btnDetalle_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DetallePropiedad());
        }

        private void btnDetalle2_Clicked(object sender, EventArgs e)
        {

        }

        /*private async void btnObtenerPropiedades_Clicked(object sender, EventArgs e)
        {
            var content = await client.GetStringAsync(Url);
            List<DatosPropiedad> posts = JsonConvert.DeserializeObject<List<DatosPropiedad>>(content);
            _post = new ObservableCollection<DatosPropiedad>(posts);

            MyListView.ItemsSource = _post;
        }*/
    }
}