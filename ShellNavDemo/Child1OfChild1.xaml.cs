namespace ShellNavDemo;

public partial class Child1OfChild1 : ContentPage
{
    public Child1OfChild1()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        NavigationStack.Text = "Nav: " + Navigation.NavigationStack.Count.ToString();
        var label = Navigation.NavigationStack.ToString();
    }

    async void LastPageClicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PushModalAsync(new LastPage());
    }

    async void BackClicked(System.Object sender, System.EventArgs e)
    {
        await Navigation.PopModalAsync();        
    }   

    async void GotoBack_Clicked(System.Object sender, System.EventArgs e)
    {
        await Shell.Current.GoToAsync("/Child1");
    }
}   