namespace MaciApp.Service;

public interface ICalculateService
{
        int DoCalculation(OperationMath operatorMath, int val1, int val2 = 0);
}