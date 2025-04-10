namespace Academico;

public partial class Cadastro : ContentPage
{
	public Cadastro()
	{
		InitializeComponent();
	}

    private async void btnMainOnClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}