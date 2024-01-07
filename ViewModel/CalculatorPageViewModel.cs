using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using MaciApp.Service;

namespace MaciApp.ViewModel;

public class CalculatorPageViewModel : INotifyPropertyChanged
{
    private string _cButton = "C";
    private readonly ICalculateService _calculateService;
    private int _storedValue;
    private OperationMath _operationMath;

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
    public ICommand AddCommand { get; }
    public Command MultiplyCommand { get; }
    public Command DivideCommand { get; }
    

    public ICommand EqualsClickedCommand { get; }
    public CalculatorPageViewModel(ICalculateService calculateService)
    {
        _calculateService = calculateService;
        CClickedCommand = new Command(CClicked);
        SquareCommand = new Command(Square);
        SubtractCommand = new Command(Subtract);
        AddCommand = new Command(Add);
        MultiplyCommand = new Command(Multiply);
        DivideCommand = new Command(Divide);
        NumberSelectionCommand = new Command<string>(NumberSelection);
        EqualsClickedCommand = new Command(EqualsClicked);
        
    }

 


    private void NumberSelection(string number)
    {
        if(int.TryParse(number, out var parsedNumberValue))
            if (ResultText != 0)
            {
                var newResoult = ResultText.ToString() + number;
                ResultText = int.Parse(newResoult);
            }
            else
            {
                ResultText = parsedNumberValue;
            }

   
    }
    private void Square()
    {
       ResultText = _calculateService.DoCalculation(OperationMath.pow, ResultText);
    }
    
    private void Subtract()
    {
        _storedValue = ResultText;
        ResultText = 0;
        _operationMath = OperationMath.sub;
        
    }
    
    private void Add()
    {
        _storedValue = ResultText;
        ResultText = 0;
        _operationMath = OperationMath.add;
    }
    
    private void Multiply()
    {
        _storedValue = ResultText;
        ResultText = 0;
        _operationMath = OperationMath.multiply;
    }
    
    private void Divide(object obj)
    {
        _storedValue = ResultText;
        ResultText = 0;
        _operationMath = OperationMath.divide;}
    
    private void CClicked()
     {
         ResultText = 0;
         _storedValue = 0;
     }
    
    private void EqualsClicked()
    {
        ResultText = _calculateService.DoCalculation(_operationMath, _storedValue,ResultText);
    }
    
    public void OnPropertyChanged([CallerMemberName] string name = "") =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    public event PropertyChangedEventHandler? PropertyChanged;
}