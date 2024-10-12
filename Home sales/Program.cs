using System;

class Program
{
    public static void Main(string[] args)
    {
        double totalSalesD = 0.0;
        double TotalSalesE = 0.0;
        double TotalSalesF = 0.0;
        char inital;
        double grandTotal = 0.0;

        while (true)
        {
            Console.WriteLine("enter the salsperson initial or hit z to quit");
            inital = Char.ToUpper(Convert.ToChar(Console.ReadLine()));
            if (inital == 'Z')
            {
                break;
            }
            else if (inital != 'D' && inital != 'E' && inital != 'F')
            {
                Console.WriteLine("Invalid input.");
                continue;
            }
            Console.WriteLine("enter the sales amount");
            double salesAmount = Convert.ToDouble(Console.ReadLine());
            switch (inital)
            {
                case 'D':
                    totalSalesD += salesAmount;
                    break;
                case 'E':
                    TotalSalesE += salesAmount;
                    break;
                case 'F':
                    TotalSalesF += salesAmount;
                    break;
            }
            grandTotal += salesAmount;
        }
        Console.WriteLine("Grand Total: $" + grandTotal);
        if (totalSalesD > TotalSalesE && totalSalesD > TotalSalesF)
        {
            Console.WriteLine("Highest Sale: D");
        }
        else if (TotalSalesE > totalSalesD && TotalSalesE > TotalSalesF)
        {
            Console.WriteLine("Highest Sale: E");
        }
        else if (TotalSalesF > totalSalesD && TotalSalesF > TotalSalesE)
        {
            Console.WriteLine("Highest Sale: F");
        }

    }
}