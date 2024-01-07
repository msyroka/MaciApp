using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaciApp.Service;
using MaciApp.ViewModel;

namespace MaciApp.View;

public partial class Calculator : ContentPage
{
    int curretntState = 1;
    string operatorMath;
    double firstNum, secondNum;


    public Calculator()
    {
        InitializeComponent();
      //  OnClear(this, null);
        BindingContext = new CalculatorPageViewModel(new CalculateServices());
    }
    /*
    public void OnClear(object sender, EventArgs eventArgs)
    {
        firstNum = 0;
        secondNum = 0;
        curretntState = 1;
        this.ResultLabel.Text = "0";
    }
    
    void OnNumberSelection(object sender, EventArgs e)
    {
        Button button = (Button) sender;
        string btnPressed = button.Text;

        if (this.ResultLabel.Text == "0" || curretntState < 0)
        {
            this.ResultLabel.Text = string.Empty;

            if (curretntState < 0)
                curretntState *= -1;
        }

        this.ResultLabel.Text += btnPressed;

        double number;
        if (double.TryParse(this.ResultLabel.Text, out number))
        {
            this.ResultLabel.Text = number.ToString();
            if (curretntState == 1)
            {
                firstNum = number;
            }
            else
            {
                secondNum = number;
            }
        }
    }
    
    void onOperatorSelection(object? sender, EventArgs e)
    {
        curretntState = -2;
        Button button = (Button) sender;
        string btnPressed = button.Text;
        operatorMath = btnPressed;
    }

    void onCalculate(object sender, EventArgs e)
    {
        if (curretntState == 2) ;
    } */
}