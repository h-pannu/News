using News.ViewModel;

namespace News.View;

public partial class NewsPage : ContentPage
{
	public NewsPage()
	{
		InitializeComponent();
		BindingContext = new NewsViewModel();
	}
}