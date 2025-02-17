using task2;
using FluentCalculator;

namespace Fluent.Calculator.Tests
{
    [TestFixture]
    public class FluentCalculatorTests
    {
        private decimal? InvalidValueSequence() => FluentCalculator.FluentCalculator.one.one.plus.one;
        //private decimal? InvalidOperationSequence() => FluentCalculator.FluentCalculator.plus.minus.one;

        [Test]
        public void ValueCannotCallValue()
        {
            Assert.Throws<InvalidOperationException>(() => InvalidValueSequence());
        }
       
        [Test]
        public void OperationCanCallValue()
        {
            decimal? expected = 3;
            decimal? result = FluentCalculator.FluentCalculator.one.plus.two;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void StackableToInfinity()
        {
            decimal? expected = -1;
            decimal? result = FluentCalculator.FluentCalculator.one.plus.two.plus.three.minus.one.minus.two.minus.four;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ValueResolveToPrimitiveInteger()
        {
            decimal? expected = 1m;
            decimal? result = FluentCalculator.FluentCalculator.one.plus.ten - 10m;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
