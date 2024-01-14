using MyMauiApp.Models;
using System.Collections.Generic;
using System.Windows.Input;

namespace MyMauiApp;

public partial class NewsPage : ContentPage
{
    public NewsPage()
    {
        InitializeComponent();
    }

    private async void LoadHaberler(object sender, EventArgs e)
    {
        refreshView.IsRefreshing = false;
    }

    private void lstKategoriler_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }

    private void lstHaberler_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}