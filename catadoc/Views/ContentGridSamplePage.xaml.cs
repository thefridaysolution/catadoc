using catadoc.ViewModels;

using Microsoft.UI.Xaml.Controls;

namespace catadoc.Views;

public sealed partial class ContentGridSamplePage : Page
{
    public ContentGridSampleViewModel ViewModel
    {
        get;
    }

    public ContentGridSamplePage()
    {
        ViewModel = App.GetService<ContentGridSampleViewModel>();
        InitializeComponent();
    }
}
