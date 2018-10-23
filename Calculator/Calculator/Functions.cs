using System;
using System.Windows.Forms;

namespace Calculator
{
    public static class Functions
    {
        // Вспомогательная функция для вывода сообщения об ошибке
        private static void Error()
        {
            MessageBox.Show(@"Введенно некоректное значение", 
                @"Ошибка", 
                MessageBoxButtons.OK, 
                MessageBoxIcon.Error);
        }

        // Вспомогательная функция для проверки значений
        private static bool InRange(this double value, double first, double second)
        {
            return first < value && value < second;
        }

        // Вспомогательная функция для проверки значений
        private static bool InRangeEq(this double value, double first, double second)
        {
            return first <= value && value <= second;
        }

        // Синус
        public static double Sinus(double x)
        {
            return Math.Sin(x);
        }

        // Косинус
        public static double Cosinus(double x)
        {
            return Math.Cos(x);
        }

        // Тангенс
        public static double Tangens(double x)
        {
            if (!Math.Cos(x).IsApproximatelyEqualTo(0, 0.0001))
                return Math.Tan(x);

            Error();
            return double.NaN;

        }

        // Котангенс
        public static double Cotangens(double x)
        {
            if (!Math.Tan(x).IsApproximatelyEqualTo(0, 0.0001))
                return 1 / Math.Tan(x);

            Error();
            return double.NaN;

        }

        // Секанс
        public static double Secans(double x)
        {
            if (!Math.Cos(x).IsApproximatelyEqualTo(0, 0.0001))
                return 1 / Math.Cos(x);

            Error();
            return double.NaN;

        }

        // Косеканс
        public static double Cosecans(double x)
        {
            if (!Math.Sin(x).IsApproximatelyEqualTo(0, 0.0001))
                return 1 / Math.Sin(x);

            Error();
            return double.NaN;

        }

        // Арксинус
        public static double Arcsinus(double x)
        {
            if (x.InRangeEq(-1, 1))
                return Math.Asin(x);

            Error();
            return double.NaN;

        }

        // Арккосинус
        public static double Arccosinus(double x)
        {
            if (x.InRangeEq(-1, 1))
                return Math.Acos(x);

            Error();
            return double.NaN;

        }

        // Арктангенс
        public static double Arctangens(double x)
        {
            return Math.Atan(x);
        }

        // Арккотангенс
        public static double Arccotangens(double x)
        {
            return Math.PI / 2 - Arctangens(x);
        }

        // Гиперболический синус
        public static double Sinush(double x)
        {
            return Math.Sinh(x);
        }

        // Гиперболический косинус
        public static double Cosinush(double x)
        {
            return Math.Cosh(x);
        }

        // Гиперболический тангенс
        public static double Tangensh(double x)
        {
            if (!Math.Cosh(x).IsApproximatelyEqualTo(0, 0.0001))
                return Math.Tanh(x);

            Error();
            return double.NaN;
        }

        // Гиперболический котангенс
        public static double Cotangensh(double x)
        {
            if (!Math.Tanh(x).IsApproximatelyEqualTo(0, 0.0001))
                return 1 / Math.Tanh(x);

            Error();
            return double.NaN;

        }

        // Ареасинус
        public static double Areasinus(double x)
        {
            if (x * x + 1 < 0 || x + Math.Sqrt(x * x + 1) <= 0)
                Error();

            return Math.Log(x + Math.Sqrt(x * x + 1));
        }

        // Ареакосинус
        public static double Areacosinus(double x)
        {
            if (x * x - 1 < 0 || x + Math.Sqrt(x * x - 1) <= 0)
                Error();

            return Math.Log(x + Math.Sqrt(x * x - 1));
        }

        // Ареатангенс
        public static double Areatangens(double x)
        {
            if (x.IsApproximatelyEqualTo(1, 0.001) || (1 + x) / (1 - x) <= 0)
                Error();

            return Math.Log((1 + x) / (1 - x)) / 2;
        }

        // Ареакотангенс
        public static double Areacotangens(double x)
        {
            if(x.IsApproximatelyEqualTo(1, 0.001) || (x + 1) / (x - 1) <= 0)
                Error();

            return Math.Log((x + 1) / (x - 1)) / 2;
        }
    }
}
