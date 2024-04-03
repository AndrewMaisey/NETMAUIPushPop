namespace ShellNavDemo;

public partial class LastPage : ContentPage
{
	public LastPage()
	{
		InitializeComponent();
	}

    async void PopToRootClicked(System.Object sender, System.EventArgs e)
    {
		await Navigation.PopToRootAsync();
    }

    async void BackClicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    protected override void OnAppearing()
    {
        NavigationStack.Text = "Nav: " + Navigation.NavigationStack.Count.ToString();
        var label = Navigation.NavigationStack.ToString();
    }
}
