using System;
using Microsoft.Maui.Controls;
using ProjetoElemento.View;

namespace ProjetoElemento;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void Irlogin(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Teladecadastro());
    }

   
}
