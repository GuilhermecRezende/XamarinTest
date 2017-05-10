using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new App2.MainPage();
        }

        protected async override void OnStart()
        {
            Class1 c1 = new Class1();
            var text = await c1.GetMy();
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
