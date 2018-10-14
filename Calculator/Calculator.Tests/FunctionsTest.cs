using Calculator.Tests.TestValues;
using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class FunctionsTest
    {

        // ------ SINUS --------
        private static object[] _localSinusTestSource = Sinus.TestSource;
        [Test, TestCaseSource(nameof(_localSinusTestSource))]
        public static void SinusTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Sinus(rad)));
        }

        // ------ COSINUIS -------
        private static object[] _localCosinusTestSource = Cosinus.TestSource;
        [Test, TestCaseSource(nameof(_localCosinusTestSource))]
        public static void CosinusTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Cosinus(rad)));
        }

        // ------ TANGENS -------
        private static object[] _localTangensTestSource = Tangens.TestSource;
        [Test, TestCaseSource(nameof(_localTangensTestSource))]
        public static void TangensTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Tangens(rad)));
        }

        // ------ COTANGENS -------
        private static object[] _localCotangensTestSource = Cotangens.TestSource;
        [Test, TestCaseSource(nameof(_localCotangensTestSource))]
        public static void CotangensTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Cotangens(rad)));
        }

        // ------ SECANS -------
        private static object[] _localSecansTestSource = Secans.TestSource;
        [Test, TestCaseSource(nameof(_localSecansTestSource))]
        public static void SecansTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Secans(rad)));
        }

        // ------ COSECANS -------
        private static object[] _localCosecansTestSource = Cosecans.TestSource;
        [Test, TestCaseSource(nameof(_localCosecansTestSource))]
        public static void CosecansTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Cosecans(rad)));
        }

        // ------ ARCSINUS -------
        private static object[] _localArcsinusTestSource = Arcsinus.TestSource;
        [Test, TestCaseSource(nameof(_localArcsinusTestSource))]
        public static void ArcsinusTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Arcsinus(rad)));
        }

        // ------ ARCCOSINUS -------
        private static object[] _localArccosinusTestSource = Arccosinus.TestSource;
        [Test, TestCaseSource(nameof(_localArccosinusTestSource))]
        public static void ArccosinusTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Arccosinus(rad)));
        }

        // ------ ARCTANGENS -------
        private static object[] _localArctangensTestSource = Arctangens.TestSource;
        [Test, TestCaseSource(nameof(_localArctangensTestSource))]
        public static void ArctangensTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Arctangens(rad)));
        }

        // ------ ARCCOTANGENS -------
        private static object[] _localArccotangensTestSource = Arccotangens.TestSource;
        [Test, TestCaseSource(nameof(_localArccotangensTestSource))]
        public static void ArccotangensTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Arccotangens(rad)));
        }

        // ------ SINUSH -------
        private static object[] _localSinushTestSource = Sinush.TestSource;
        [Test, TestCaseSource(nameof(_localSinushTestSource))]
        public static void SinushTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Sinush(rad)));
        }

        // ------ COSINUSH -------
        private static object[] _localCosinushTestSource = Cosinush.TestSource;
        [Test, TestCaseSource(nameof(_localCosinushTestSource))]
        public static void CosinushTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Cosinush(rad)));
        }

        // ------ TANGENSH -------
        private static object[] _localTangenshTestSource = Tangensh.TestSource;
        [Test, TestCaseSource(nameof(_localTangenshTestSource))]
        public static void TangenshTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Tangensh(rad)));
        }

        // ------ COTANGENSH -------
        private static object[] _localCotangenshTestSource = Cotangensh.TestSource;
        [Test, TestCaseSource(nameof(_localCotangenshTestSource))]
        public static void CotangenshTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Cotangensh(rad)));
        }

        // ------ AREASINUS -------
        private static object[] _localAreasinushTestSource = Areasinus.TestSource;
        [Test, TestCaseSource(nameof(_localAreasinushTestSource))]
        public static void AreasinushTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Areasinus(rad)));
        }

        // ------ AREACOSINUS -------
        private static object[] _localAreacosinusTestSource = Areacosinus.TestSource;
        [Test, TestCaseSource(nameof(_localAreacosinusTestSource))]
        public static void AreacosinusTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Areacosinus(rad)));
        }

        // ------ AREATANGENS -------
        private static object[] _localAreatangensTestSource = Areatangens.TestSource;
        [Test, TestCaseSource(nameof(_localAreatangensTestSource))]
        public static void AreatangensTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Areatangens(rad)));
        }

        // ------ AREACOTANGENS -------
        private static object[] _localAreacotangensTestSource = Areacotangens.TestSource;
        [Test, TestCaseSource(nameof(_localAreacotangensTestSource))]
        public static void AreacotangensTest(double rad, double res)
        {
            Assert.IsTrue(res.IsApproximatelyEqualTo(Functions.Areacotangens(rad)));
        }
    }
}
