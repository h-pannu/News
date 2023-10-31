using News.View;

namespace News
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(NewsDetailPage), typeof(NewsDetailPage));
        }
    }
}