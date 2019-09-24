using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Apnoiapp.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Apnoiapp
{
    public partial class App : Application
    {
        public MainPage RootPage { get => Application.Current.MainPage as MainPage; }

        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
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
