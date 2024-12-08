using System.Windows.Input;

using catadoc.Contracts.Services;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Navigation;

namespace catadoc.ViewModels;

public partial class ShellViewModel : ObservableRecipient
{
    [ObservableProperty]
    private bool isBackEnabled;

    public ICommand MenuFileExitCommand
    {
        get;
    }

    public ICommand MenuSettingsCommand
    {
        get;
    }

    public ICommand MenuViewsDataGridSampleCommand
    {
        get;
    }

    public ICommand MenuViewsContentGridSampleCommand
    {
        get;
    }

    public ICommand MenuViewsListDetailsSampleCommand
    {
        get;
    }

    public ICommand MenuViewsWebViewSampleCommand
    {
        get;
    }

    public ICommand MenuViewsExportCommand
    {
        get;
    }

    public ICommand MenuViewsDatabaseConnectionCommand
    {
        get;
    }

    public ICommand MenuViewsMainCommand
    {
        get;
    }

    public INavigationService NavigationService
    {
        get;
    }

    public ShellViewModel(INavigationService navigationService)
    {
        NavigationService = navigationService;
        NavigationService.Navigated += OnNavigated;

        MenuFileExitCommand = new RelayCommand(OnMenuFileExit);
        MenuSettingsCommand = new RelayCommand(OnMenuSettings);
        MenuViewsDataGridSampleCommand = new RelayCommand(OnMenuViewsDataGridSample);
        MenuViewsContentGridSampleCommand = new RelayCommand(OnMenuViewsContentGridSample);
        MenuViewsListDetailsSampleCommand = new RelayCommand(OnMenuViewsListDetailsSample);
        MenuViewsWebViewSampleCommand = new RelayCommand(OnMenuViewsWebViewSample);
        MenuViewsExportCommand = new RelayCommand(OnMenuViewsExport);
        MenuViewsDatabaseConnectionCommand = new RelayCommand(OnMenuViewsDatabaseConnection);
        MenuViewsMainCommand = new RelayCommand(OnMenuViewsMain);
    }

    private void OnNavigated(object sender, NavigationEventArgs e) => IsBackEnabled = NavigationService.CanGoBack;

    private void OnMenuFileExit() => Application.Current.Exit();

    private void OnMenuSettings() => NavigationService.NavigateTo(typeof(SettingsViewModel).FullName!);

    private void OnMenuViewsDataGridSample() => NavigationService.NavigateTo(typeof(DataGridSampleViewModel).FullName!);

    private void OnMenuViewsContentGridSample() => NavigationService.NavigateTo(typeof(ContentGridSampleViewModel).FullName!);

    private void OnMenuViewsListDetailsSample() => NavigationService.NavigateTo(typeof(ListDetailsSampleViewModel).FullName!);

    private void OnMenuViewsWebViewSample() => NavigationService.NavigateTo(typeof(WebViewSampleViewModel).FullName!);

    private void OnMenuViewsExport() => NavigationService.NavigateTo(typeof(ExportViewModel).FullName!);

    private void OnMenuViewsDatabaseConnection() => NavigationService.NavigateTo(typeof(DatabaseConnectionViewModel).FullName!);

    private void OnMenuViewsMain() => NavigationService.NavigateTo(typeof(MainViewModel).FullName!);
}
