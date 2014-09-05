using System;

class CalculateGCD
{
    static void Main(string[] args)
    {
        int firstNumber, secondNumber;
        int GCD=0;
        int mask;

        firstNumber = int.Parse(Console.ReadLine());
        secondNumber = int.Parse(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            mask = secondNumber;
            secondNumber = firstNumber;
            firstNumber = mask;
        }
        while (secondNumber != 0)
        {
            GCD = firstNumber % secondNumber;
            firstNumber = secondNumber;
            if (GCD == 0)
            {
                GCD = secondNumber;
                secondNumber = 0;  // cleanly exit the loop
            }
            else
            {
                secondNumber = GCD; // do this only if we need to loop again
            } 
        }
        Console.WriteLine(GCD);         
    }
}
