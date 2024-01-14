using MyMauiApp.Models;
using static MyMauiApp.Models.Haberler;

namespace MyMauiApp;

public partial class NewsDetailPage : ContentPage
{
    //Item haber;
    public NewsDetailPage(/*Item item*/)
	{
		InitializeComponent();
        //haber = item;
        //webView.Source = item.link;
	}

    private async void Share_Clicked(object sender, EventArgs e)
    {
    //    await ShareUri(haber.link, Share.Default);
    }
    //public async Task ShareUri(string uri, IShare share)
    //{
    //    await share.RequestAsync(new ShareTextRequest
    //    {
    //        Uri = uri,
    //        Title = haber.title
    //    });
    //}
}