namespace Academico;

public partial class upDisciplina : ContentPage
{
	public upDisciplina()
	{
		InitializeComponent();
	}

    private async void btnDisciplinaOnClick(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Disciplina());
    }
}