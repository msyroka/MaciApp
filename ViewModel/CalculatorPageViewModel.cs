using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MaciApp.Service;

namespace MaciApp.ViewModel;

public class CalculatorPageViewModel : INotifyPropertyChanged
{
    private string _cButton = "C";
    private readonly ICalculateService _calculateService;

    private int _resultText = 0;

    public int ResultText
    {
        get => _resultText ;
        set
        {
            _resultText = value;
            OnPropertyChanged();
        } 
    }
    public string CButton
    {
        get => _cButton;
        set
        {
            _cButton = value;
            OnPropertyChanged();
        }
    }
    public ICommand CClickedCommand { get; }
    public ICommand SquareCommand { get; }
    public ICommand NumberSelectionCommand { get; }
    public ICommand SubtractCommand { get; }
    public ICommand EqualsClickedCommand { get; }
    public CalculatorPageViewModel(ICalculateService calculateService)
    {
        _calculateService = calculateService;
        CClickedCommand = new Command(CClicked);
        SquareCommand = new Command(Square);
        SubtractCommand = new Command(Subtract); 
        NumberSelectionCommand = new Command<string>(NumberSelection);
        EqualsClickedCommand = new Command(EqualsClicked);
    }
    private void NumberSelection(string number)
    {
        if(int.TryParse(number, out var tstVal))
            ResultText = tstVal;
    }
    private void Square()
    {
       ResultText = _calculateService.DoCalculation(OperationMath.pow, ResultText);
    }
    
    private void Subtract()
    {
        ResultText = _calculateService.DoCalculation(OperationMath.sub, ResultText);
    }
    private void CClicked()
     {
         ResultText = 0;
     }
    
    private void EqualsClicked(object obj)
    {
        
    }
    
    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    public event PropertyChangedEventHandler? PropertyChanged;
}