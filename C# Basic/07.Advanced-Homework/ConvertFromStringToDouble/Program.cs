using System;

public class Example
{
    public static void Main()
    {
        string[] values = { "-1", "1", "1e-35", 
                         "1,635,592,999,999,999,999,999,999", "-17.455", 
                         "190.34001", "1.29e325"};
        double result;

        foreach (string value in values)
        {
            try
            {
                result = double.Parse(value);
                Console.WriteLine("Converted '{0}' to {1}.", value, result);
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}' to a Double.", value);
            }
            catch (OverflowException)
            {
                Console.WriteLine("'{0}' is outside the range of a Double.", value);
            }
        }
    }
}