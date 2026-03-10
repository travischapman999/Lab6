using Lab6;
public class Program
{
    static void Main()
    {
        Console.Write("Please input a number: ");
        int Input = int.Parse(Console.ReadLine());
        if (Input.IsEven())
        {
            Console.WriteLine("The input was even");
        }
        else
        {
            Console.WriteLine("The input was odd");
        }
    }
}
