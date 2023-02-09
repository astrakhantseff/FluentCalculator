namespace task2
{
    public class Value
    {
        public Value(decimal value)
        {
            Content = value;
        }

        public decimal Content
        {
            get;
            set;
        }

        public Operation Plus
        {
            get
            {
                FluentCalculator.Enqueue(Operations.Plus);
                return Operations.Plus;
            }
        }

        public Operation Minus
        {
            get
            {
                FluentCalculator.Enqueue(Operations.Minus);
                return Operations.Minus;
            }
        }

        public Operation Times
        {
            get
            {
                FluentCalculator.Enqueue(Operations.Times);
                return Operations.Times;
            }
        }

        public Operation DividedBy
        {
            get
            {
                FluentCalculator.Enqueue(Operations.DividedBy);
                return Operations.DividedBy;
            }
        }

        public Value Zero => throw new InvalidOperationException();
        public Value One => throw new InvalidOperationException();
        public Value Two => throw new InvalidOperationException();
        public Value Three => throw new InvalidOperationException();
        public Value Four => throw new InvalidOperationException();
        public Value Five => throw new InvalidOperationException();
        public Value Six => throw new InvalidOperationException();
        public Value Seven => throw new InvalidOperationException();
        public Value Eight => throw new InvalidOperationException();
        public Value Nine => throw new InvalidOperationException();
        public Value Ten => throw new InvalidOperationException();
 
        public static Value operator +(Value a, decimal b)
        {
            a.Content += b;
            return a;
        }
        
        public static Value operator -(Value a, decimal b)
        {
            a.Content -= b;
            return a;
        }

        public static Value operator *(Value a, decimal b)
        {
            a.Content *= b;
            return a;
        }

        public static Value operator /(Value a, decimal b)
        {
            if (b == 0)
            {
                throw new DivideByZeroException();
            }
            a.Content /= b;
            return a;
        }

        public decimal? Result => FluentCalculator.Calculate()?.Content;
    }
}