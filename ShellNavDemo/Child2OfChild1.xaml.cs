namespace ShellNavDemo;

public partial class Child2OfChild1 : ContentPage
{
	public Child2OfChild1()
	{
		InitializeComponent();
	}

    async void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		await Navigation.PopModalAsync();
    }


    protected override void OnAppearing()
    {
        NavigationStack.Text = "Nav: " + Navigation.NavigationStack.Count.ToString();
        var label = Navigation.NavigationStack.ToString();
    }
}
