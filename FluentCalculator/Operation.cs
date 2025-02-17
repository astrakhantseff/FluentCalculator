using System;

namespace FluentCalculator
{
    public partial class FluentCalculator
    {
        // Внутренний класс для представления операций
        public class Operation
        {
            private readonly int _currentValue;
            private readonly Func<int, int, int> _operation;

            public Operation(int currentValue, Func<int, int, int> operation)
            {
                _currentValue = currentValue;
                _operation = operation;
            }

            // Методы для возврата значений
            public Value zero => new Value(_operation(_currentValue, 0));
            public Value one => new Value(_operation(_currentValue, 1));
            public Value two => new Value(_operation(_currentValue, 2));
            public Value three => new Value(_operation(_currentValue, 3));
            public Value four => new Value(_operation(_currentValue, 4));
            public Value five => new Value(_operation(_currentValue, 5));
            public Value six => new Value(_operation(_currentValue, 6));
            public Value seven => new Value(_operation(_currentValue, 7));
            public Value eight => new Value(_operation(_currentValue, 8));
            public Value nine => new Value(_operation(_currentValue, 9));
            public Value ten => new Value(_operation(_currentValue, 10));

            // Попытка вызова операции из операции вызовет исключение
            public Operation plus => throw new InvalidOperationException("Cannot call an operation from an operation.");
            public Operation minus => throw new InvalidOperationException("Cannot call an operation from an operation.");
            public Operation times => throw new InvalidOperationException("Cannot call an operation from an operation.");
            public Operation dividedBy => throw new InvalidOperationException("Cannot call an operation from an operation.");
        }
    }
}
