namespace Academico;

public partial class AddPeriodos : ContentPage
{
	public AddPeriodos()
	{
		InitializeComponent();
	}
    private async void btnPeriodosOnClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Periodos());
    }
}