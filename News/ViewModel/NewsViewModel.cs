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
        private readonly MockNewsService _newsService;
        public ObservableCollection<NewsToday> NewsCollection { get; set; } = new ObservableCollection<NewsToday>();
        public NewsViewModel(MockNewsService mockNewsService)
        {
            _newsService = mockNewsService;
            GetNewsList();
        }

        private void GetNewsList()
        {
            var news = _newsService.GetNews();
            foreach (var item in news)
            {
                NewsCollection.Add(item);
            }
        }
    }
}
