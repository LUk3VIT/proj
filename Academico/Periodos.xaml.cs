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

    private async void btnUpPeriodosOnClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new upPeriodos());
    }

    private async void btnDeletOnClick(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Excluir", "Tem certeza que deseja Excluir: ", "Sim", "Não");
    }
}