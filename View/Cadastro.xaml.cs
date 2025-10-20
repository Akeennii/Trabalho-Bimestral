using Microsoft.Maui.Controls;
using ProjetoElemento.Models;
using System.Collections.ObjectModel;
using ProjetoElemento.View;
using System.Threading.Tasks;

namespace ProjetoElemento
{
    public partial class Cadastro : ContentPage
    {
        public Cadastro()
        {
            InitializeComponent();
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

        private async void Realizar_cad(object sender, TappedEventArgs e)
        {
            await Navigation.PushAsync(new Teladecadastro());
        }

        private void Esqueci_senha(object sender, TappedEventArgs e)
        {
            DisplayAlert("Aviso", "Infelizmente, também esqueci sua senha.", "OK");
        }
    }
}
