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
    public partial class PageInitial : ContentPage
    {
        public PageInitial()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            var pagelog = new Views.PageLogin();
            Navigation.PushAsync(pagelog);
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            Lista.ItemsSource = await App.DBlog.GetListaa();
        }
    }
}