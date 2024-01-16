using MyMauiApp.Views;
using System.ComponentModel;

namespace MyMauiApp;

public partial class ToDoListPage : ContentPage
{
	public ToDoListPage()
	{
		InitializeComponent();
	}
	private async void Ekle_Clicked(object sender, EventArgs e)
	{
		ToDoListDetailPage page=new ToDoListDetailPage();
		await Navigation.PushModalAsync(page);
	}
}