using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MaciApp.ViewModel;

public class CalculatorPageViewModel : INotifyPropertyChanged
{

    private string _cButton = "C";

    public string CButton
    {
        get => _cButton;
        set
        {
            _cButton = value;
            OnPropertyChanged();
        }
    }

    public object CClickedCommand { get; }

    // public CalculatorPageViewModel()
    // {
    //     CClickedCommand = new Command(CClicked);
    // }

    

   // private void CClicked()
   //  {
   //      throw new NotImplementedException();
   //  }
   //  
    //public Icomand 

    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    public event PropertyChangedEventHandler? PropertyChanged;

}