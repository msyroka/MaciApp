using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MaciApp.ViewModel;

public class CalculatorPageViewModel
{
    public class MyCalculatorPageViewModel : INotifyPropertyChanged
    {
      

        public void OnPropertyChanged([CallerMemberName] string name = "") =>
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        public event PropertyChangedEventHandler? PropertyChanged;
    }

    public object C { get; }
}