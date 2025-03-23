namespace Academico;

public partial class Add : ContentPage
{
	public Add()
	{
		InitializeComponent();
	}

    private async void btnMainOnClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}