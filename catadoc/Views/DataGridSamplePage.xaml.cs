using catadoc.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace catadoc.Views;

// TODO: Change the grid as appropriate for your app. Adjust the column definitions on DataGridPage.xaml.
// For more details, see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid.
public sealed partial class DataGridSamplePage : Page
{
    public DataGridSampleViewModel ViewModel
    {
        get;
    }

    public DataGridSamplePage()
    {
        ViewModel = App.GetService<DataGridSampleViewModel>();
        InitializeComponent();
    }
}
