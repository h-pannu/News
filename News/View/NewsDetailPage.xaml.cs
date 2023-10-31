using News.ViewModel;

namespace News.View;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage()
	{
		InitializeComponent();
		BindingContext = new NewsDetailViewModel();
	}
}