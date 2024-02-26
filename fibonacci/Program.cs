using System;

class Program
{
    static void Main()
    {
        int limit = 4000000; // Set your desired limit
        Console.WriteLine("Sum of even-valued terms in Fibonacci sequence up to " + limit + ":");

        int sum = 0;
        int currentTerm = 1;
        int nextTerm = 2;

        while (currentTerm <= limit)
        {
            if (currentTerm % 2 == 0)
            {
                sum += currentTerm;
            }

            int temp = currentTerm + nextTerm;
            currentTerm = nextTerm;
            nextTerm = temp;
        }

        Console.WriteLine(sum);
    }
}
