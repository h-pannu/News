using CommunityToolkit.Mvvm.ComponentModel;
using News.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ViewModel
{
    [QueryProperty(nameof(User), "UserKey")]
    public partial class NewsDetailViewModel :ObservableObject
    {
        [ObservableProperty]
        User user;
    }
}
