using VideoApp.Models;
using VideoApp.ViewModels;

namespace VideoApp.Pages;

public partial class VideoListPage : ContentPage
{

    public VideoListPage()
    {
        InitializeComponent();
        BindingContext = new VideoListViewModel() { Navigation = Navigation };
    }

}