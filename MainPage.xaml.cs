using System;
using Microsoft.Maui.Controls;

namespace ProjetoElemento;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void ButtonClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Cadastro());
    }

   
}
