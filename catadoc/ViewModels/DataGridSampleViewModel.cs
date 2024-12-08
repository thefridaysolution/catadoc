using System.Collections.ObjectModel;

using catadoc.Contracts.ViewModels;
using catadoc.Core.Contracts.Services;
using catadoc.Core.Models;

using CommunityToolkit.Mvvm.ComponentModel;

namespace catadoc.ViewModels;

public partial class DataGridSampleViewModel : ObservableRecipient, INavigationAware
{
    private readonly ISampleDataService _sampleDataService;

    public ObservableCollection<SampleOrder> Source { get; } = new ObservableCollection<SampleOrder>();

    public DataGridSampleViewModel(ISampleDataService sampleDataService)
    {
        _sampleDataService = sampleDataService;
    }

    public async void OnNavigatedTo(object parameter)
    {
        Source.Clear();

        // TODO: Replace with real data.
        var data = await _sampleDataService.GetGridDataAsync();

        foreach (var item in data)
        {
            Source.Add(item);
        }
    }

    public void OnNavigatedFrom()
    {
    }
}
