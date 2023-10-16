namespace jarai.tdd0.Refresher.SolidConform;

public interface IArithmeticOperation
{
    public double Execute(double left, double right);
}

public class Addition : IArithmeticOperation
{
    public double Execute(double left, double right)
    {
        return left + right;
    }
}

public class Subtraction : IArithmeticOperation
{
    public double Execute(double left, double right)
    {
        return left - right;
    }
}

public class Multiplication : IArithmeticOperation
{
    public double Execute(double left, double right)
    {
        return left * right;
    }
}

public class Calculation
{
    public double Calculate(IArithmeticOperation op, double left, double right)
    {
        return op.Execute(left, right);
    }
}