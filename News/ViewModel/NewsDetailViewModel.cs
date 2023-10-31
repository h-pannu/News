using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News.ViewModel
{
    [QueryProperty(nameof(User_name), "username")]
    public partial class NewsDetailViewModel :ObservableObject
    {
        [ObservableProperty]
        string user_name;
    }
}
