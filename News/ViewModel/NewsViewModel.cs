using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using News.Model;
using News.Services;
using News.View;

namespace News.ViewModel
{
    //public class NewsViewModel : INotifyPropertyChanged
    public partial class NewsViewModel : ObservableObject
    {
        private NewsService _newsService;
        public ObservableCollection<NewsToday> NewsCollection { get; set; } = new ObservableCollection<NewsToday>();
        public NewsViewModel(NewsService newsService)
        {
            _newsService = newsService;
            GetNewsList();
        }

        private async void GetNewsList()
        {
            var news = await _newsService.GetNewsTodays();
            foreach (var item in news)
            {
                NewsCollection.Add(item);
            }
        }

        [ObservableProperty]
        NewsToday selectedNews;

        [RelayCommand]
        void GoToDetails()
        {
            Shell.Current.GoToAsync($"{nameof(NewsDetailPage)}", new Dictionary<string, object>
            {
                {"NewsSelected", SelectedNews}
            });
        }
    }
}
