using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Login.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageLogin : ContentPage
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private async void btnmostrar_Clicked(object sender, EventArgs e)
        {
            var infor = new Models.Info
            {
                nombre = txtnombre.Text,
                apellidos = txtapellidos.Text,
                correo = txtcorreo.Text,
                edad = cbedad.SelectedItem.ToString()
            };


            var page = new Views.PageCargInfo();
            page.BindingContext = infor;
            await Navigation.PushAsync(page);
        }
        }
    }