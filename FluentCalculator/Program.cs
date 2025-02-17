namespace task2
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            decimal? result = FluentCalculator.FluentCalculator.one.minus.three+10;
            Console.WriteLine(result.HasValue ? result : "The error in expression");
            Console.ReadLine();
        }
    }
}