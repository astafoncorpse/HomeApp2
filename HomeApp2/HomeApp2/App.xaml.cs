using HomeApp2.Pages;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HomeApp2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NewDevicePage(); //new PaddingPage(); new MainPage(); new CsharpPaddingPage();  new LoginPage();  new DevicesPage(); new NewDevicePage(); new RegisterPage();  new DeviceControlPage();
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
