using Notes.Views;

namespace Notes;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
        Routing.RegisterRoute(nameof(AddNewNotePage), typeof(AddNewNotePage));
        Routing.RegisterRoute(nameof(ListNotePage), typeof(ListNotePage));
        Routing.RegisterRoute(nameof(NoteDetailsPage), typeof(NoteDetailsPage));
    }


}
