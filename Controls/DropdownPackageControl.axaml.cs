using Avalonia;
using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Input;
using ReactiveUI;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reactive;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using AvaloniaMemLeak.ViewModels;
using Avalonia.ReactiveUI;

namespace AvaloniaMemLeak.Controls;

//public abstract class UserControlBase<TViewModel> : ReactiveUserControl<TViewModel> where TViewModel : ViewModelBase
public abstract class UserControlBase : UserControl
{

}

public partial class DropdownPackageControl : UserControlBase
{
    public DropdownPackageControl()
    {
        InitializeComponent();
    }
}
