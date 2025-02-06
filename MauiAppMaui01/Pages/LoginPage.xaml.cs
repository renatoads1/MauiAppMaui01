namespace MauiAppMaui01.Pages;

public partial class LoginPage : ContentPage
{
	public LoginPage()
	{
		InitializeComponent();
	}

    private void btnLogin_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new HomePage();
        //DisplayAlert("Alert", "Clocou no botão Login","Cancelar");
    }

    private void btnRegistrar_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new RegistrarPage();
        //DisplayAlert("Alert", "Clocou no botão Registrar","Cancelar");
    }
}