namespace Academico;

public partial class up : ContentPage
{
	public up()
	{
		InitializeComponent();
	}

    private async void btnMainOnClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}