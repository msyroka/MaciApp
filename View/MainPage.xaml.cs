using MaciApp.View;

namespace MaciApp;

public partial class MainPage : ContentPage
{
    
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnClicked(object sender, EventArgs eventArgs)
    {
        Navigation.PushAsync(new Calculator());
    }
    
}