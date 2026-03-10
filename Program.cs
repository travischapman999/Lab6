public class Program
{
    static void Main()
    {
        Console.Write("Please input a number: ");
        int Input = int.Parse(Console.ReadLine());
        int Square;
        int Cube;
        GetSquareAndCube(Input, out Square, out Cube);
        void GetSquareAndCube(int input, out int squared, out int cubed)
        {
            squared = input*input;
            cubed = squared*input;
        }
        Console.WriteLine($"Squared = {Square}");
        Console.WriteLine($"Cubed = {Cube}");
    }
}
