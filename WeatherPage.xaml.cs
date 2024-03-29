using MyMauiApp.Models;
using System.Collections.ObjectModel;
using System.Text.Json;

namespace MyMauiApp;

public partial class WeatherPage : ContentPage
{
	public WeatherPage()
	{
		InitializeComponent();
		if (File.Exists(fileName))
		{
			string data = File.ReadAllText(fileName);
            Sehirler = JsonSerializer.Deserialize<ObservableCollection<SehirHavaDurumu>>(data);
        }
		listCity.ItemsSource = Sehirler;
	}
	string fileName = Path.Combine(FileSystem.Current.AppDataDirectory, "hdata.json");
	ObservableCollection<SehirHavaDurumu> Sehirler = new ObservableCollection<SehirHavaDurumu>();
	private async void Ekle_Clicked (object sender, EventArgs e)
	{
		string sehir = await DisplayPromptAsync("�ehir:", "�ehir ismi", "OK", "Cancel");
		sehir = sehir.ToUpper(System.Globalization.CultureInfo.CurrentCulture);
        sehir = sehir.Replace('�', 'C');
        sehir = sehir.Replace('�', 'G');
        sehir = sehir.Replace('�', 'I');
        sehir = sehir.Replace('�', 'O');
        sehir = sehir.Replace('�', 'U');
        sehir = sehir.Replace('�', 'S');
        Sehirler.Add(new SehirHavaDurumu() { Name = sehir });
		string data = JsonSerializer.Serialize(Sehirler);
		File.WriteAllText(fileName, data);
    }
    private void Yukle_Clicked(object sender, EventArgs e)
    {
		refreshView.IsRefreshing = false;
		
    }
    private async void SilClicked(object sender, EventArgs e)
    {
		var b = sender as ImageButton;
		if (b != null)
		{
			var t = Sehirler.First(o => o.Name == b.CommandParameter.ToString());
			var yes = await DisplayAlert("Silinsin mi?", "Silmeyi onayla", "OK", "Cancel");
			if (yes)
			{
				Sehirler.Remove(t);
				string data = JsonSerializer.Serialize(Sehirler);
				File.WriteAllText(fileName, data);
			}
		}
    }
    private void ContentPage_Unloaded(object sender, EventArgs e)
    {
        string data = JsonSerializer.Serialize(Sehirler);
        File.WriteAllText(fileName, data);
    }
}