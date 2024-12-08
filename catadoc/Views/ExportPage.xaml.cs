using catadoc.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace catadoc.Views;

public sealed partial class ExportPage : Page
{
    public ExportViewModel ViewModel
    {
        get;
    }

    public ExportPage()
    {
        ViewModel = App.GetService<ExportViewModel>();
        InitializeComponent();
    }
}
