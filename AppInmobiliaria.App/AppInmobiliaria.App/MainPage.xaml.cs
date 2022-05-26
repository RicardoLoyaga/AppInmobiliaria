using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppInmobiliaria.App
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;
            if (!string.IsNullOrEmpty(usuario) && !string.IsNullOrEmpty(contrasena))
            {
                if (usuario == "administrador@prueba.com" && contrasena == "12345678")
                {
                    await Navigation.PushAsync(new Propiedad());
                }
                else
                {
                    await DisplayAlert("Alerta! ", "Usuario/Contraseña incorrecta", "OK");
                }
            }
            else
            {
                await DisplayAlert("Alerta! ", "Usuario/Contraseña no puede ser vacia", "OK");
            }
        }
    }
}


