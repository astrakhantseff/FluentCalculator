namespace task1
{
    internal class Program
    {
        private static bool _value;
        public static bool someBool
        {
            get
            {
                _value = !_value;
                return _value;
            }
        }

        static void Main(string[] args)
        {
            bool a = someBool == true && someBool == false;
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}