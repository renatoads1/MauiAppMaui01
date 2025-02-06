namespace MauiAppMaui01.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}

    private void btnVoltar_Clicked(object sender, EventArgs e)
    {
		App.Current.MainPage = new LoginPage();
    }
}