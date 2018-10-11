using Calculator.Tests.TestValues;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class FunctionsTest
    {

        // ------ SINUS --------
        public static object[] LocalSinusTestSource = SinusRadians.TestSource;
        [Test, TestCaseSource(nameof(LocalSinusTestSource))]
        public static void SinusTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Sinus(rad)));
        }

        // ------ COSINUIS -------
        public static object[] LocalCosinusTestSource = CosinusRadians.TestSource;
        [Test, TestCaseSource(nameof(LocalCosinusTestSource))]
        public static void CosinusTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Cosinus(rad)));
        }

        // ------ TANGENS -------
        public static object[] LocalTangensTestSource = TangensRadians.TestSource;
        [Test, TestCaseSource(nameof(LocalTangensTestSource))]
        public static void TangensTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Tangens(rad)));
        }

        // ------ COTANGENS -------
        public static object[] LocalCotangensTestSource = CotangensRadians.TestSource;
        [Test, TestCaseSource(nameof(LocalCotangensTestSource))]
        public static void CotangensTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Cotangens(rad)));
        }

        // ------ SECANS -------
        public static object[] LocalSecansTestSource = SecansRadians.TestSource;
        [Test, TestCaseSource(nameof(LocalSecansTestSource))]
        public static void SecansTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Secans(rad)));
        }

        // ------ COSECANS -------
        public static object[] LocalCosecansTestSource = CosecansRadians.TestSource;
        [Test, TestCaseSource(nameof(LocalCosecansTestSource))]
        public static void CosecansTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Cosecans(rad)));
        }
    }
}
