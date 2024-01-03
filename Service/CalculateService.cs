namespace MaciApp.Service;

public class CalculateServices : ICalculateService
{
    
    public int DoCalculation(OperationMath operatorMath, int val1, int val2 = 0 )
    {
        int result = 0;

        switch (operatorMath)
        {
            case OperationMath.devide:
                result = val1 / val2;
                break;
            case OperationMath.sub:
                result = val1 - val2;
                break;
            case OperationMath.multiply:
                result = val1 * val2;
                break;
            case OperationMath.add:
                result = val1 + val2;
                break;
            case OperationMath.pow:
                result = (int)Math.Pow(val1, 2);
                break;

            default:
                break;
        }

        return result;

    }
}