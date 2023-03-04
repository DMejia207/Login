using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace Login
{
    public partial class App : Application
    {
        static Controllers.LoginController dblog;

        public static Controllers.LoginController DBlog
        {
            get
            {
                if (dblog == null)
                {
                    var dbpath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
                    var dbname = "Login.db3";
                    dblog = new Controllers.LoginController(Path.Combine(dbpath, dbname));

                }
                return dblog;
            }

        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Views.PageInitial());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
