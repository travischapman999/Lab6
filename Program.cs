using Lab6;
public class Program
{
    static void Main()
    {
        Console.Write("Enter a date(yyyy/mm/dd): ");
        string Input = Console.ReadLine();
        DateTime InputDate = DateTime.Parse(Input);
        DateTime TodaysDate = DateTime.Now;
        Console.WriteLine($"You entered: {InputDate:dddd}, {InputDate:MMMM} {InputDate.Day}, {InputDate:yyyy}");
        TimeSpan TimeSinceInput = TodaysDate.Subtract(InputDate);
        Console.WriteLine($"Days since date entered: {TimeSinceInput.Days}");
    }
}
