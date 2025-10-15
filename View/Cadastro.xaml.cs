using Microsoft.Maui.Controls;
using ProjetoElemento.Models;
using System.Collections.ObjectModel;
using ProjetoElemento.View;

namespace ProjetoElemento
{
    public partial class Cadastro : ContentPage
    {
        ObservableCollection<Animal> listaAnimais = new ObservableCollection<Animal>();
        public Cadastro()
        {
            InitializeComponent();
        }

        public Cadastro(ObservableCollection<Animal> listaAnimais)
        {
            InitializeComponent();
            this.listaAnimais = listaAnimais;
        }

        private void Entrar(object sender, EventArgs e)
        {
            DisplayAlert("Aviso","Login efetuado com sucesso", "OK");
            Entrou(sender, e);
        }
        private async void Entrou(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Show());
        }

    }
}
