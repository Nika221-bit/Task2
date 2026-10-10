namespace Task2;

using Task2;


class Program
{
    static void Main(string[] args)
    {
        Temperature temp1 = new Temperature { Amount = 50, Measurement = "Cels" };
        Temperature temp2 = new Temperature { Amount = 25, Measurement = "Cels" };

        Temperature result1 = temp1 / temp2;

        if (result1 != null)
        {
            Console.WriteLine($"Result: {result1.Amount} {result1.Measurement}");
        }

       
    }
}