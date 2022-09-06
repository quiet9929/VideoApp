using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
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

        private IList<VideoTypeTab> _videoTypeTabs = new List<VideoTypeTab>();
        public IList<VideoTypeTab> VideoTypeTabs { 
            get { return _videoTypeTabs; } 
            set { _videoTypeTabs = value; NotifyPropertyChanged(); }
        } 

        public ICommand OnVideoTypeTabClicked { get; set; }
        public VideoListViewModel()
        {
            OnVideoTypeTabClicked = new Command<string>(VideoTypeTabClicked);
            VideoTypeTabs = new List<VideoTypeTab>()
            {
                new VideoTypeTab() { Name = "电视剧", Active = true },
                new VideoTypeTab() { Name = "电影" },
                new VideoTypeTab() { Name = "综艺" },
                new VideoTypeTab() { Name = "纪录片" },
            };
        }

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            Console.WriteLine($"NotifyPropertyChanged = {propertyName}");
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private void VideoTypeTabClicked(string name)
        {
            Console.WriteLine($"name={name}");
            foreach (var tab in VideoTypeTabs)
            {
                tab.Active = tab.Name == name;
            }
        }

    }
}
