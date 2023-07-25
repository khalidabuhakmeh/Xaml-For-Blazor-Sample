using System.Windows;
using XamlMadness.Models;

namespace XamlMadness;

public partial class XCounter
{
    private readonly XCounterViewModel _viewModel = new();

    public XCounter()
    {
        InitializeComponent();
        DataContext = _viewModel;
    }

    private void Increment_Click(object sender, RoutedEventArgs eventArgs)
    {
        _viewModel.CurrentCount++;
    }
}