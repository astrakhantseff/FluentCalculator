namespace FluentCalculator
{
    public partial class FluentCalculator
    {
        // Внутренний класс для представления числовых значений
        public class Value
        {
            private readonly int _value;

            public Value(int value)
            {
                _value = value;
            }

            // Операторы для сложения, вычитания, умножения и деления
            public Operation plus => new Operation(_value, (a, b) => a + b);
            public Operation minus => new Operation(_value, (a, b) => a - b);
            public Operation times => new Operation(_value, (a, b) => a * b);
            public Operation dividedBy => new Operation(_value, (a, b) => a / b);

            // Неявное преобразование Value в int, позволяющее использовать Value как int
            public static implicit operator int(Value value) => value._value;

            // Попытка вызова значения из значения вызовет исключение,
            // или можно вернуть undefined-подобное поведение, вернув null
            // Но это потребует изменить типы возврата на Value? и Operation?
            // Для простоты реализуем исключение.
            public Value one => throw new InvalidOperationException("Cannot call a value from a value."); // Или return null; если типы возврата Value?
            public Value two => throw new InvalidOperationException("Cannot call a value from a value.");
            public Value three => throw new InvalidOperationException("Cannot call a value from a value.");
            public Value four => throw new InvalidOperationException("Cannot call a value from a value.");
            public Value five => throw new InvalidOperationException("Cannot call a value from a value.");
            public Value six => throw new InvalidOperationException("Cannot call a value from a value.");
            public Value seven => throw new InvalidOperationException("Cannot call a value from a value.");
            public Value eight => throw new InvalidOperationException("Cannot call a value from a value.");
            public Value nine => throw new InvalidOperationException("Cannot call a value from a value.");
            public Value zero => throw new InvalidOperationException("Cannot call a value from a value.");
            public Value ten => throw new InvalidOperationException("Cannot call a value from a value.");
        }
    }
}
