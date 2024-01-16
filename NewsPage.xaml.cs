using Microsoft.Maui.Storage;
using Microsoft.VisualBasic;
using MyMauiApp.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.Contracts;
using System.Text.Json;
using System.Windows.Input;
using static MyMauiApp.Models.Haberler;

namespace MyMauiApp;

public partial class NewsPage : ContentPage
{
    public string? Link { get; private set; }

    public NewsPage()
    {
        InitializeComponent();
        lstKategoriler.ItemsSource = new List<Kategori>()
        {
            new Kategori () {Baslik = "Manþet", Link = "https://www.trthaber.com/manset_articles.rss"},
            new Kategori () {Baslik = "Son Dakika"},
            new Kategori () {Baslik = "Gündem"},
            new Kategori () {Baslik = "Ekonomi"},
            new Kategori () {Baslik = "Spor"},
            new Kategori () {Baslik = "Bilim"},
            new Kategori () {Baslik = "Güncel"},
            new Kategori () {Baslik = "Eðitim"},
        };


        lstHaberler.ItemsSource = new List<Haber>()
        {
            new Haber() { Link = "https://www.trthaber.com/manset_articles.rss", Detay = "" },
            new Haber() { Link = "", Detay = "" },
            new Haber() { Link = "", Detay = "" },
            new Haber() { Link = "", Detay = "" },
            new Haber() { Link = "", Detay = "" },
            new Haber() { Link = "", Detay = "" },
            new Haber() { Link = "", Detay = "" },
            new Haber() { Link = "", Detay = "" },
            new Haber() { Link = "", Detay = "" },
        };

    }
    class Kategori
    {
        public string Baslik { get; set; }
        public string Link { get; set; }
    }
    class Haber
    {
        public string Link { get; set; }
        public string Detay { get; set; }
    }


    private async void LoadHaberler(object sender, EventArgs e)
    {
       
    }


    private void lstKategoriler_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        
    }

    private void lstHaberler_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {

    }
}