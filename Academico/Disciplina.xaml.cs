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

}