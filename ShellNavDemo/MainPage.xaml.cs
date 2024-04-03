namespace ShellNavDemo;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
    }

	protected override void OnAppearing()
	{
		NavigationStack.Text = "Nav: " + Navigation.NavigationStack.Count.ToString();
		var label = Navigation.NavigationStack.ToString();
    }	

	async void Child1_Clicked(System.Object sender, System.EventArgs e)
	{
		await Navigation.PushModalAsync(new Child1());
	}

    async void GotoChild1_Clicked(System.Object sender, System.EventArgs e)
    {
		await Shell.Current.GoToAsync("Child1");
    }
}


