using Avalonia.Threading;
using DynamicData;
using ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive.Linq;

namespace AvaloniaMemLeak.ViewModels;

public class ViewModelBase : ReactiveObject
{
}

public class PackageViewModel : ViewModelBase
{
}

public class MainViewModel : ViewModelBase
{
    // public bool X { get; set; }
    // ObservableAsPropertyHelper<ObservableCollection<PackageViewModel>> _oaphPackageViewModels;
    // public ObservableCollection<PackageViewModel> PackageViewModels  => _oaphPackageViewModels.Value;

    // public ObservableCollection<PackageViewModel> PackageViewModels { get; } = new();

    public PackageViewModel[] PackageViewModels { get; set; }

    public MainViewModel()
    {
        DispatcherTimer.Run(() =>
        {
            GC.Collect();
            return true;
        }, TimeSpan.FromSeconds(8));

        PackageViewModel[] vms = [
            new PackageViewModel(),
            new PackageViewModel(),
            new PackageViewModel(),
            new PackageViewModel(),
            new PackageViewModel(),
            ];

        // With OAPHs.
        //_oaphPackageViewModels = this.WhenAnyValue(x => x.X)
        //    .Select(_ => vms)
        //    .Select(v => new ObservableCollection<PackageViewModel>(v))
        //    .ToProperty(this, nameof(PackageViewModel));

        // Simple ObservableCollection
        // PackageViewModels.AddRange(vms);

        // Simple array
        PackageViewModels = vms.ToArray();
    }
}