using News.ViewModel;

namespace News.View;

public partial class NewsDetailPage : ContentPage
{
	public NewsDetailPage(NewsDetailViewModel newsDetailViewModel)
	{
		InitializeComponent();
		BindingContext = newsDetailViewModel;
	}
}