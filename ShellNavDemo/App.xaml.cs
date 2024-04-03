namespace ShellNavDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();


        // There are some questions pending around routing.
        // https://learn.microsoft.com/en-us/answers/questions/1193303/appshell-failed-to-navigate-back-ambiguous-routes?page=1&orderby=Helpful&comment=answer-1192252#newest-answer-comment

        Routing.RegisterRoute("MainPage", typeof(MainPage));
        Routing.RegisterRoute("MainPage/Child1", typeof(Child1));
        Routing.RegisterRoute("MainPage/Child1/Child1OfChild1", typeof(Child1OfChild1));
        Routing.RegisterRoute("MainPage/Child1/Child1OfChild1/LastPage", typeof(LastPage));
        Routing.RegisterRoute("MainPage/Child1/Child2OfChild1", typeof(Child2OfChild1));


        // Should be hierarchical as above, but flat structure has same issue.
        //Routing.RegisterRoute("MainPage", typeof(MainPage));
        //Routing.RegisterRoute("Child1", typeof(Child1));
        //Routing.RegisterRoute("Child1OfChild1", typeof(Child1OfChild1));
        //Routing.RegisterRoute("LastPage", typeof(LastPage));
        //Routing.RegisterRoute("Child2OfChild1", typeof(Child2OfChild1));

    }
}