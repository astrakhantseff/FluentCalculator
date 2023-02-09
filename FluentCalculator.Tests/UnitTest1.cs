using task2;

namespace Fluent.Calculator.Tests
{
    [TestFixture]
    public class FluentCalculatorTests
    {
        private decimal? InvalidValueSequence() => FluentCalculator.One.One.Plus.One.Result;
        private decimal? InvalidOperationSequence() => FluentCalculator.Plus.Minus.One.Result;

        [Test]
        public void ValueCannotCallValue()
        {
            Assert.Throws<InvalidOperationException>(() => InvalidValueSequence());
        }
       
        [Test]
        public void OperationCannotCallOperation()
        {
            Assert.Throws<InvalidOperationException>(() => InvalidOperationSequence());
        }

        [Test]
        public void OperationCanCallValue()
        {
            decimal? expected = 3;
            decimal? result = FluentCalculator.One.Plus.Two.Result;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void StackableToInfinity()
        {
            decimal? expected = -1;
            decimal? result = FluentCalculator.One.Plus.Two.Plus.Three.Minus.One.Minus.Two.Minus.Four.Result;
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ValueResolveToPrimitiveInteger()
        {
            decimal? expected = 1m;
            decimal? result = (FluentCalculator.One.Plus.Ten - 10m).Result;
            Assert.That(result, Is.EqualTo(expected));
        }
    }
}
