using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaciApp.ViewModel;

namespace MaciApp.View;

public partial class LearnigPageView : ContentPage
{
    public LearnigPageView()
    {
        InitializeComponent();
        BindingContext = new LearnigPageViewViewModel();
    }
    
    
    
}


