using MaciApp.View;
using ListView = Microsoft.Maui.Controls.ListView;

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

    private void OnClickedListView(object? sender, EventArgs e)
    {
        Navigation.PushAsync(new LearnigPageView());
    }
}