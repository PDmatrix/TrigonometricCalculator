using System;
using System.Windows.Forms;

namespace Calculator
{
    public static class Functions
    {
        private static void Error()
        {
            MessageBox.Show(@"Введенно некоректное значение", @"Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private static bool InRange(this double value, double first, double second)
        {
            return first < value && value < second;
        }

        private static bool InRangeEq(this double value, double first, double second)
        {
            return first <= value && value <= second;
        }

        public static double Sinus(double x)
        {
            return Math.Sin(x);
        }

        public static double Cosinus(double x)
        {
            return Math.Cos(x);
        }

        public static double Tangens(double x)
        {
            if (Math.Cos(x).IsApproximatelyEqualTo(0, 0.0001))
            {
                Error();
                return double.NaN;
            }

            return Math.Tan(x);
        }

        public static double Cotangens(double x)
        {
            if (Math.Tan(x).IsApproximatelyEqualTo(0, 0.0001))
            {
                Error();
                return double.NaN;
            }

            return 1 / Math.Tan(x);
        }

        public static double Secans(double x)
        {
            if (Math.Cos(x).IsApproximatelyEqualTo(0, 0.0001))
            {
                Error();
                return double.NaN;
            }

            return 1 / Math.Cos(x);
        }

        public static double Cosecans(double x)
        {
            if (Math.Sin(x).IsApproximatelyEqualTo(0, 0.0001))
            {
                Error();
                return double.NaN;
            }

            return 1 / Math.Sin(x);
        }

        public static double Arcsinus(double x)
        {
            if (!x.InRangeEq(-1, 1))
            {
                Error();
                return double.NaN;
            }

            return Math.Asin(x);
        }

        public static double Arccosinus(double x)
        {
            if (!x.InRangeEq(-1, 1))
            {
                Error();
                return double.NaN;
            }

            return Math.Acos(x);
        }

        public static double Arctangens(double x)
        {
            /*if (!x.InRange(-(Math.PI / 2), Math.PI / 2))
            {
                Error();
                return double.NaN;
            }*/

            return Math.Atan(x);
        }

        public static double Arccotangens(double x)
        {
            /*if (!x.InRange(0, Math.PI))
            {
                Error();
                return double.NaN;
            }*/

            return Math.PI / 2 - Arctangens(x);
        }

        public static double Sinush(double x)
        {
            return Math.Sinh(x);
        }

        public static double Cosinush(double x)
        {
            return Math.Cosh(x);
        }

        public static double Tangensh(double x)
        {
            if (Math.Cosh(x).IsApproximatelyEqualTo(0, 0.0001))
            {
                Error();
                return double.NaN;
            }

            return Math.Tanh(x);
        }

        public static double Cotangensh(double x)
        {
            if (Math.Tanh(x).IsApproximatelyEqualTo(0, 0.0001))
            {
                Error();
                return double.NaN;
            }

            return 1 / Math.Tanh(x);
        }

        public static double Areasinus(double x)
        {
            return Math.Log(x + Math.Sqrt(x * x + 1, 2));
        }

        public static double Areacosinus(double x)
        {
            return Math.Log(x + Math.Sqrt(x * x - 1, 2));
        }

        public static double Areatangens(double x)
        {
            return Math.Log((1 + x) / (1 - x)) / 2;
        }

        public static double Areacotangens(double x)
        {
            return Math.Log((x + 1) / (x - 1)) / 2;
        }
    }
}
