namespace Academico;

public partial class AddDisciplina : ContentPage
{
	public AddDisciplina()
	{
		InitializeComponent();
	}
    private async void btnDisciplinaOnClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Disciplina ());
    }
}