namespace EX4;

public class EvenAndUnevenNumber
{
    public void PrintEvenNumbers(int x)
    {
        Console.WriteLine("Even numbers between 0 and " + x + ":");
        for (int i = 0; i <= x; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    
    public void PrintOddNumbers(int x)
    {
        Console.WriteLine("Odd numbers between 0 and " + x + ":");
        for (int i = 1; i <= x; i += 2)
        {
            Console.Write(i + " ");
        }
        Console.WriteLine();
    }
    
}