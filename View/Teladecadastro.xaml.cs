
namespace ProjetoElemento.View;

public partial class Teladecadastro : ContentPage
{
	public Teladecadastro()
	{
		InitializeComponent();
	}

    private async void Irloja(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Loja());
        Entrou(sender, e);
    }
    private void Entrou(object sender, EventArgs e)
    {
        DisplayAlert("Aviso", "Login efetuado com sucesso", "OK");
    }
}