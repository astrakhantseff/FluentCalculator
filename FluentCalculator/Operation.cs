namespace task2
{
    public class Operation
    {
        public Operation(OperationType type)
        {
            Type = type;
        }

        public Value Zero
        {
            get
            {
                FluentCalculator.Enqueue(Values.Zero);
                return Values.Zero;
            }
        }

        public Value One
        {
            get
            {
                FluentCalculator.Enqueue(Values.One);
                return Values.One;
            }
        }

        public Value Two
        {
            get
            {
                FluentCalculator.Enqueue(Values.Two);
                return Values.Two;
            }
        }

        public Value Three
        {
            get
            {
                FluentCalculator.Enqueue(Values.Three);
                return Values.Three;
            }
        }

        public Value Four
        {
            get
            {
                FluentCalculator.Enqueue(Values.Four);
                return Values.Four;
            }
        }
        public Value Five
        {
            get
            {
                FluentCalculator.Enqueue(Values.Five);
                return Values.Five;
            }
        }
        public Value Six
        {
            get
            {
                FluentCalculator.Enqueue(Values.Six);
                return Values.Six;
            }
        }
        public Value Seven
        {
            get
            {
                FluentCalculator.Enqueue(Values.Seven);
                return Values.Seven;
            }
        }
        public Value Eight
        {
            get
            {
                FluentCalculator.Enqueue(Values.Eight);
                return Values.Eight;
            }
        }
        public Value Nine
        {
            get
            {
                FluentCalculator.Enqueue(Values.Nine);
                return Values.Nine;
            }
        }
        public Value Ten
        {
            get
            {
                FluentCalculator.Enqueue(Values.Ten);
                return Values.Ten;
            }
        }

        public Value Left { get; set; }
        public Value Right { get; set; }
        public OperationType Type { get; set; }

        public Operation Plus => throw new InvalidOperationException();
        public Operation Minus => throw new InvalidOperationException();
        public Operation Times => throw new InvalidOperationException();
        public Operation DividedBy => throw new InvalidOperationException();

        public decimal Perform()
        {
            if (Type == OperationType.dividedBy && Right.Content == 0)
                throw new DivideByZeroException();

            return Type switch
            {
                OperationType.plus => Left.Content + Right.Content,
                OperationType.minus => Left.Content - Right.Content,
                OperationType.times => Left.Content * Right.Content,
                OperationType.dividedBy => Left.Content / Right.Content
            };
        }
    }
}