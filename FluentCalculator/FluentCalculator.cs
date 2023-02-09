namespace task2
{
    public static class FluentCalculator
    {
        private static Queue<object> _queue = new();

        public static void Enqueue(object item) => _queue.Enqueue(item);

        // Values zero-ten
        public static Value Zero
        {
            get
            {
                Enqueue(Values.One);
                return Values.One;
            }
        }

        public static Value One
        {
            get
            {
                Enqueue(Values.One);
                return Values.One;
            }
        }

        public static Value Two
        {
            get
            {
                Enqueue(Values.Two);
                return Values.Two;
            }
        }

        public static Value Three
        {
            get
            {
                Enqueue(Values.Three);
                return Values.Three;
            }
        }

        public static Value Four
        {
            get
            {
                Enqueue(Values.Four);
                return Values.Four;
            }
        }

        public static Value Five
        {
            get
            {
                Enqueue(Values.Five);
                return Values.Five;
            }
        }

        public static Value Six
        {
            get
            {
                Enqueue(Values.Six);
                return Values.Six;
            }
        }

        public static Value Seven
        {
            get
            {
                Enqueue(Values.Seven);
                return Values.Seven;
            }
        }

        public static Value Eight
        {
            get
            {
                Enqueue(Values.Eight);
                return Values.Eight;
            }
        }

        public static Value Nine
        {
            get
            {
                Enqueue(Values.Nine);
                return Values.Nine;
            }
        }

        public static Value Ten
        {
            get
            {
                Enqueue(Values.Ten);
                return Values.Ten;
            }
        }

        public static Operation Plus => throw new InvalidOperationException();
        public static Operation Minus => throw new InvalidOperationException();
        public static Operation Times => throw new InvalidOperationException();
        public static Operation DividedBy => throw new InvalidOperationException();

        public static Value Calculate()
        {
            try
            {
                // arithmetic calculation
                Value left = (Value)_queue.Dequeue();
                Operation operation = (Operation)_queue.Dequeue();
                Value right = (Value)_queue.Dequeue();

                operation.Left = left;
                operation.Right = right;
                var intermediate = operation.Perform();
                if (TotalResult != null)
                    TotalResult.Content = intermediate;
                else
                    TotalResult = new Value(intermediate);

                while (_queue.Count() != 0)
                {
                    left = TotalResult;
                    operation = (Operation)_queue.Dequeue();
                    right = (Value)_queue.Dequeue();

                    operation.Left = left;
                    operation.Right = right;
                    TotalResult.Content = operation.Perform();
                }
                return TotalResult;
            }
            catch (Exception ex)
            {
                TotalResult = null;
                _queue.Clear();
                return null;
            }
        }

        public static Value TotalResult { get; set; } = null;
    }
}
