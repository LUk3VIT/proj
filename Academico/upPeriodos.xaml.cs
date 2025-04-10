namespace Academico;

public partial class upPeriodos : ContentPage
{
	public upPeriodos()
	{
		InitializeComponent();
	}

    private async void btnPeriodosOnClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Periodos());
    }
}