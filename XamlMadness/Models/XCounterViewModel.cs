using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace XamlMadness.Models;

public class XCounterViewModel: INotifyPropertyChanged
{
    private int _currentCount;
    public int CurrentCount
    {
        get => _currentCount;
        set
        {
            if (_currentCount == value) return;
            _currentCount = value;
            OnPropertyChanged();
        }
    }

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged([CallerMemberName] string callerName = "")
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(callerName));
    }
}