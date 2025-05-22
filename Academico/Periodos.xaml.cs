using System.Collections.ObjectModel;
using Academico.Models;

namespace Academico;

public partial class Periodos : ContentPage
{

    ObservableCollection<tblperiodos> lista = new ObservableCollection<tblperiodos>();

    public Periodos()
	{
		InitializeComponent();

        listPeriodo.ItemsSource = lista;
    }

    private async void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
    {
        string q = e.NewTextValue;

        lista.Clear();

        List<tblperiodos> tmp = await App.Db.SearchPeriodos(q);

        foreach (tblperiodos tblperiodos in tmp)
        {
            lista.Add(tblperiodos);
        }
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



    protected override async void OnAppearing()
    {
        await carregarListaPeriodo();
    }

    private async Task carregarListaPeriodo()
    {
        List<tblperiodos> temp = await App.Db.GetAllPeriodos();

        lista.Clear();

        foreach (tblperiodos periodo in temp)
        {
            lista.Add(periodo);
        }
    }

    //Esse Método pega os valores do item selecionado la da lista
    private void listPeriodo_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        //Aqui falo que o "p" guarda o "e" que são os valores do item selecionado. alem disso ja falo que o "p" é do tipo "tblperiodos"
        var p  = e.SelectedItem as tblperiodos;

        //Aqui eu pego os valores do item selecionado e coloco em variaveis e passo o valor para string
        string codigo = p.Codigo.ToString();
        string nome = p.Nome.ToString();
        string sigla = p.Sigla.ToString();
    }

    //Esse método é o que faz a exclusão do item selecionado no método anterio
    private async void ImageButton_Clicked(object sender, EventArgs e)
    {
        //Aqui eu falo que o "button" é do tipo "ImageButton" e que ele é o mesmo que o "sender" que é o botão que foi clicado
        var button = sender as ImageButton;
        //Aqui eu falo que o "p" é do tipo "tblperiodos" e que ele é o mesmo que o "BindingContext" do botão que foi clicado
        var p = button?.BindingContext as tblperiodos;

        //Aqui eu pego o resposta do cliente para saber se ele quer excluir o item ou não
        bool confirmacao = await DisplayAlert(
            "Confirmação", "Confirma a remoção?", "Sim", "Não");

        //Aqui é a verificação
        if (confirmacao == true)
        {
            await App.Db.DeletePeriodos(p.Codigo);
            lista.Remove(p);
        }

    }

}
