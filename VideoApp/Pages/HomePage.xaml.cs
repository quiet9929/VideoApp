using VideoApp.ViewModels;

namespace VideoApp.Pages;

public partial class HomePage : ContentPage
{
    public HomePage()
    {
        InitializeComponent();
        BindingContext = new HomeViewModel(Navigation);
    }

  
}