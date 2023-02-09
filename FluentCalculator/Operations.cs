namespace task2
{
    public class Operations
    {
        public static Operation Plus { get; } = new(OperationType.plus);
        public static Operation Minus { get; } = new(OperationType.minus);
        public static Operation Times { get; } = new(OperationType.times);
        public static Operation DividedBy { get; } = new(OperationType.dividedBy);
    }
}
