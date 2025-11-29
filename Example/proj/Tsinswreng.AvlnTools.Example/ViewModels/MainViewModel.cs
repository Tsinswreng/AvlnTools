using CommunityToolkit.Mvvm.ComponentModel;

namespace Tsinswreng.AvlnTools.Example.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
}
