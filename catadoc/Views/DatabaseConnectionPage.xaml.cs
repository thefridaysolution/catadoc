using catadoc.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace catadoc.Views;

public sealed partial class DatabaseConnectionPage : Page
{
    public DatabaseConnectionViewModel ViewModel
    {
        get;
    }

    public DatabaseConnectionPage()
    {
        ViewModel = App.GetService<DatabaseConnectionViewModel>();
        InitializeComponent();
    }
}
