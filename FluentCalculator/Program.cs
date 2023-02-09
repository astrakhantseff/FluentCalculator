namespace task2
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            decimal? result = (FluentCalculator.One.Minus.Three+10).Result;
            Console.WriteLine(result.HasValue ? result : "The error in expression");
            Console.ReadLine();
        }
    }
}