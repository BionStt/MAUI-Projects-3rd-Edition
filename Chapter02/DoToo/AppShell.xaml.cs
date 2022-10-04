namespace DoToo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
	
        Routing.RegisterRoute(nameof(Views.MainView), typeof(Views.MainView));
    }
}
