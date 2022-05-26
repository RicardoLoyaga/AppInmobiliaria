using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppInmobiliaria.App
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DetallePropiedad : ContentPage
    {
        public DetallePropiedad()
        {
            InitializeComponent();
            //TomarFoto.Clicked += TomarFoto_Clicked;
        }

        private async void TomarFoto_Clicked(object sender, EventArgs e)
        {
            var photo = await Plugin.Media.CrossMedia.Current.TakePhotoAsync(new Plugin.Media.Abstractions.StoreCameraMediaOptions());

            if(photo != null)
            {
                Foto.Source = ImageSource.FromStream(() => { return photo.GetStream(); });
            }
        }
    }
}