namespace Academico;

public partial class Periodos : ContentPage
{
	public Periodos()
	{
		InitializeComponent();
	}

	private async void btnAddOnClick(object sender, EventArgs e)
	{
        await Navigation.PushAsync(new AddPeriodos());
    }
}