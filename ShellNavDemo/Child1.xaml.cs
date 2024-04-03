namespace ShellNavDemo;

public partial class Child1 : ContentPage
{
	public Child1()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        
        NavigationStack.Text = "Nav: " + Navigation.NavigationStack.Count.ToString();
        var label = Navigation.NavigationStack.ToString();
    }

    async void C1C1_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushModalAsync(new Child1OfChild1());
    }
    
    async void C1C2_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushModalAsync(new Child2OfChild1());
    }

    async void Back_Clicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopModalAsync();
    }

    async void GotoBack_Clicked(System.Object sender, System.EventArgs e)
    {
        int navstackdepth = Navigation.NavigationStack.Count();
        await Shell.Current.GoToAsync("//MainPage");
        //await Shell.Current.Navigation.PopAsync();
    }    

}