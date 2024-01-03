using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace MaciApp.ViewModel;

public class BindableLayoutPageViewModel : INotifyPropertyChanged
{
    private List<string> _testList;

    public List<string> TestList
    {
        get => _testList;
        set
        {
            _testList = value;
            OnPropertyChanged();
        }
    }
    public BindableLayoutPageViewModel()
    {
        TestList = new List<string>();
        for (int i = 0; i < 30; i++)
        {
            TestList.Add("test" + i.ToString());
        }
    }







    protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    public event PropertyChangedEventHandler? PropertyChanged;
}