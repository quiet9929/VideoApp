using VideoApp.ViewModels;

namespace VideoApp.Pages;

public partial class VideoDetailPage : ContentPage
{
	public VideoDetailPage()
	{
		InitializeComponent();
        BindingContext = new VideoDetailViewModel();
    }
}