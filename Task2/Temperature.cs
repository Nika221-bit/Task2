using System.Linq.Expressions;

namespace Task2;

public class Temperature
{
    public int Amount { get; set; }
    public string Measurement { get; set; }

    public static Temperature operator /(Temperature temp1,Temperature temp2)
    {
        try
        {
            if (temp1.Measurement == temp2.Measurement)
            {
                Temperature sum = new Temperature();
                sum.Amount =  temp1.Amount / temp2.Amount;
                sum.Measurement = temp1.Measurement;
                return sum;
            }
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("you cant divide by zero");
            throw;
        }
        
        return null;
        
    }

    public override string ToString()
    {
        return base.ToString();
    }
}