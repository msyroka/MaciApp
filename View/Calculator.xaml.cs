using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        OnClear(this, null);
        BindingContext = new CalculatorPageViewModel();
    }

    public void OnClear(object sender, EventArgs eventArgs)
    {
        firstNum = 0;
        secondNum = 0;
        curretntState = 1;
        this.result.Text = "0";
    }

    void OnSquarRoot(object sender, EventArgs e)
    {
        if (firstNum==0)
            return;
        firstNum = firstNum * firstNum;
        this.result.Text = firstNum.ToString();
    }

    void OnNumberSelection(object sender, EventArgs e)
    {
        Button button = (Button) sender;
        string btnPressed = button.Text;

        if (this.result.Text == "0" || curretntState < 0)
        {
            this.result.Text = string.Empty;

            if (curretntState < 0)
                curretntState *= -1;
        }

        this.result.Text += btnPressed;

        double number;
        if (double.TryParse(this.result.Text, out number))
        {
            this.result.Text = number.ToString();
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
        if (curretntState == 2)
        {
            var result = Calculate.DoCalculation(firstNum, secondNum, operatorMath);

            this.result.Text = result.ToString();
            firstNum = result;
            curretntState = -1;
        }
    }
}