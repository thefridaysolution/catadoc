using catadoc.ViewModels;

using CommunityToolkit.WinUI.UI.Controls;

using Microsoft.UI.Xaml.Controls;

namespace catadoc.Views;

public sealed partial class ListDetailsSamplePage : Page
{
    public ListDetailsSampleViewModel ViewModel
    {
        get;
    }

    public ListDetailsSamplePage()
    {
        ViewModel = App.GetService<ListDetailsSampleViewModel>();
        InitializeComponent();
    }

    private void OnViewStateChanged(object sender, ListDetailsViewState e)
    {
        if (e == ListDetailsViewState.Both)
        {
            ViewModel.EnsureItemSelected();
        }
    }
}
