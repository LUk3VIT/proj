using System.Collections.ObjectModel;
using CRUD.Models;

namespace CRUD
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<Periodo> lista = new ObservableCollection<Periodo>();



        public MainPage()
        {
            InitializeComponent();

            listPeriodo.ItemsSource = lista;

        }

       protected override async void OnAppearing()
        {
            await carregarListaPeriodo();
        }

        private async Task carregarListaPeriodo()
        {
            List<Periodo> temp = await App.Db.GetAll();

            lista.Clear();

            foreach (Periodo periodo in temp)
            {
                lista.Add(periodo);
            }
        }

        private async void btnInserir_Clicked(object sender, EventArgs e)
        {
            Periodo est = new Periodo();
            est.Nome = txtNome.Text;

            App.Db.Insert(est);
            DisplayAlert("Sucesso!", "Registro inserido.", "OK");


            await carregarListaPeriodo();

        }

        private async void txtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            string q = e.NewTextValue;

            lista.Clear();

            List<Periodo> tmp = await App.Db.Search(q);

            foreach (Periodo periodo in tmp)
            {
                lista.Add(periodo);
            }   
        }
    }

}
