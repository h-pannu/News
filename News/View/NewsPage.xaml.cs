using News.ViewModel;

namespace News.View;

public partial class NewsPage : ContentPage
{
	public NewsPage(NewsViewModel newsViewModel)
	{
		InitializeComponent();
		BindingContext = newsViewModel;
	}
}