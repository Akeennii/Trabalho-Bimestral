namespace ProjetoElemento.View;

public partial class Teladecadastro : ContentPage
{
	public Teladecadastro()
	{
		InitializeComponent();
	}
    private void Sucesso_cad(object sender, EventArgs e)
    {
        DisplayAlert("Aviso", "Cadastro realizado com sucesso", "OK");
        Voltar(sender, e);
    }
    public void Voltar(object sender, EventArgs e)
	{
		Navigation.PushAsync(new Cadastro());
    }
}