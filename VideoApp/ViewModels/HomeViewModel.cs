using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using VideoApp.Models;
using VideoApp.Pages;

namespace VideoApp.ViewModels
{
    public class HomeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public string Name { get; set; } = "Jack";

        public IList<Tag> Tags { get; set; } = new List<Tag>();

        public ICommand ButtonClicked { get; private set; }

        private readonly INavigation _navigation;

        public HomeViewModel(INavigation navigation)
        {
            _navigation = navigation;
            ButtonClicked = new Command(ButtonClick);
            foreach (var i in Enumerable.Range(1, 100))
            {
                Tags.Add(new Tag { Id = i, Name = i.ToString() });
            }

        }

        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            Console.WriteLine($"NotifyPropertyChanged = {propertyName}");
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private void ButtonClick()
        {
            Console.WriteLine($"name = 1111");
            _navigation.PushAsync(new NavigationPage(new VideoListPage()));
            
        }
    }
}
