using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VideoApp.Models;

namespace VideoApp.ViewModels
{
    internal class VideoListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public INavigation Navigation { get; set; }

        public IList<Video> VideoList { get; set; } = new List<Video>() 
        { 
            new Video() { Name = "古惑仔1" },
            new Video() { Name = "古惑仔2" },
            new Video() { Name = "古惑仔3" },
            new Video() { Name = "古惑仔4" },
            new Video() { Name = "古惑仔5" },
            new Video() { Name = "古惑仔6" },
            new Video() { Name = "古惑仔7" },
            new Video() { Name = "古惑仔8" },
            new Video() { Name = "古惑仔9" },
        };

        public IList<string> VideoTypes { get; set; } = new List<string>() { "电视剧", "电影", "综艺", "纪录片" };

        public VideoListViewModel() 
        {
         
        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            Console.WriteLine($"NotifyPropertyChanged = {propertyName}");
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    
    }
}
