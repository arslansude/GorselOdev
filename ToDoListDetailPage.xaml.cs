
namespace MyMauiApp.Views;

public partial class ToDoListDetailPage : ContentPage
{
	public ToDoListDetailPage()
	{
		InitializeComponent();
	}

    private async void Button_Clicked_1(object sender, EventArgs e)
    {
        ToDoListPage page = new ToDoListPage();
        await Navigation.PopModalAsync();
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {

    }
}