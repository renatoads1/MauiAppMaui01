using MauiAppMaui01.Models;

namespace MauiAppMaui01.Pages;

public partial class RegistrarPage : ContentPage
{
	public List<Usuario> users { get; set; }
	public RegistrarPage()
	{
		InitializeComponent();
		users = new List<Usuario>() { 
			new Usuario{ Id=1,Name="Renato",Senha="321321" },
            new Usuario{ Id=2,Name="Júlia",Senha="321321" },
            new Usuario{ Id=3,Name="Isabela",Senha="321321" },
        };
		BindingContext = this;
	}

    private void btnVoltarHome_Clicked(object sender, EventArgs e)
    {
        App.Current.MainPage = new LoginPage();
    }
}