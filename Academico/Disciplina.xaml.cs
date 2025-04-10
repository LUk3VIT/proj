namespace Academico;

public partial class Disciplina : ContentPage
{
	public Disciplina()
	{
		InitializeComponent();
	}
    private async void btnAddOnClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new AddDisciplina());
    }

    private async void btnUpDisciplinaOnClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new upDisciplina());
    }

    private async void btnDeletOnClick(object sender, EventArgs e)
    {
        bool answer = await DisplayAlert("Excluir", "Tem certeza que deseja Excluir: ", "Sim", "Não");
    }

}