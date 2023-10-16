namespace jarai.tdd0.Refresher.SolidIgnorant;

public interface IArithmeticOperation
{
}

public class Addition : IArithmeticOperation
{
    public double Add(double left, double right)
    {
        return left + right;
    }
}

public class Subtraction : IArithmeticOperation
{
    public double Subtract(double left, double right)
    {
        return left - right;
    }
}

public class Calculation
{
    public double Calculate(IArithmeticOperation operation, double left, double right)
    {
        switch (operation)
        {
            case Addition addition:
                return addition.Add(left, right);

            case Subtraction subtraction:
                return subtraction.Subtract(left, right);

            default:
                // Multiplication multiplication => multiplication.Multiply(left, right),
                throw new NotImplementedException();
        }
    }
}