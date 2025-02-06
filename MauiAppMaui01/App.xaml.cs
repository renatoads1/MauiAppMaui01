using MauiAppMaui01.Pages;

namespace MauiAppMaui01
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new AppShell();
            MainPage = new LoginPage();
        }
    }
}
