using System.Collections.ObjectModel;
using Academico.Models;

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

    private void btnInserir_Clicked(object sender, EventArgs e)
    {
        tblperiodos ped = new tblperiodos();
        ped.Nome = etrNome.Text;   
        ped.Sigla = etrSigla.Text;

        App.Db.InsertPeriodos(ped);
        DisplayAlert("Sucesso!", "Registro inserido.", "OK");
    }
}