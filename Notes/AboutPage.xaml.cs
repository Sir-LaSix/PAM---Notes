namespace Notes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

	private void EnviarGitBtn_Clicked(object sender, EventArgs e) //novo metodo criado pela ferramenta
	{
		Launcher.Default.OpenAsync("https://github.com/Sir-LaSix");
	}
}