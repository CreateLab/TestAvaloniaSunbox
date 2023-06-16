using System;
using System.Reactive.Linq;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using ReactiveUI.Validation.Abstractions;
using ReactiveUI.Validation.Contexts;
using ReactiveUI.Validation.Extensions;

namespace TestAvaloniaSunbox.ViewModels;

public class MainWindowViewModel : ViewModelBase, IValidatableViewModel
{
 
    [Reactive]
    public int Value { get; set; }
  


    public MainWindowViewModel()
    {
        IObservable<bool> valtest =
            this.WhenAnyValue(
                x => x.Value,
                (v) => v == 5);

        this.ValidationRule(
            vm => vm.Value, // The property name selector expression.
            valtest, // IObservable<bool>
            "Passwords must match.");
    }

    public ValidationContext ValidationContext { get; } = new ValidationContext();
}