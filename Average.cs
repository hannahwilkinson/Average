using System;

public class TestingMethods
{
    public static void Main()
    {
        decimal num1;
        decimal num2;
        decimal num3;

        Console.WriteLine("Please enter the first decimal: ");
        num1 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the second decimal: ");
        num2 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Please enter the third decimal: ");
        num3 = decimal.Parse(Console.ReadLine());

        //call to the method called Average - invoking 
        decimal result = Average(num1, num2, num3);

        //display the numbers and the average
        //can use C or F
        //c is for currency
        Console.WriteLine($"The average of the three numbers {num1}, {num2}, and {num3} is {result:c}");

        decimal someAmt = 55;
        Console.WriteLine((int) (someAmt / 25));
    }

    public static decimal Average(decimal n1, decimal n2, decimal n3)
    {
        //calculate the average of the three numbers
        decimal avg = (n1 + n2 + n3) / 3;
        return avg;
    }
}
