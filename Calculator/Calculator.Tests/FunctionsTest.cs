using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class FunctionsTest
    {
        // ------ SINUS --------
        [TestCase(10, -0.5440211108893698)]
        [TestCase(24, -0.9055783620066238)]
        [TestCase(56, -0.5215510020869119)]
        [TestCase(0, 0)]
        [TestCase(1, 0.8414709848078965)]
        [TestCase(420, -0.8268117243068012)]
        [TestCase(-23, 0.8462204041751706)]
        [TestCase(-1, -0.8414709848078965)]
        [TestCase(80, -0.9938886539233752)]
        [TestCase(490, -0.08833865964017233)]
        public void SinusTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Sinus(rad)));
        }

        // ------ COSINUIS -------
        [TestCase(10, -0.8390715290764524)]
        [TestCase(24, 0.424179007336997)]
        [TestCase(56, 0.853220107722584)]
        [TestCase(0, 1)]
        [TestCase(1, 0.5403023058681398)]
        [TestCase(420, 0.5624787751985085)]
        [TestCase(-23, -0.5328330203333975)]
        [TestCase(-1, 0.5403023058681398)]
        [TestCase(80, -0.11038724383904756)]
        [TestCase(490, 0.9960904985055212)]
        public void CosinusTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Cosinus(rad)));
        }
    }
}
