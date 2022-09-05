namespace VideoApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		// MainPage = new AppShell(); // Shell 模式
		MainPage = new NavigationPage(new MainPage()); // 普通模式
	}
}
