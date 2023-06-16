using System.Reactive.Disposables;
using Avalonia.Controls;
using Avalonia.ReactiveUI;
using ReactiveUI;
using ReactiveUI.Validation.Extensions;
using TestAvaloniaSunbox.ViewModels;

namespace TestAvaloniaSunbox.Views;

public partial class MainWindow :  ReactiveWindow<MainWindowViewModel>
{
    public MainWindow()
    {
       InitializeComponent();
       this.WhenActivated(disposables =>
       {
           this.BindValidation(ViewModel, x => x.Value, x => x.ValidationF.Text)
               .DisposeWith(disposables);
       });
    }
}