using System;
using System.Windows.Forms;

namespace Calculator
{
    public static class Functions
    {
        public static double Sinus(double rad)
        {
            return Math.Sin(rad);
        }

        public static double Cosinus(double rad)
        {
            return Math.Cos(rad);
        }

        public static double Tangens(double rad)
        {
            return Math.Tan(rad);
        }

        public static double Cotangens(double rad)
        {
            return 1 / Tangens(rad);
        }

        public static double Secans(double rad)
        {
            return 1 / Math.Cos(rad);
        }

        public static double Cosecans(double rad)
        {
            return 1 / Math.Sin(rad);
        }

        public static double Arcsinus(double rad)
        {
            return Math.Asin(Sinus(rad));
        }

        public static double Arccosinus(double rad)
        {

            return Math.Acos(Cosinus(rad));
        }

        public static double Arctangens(double rad)
        {
            return Math.Atan(Tangens(rad));
        }

        public static double Arccotangens(double rad)
        {
            return (Math.PI / 2) - Arctangens(rad);
        }

        public static double Sinush(double rad)
        {
            return Math.Sinh(rad);
        }

        public static double Cosinush(double rad)
        {
            return Math.Cosh(rad);
        }

        public static double Tangensh(double rad)
        {
            return Math.Tanh(rad);
        }

        public static double Cotangensh(double rad)
        {
            return 1 / Tangens(rad);
        }

        public static double Areasinus(double rad)
        {
            return Math.Log(rad + Math.Pow(rad * rad + 1, 2));
        }

        public static double Areacosinus(double rad)
        {
            return Math.Log(rad + Math.Pow(rad * rad - 1, 2));
        }

        public static double Areatangens(double rad)
        {
            return Math.Log((1 + rad) / (1 - rad)) / 2;
        }

        public static double Areacotangens(double rad)
        {
            return Math.Log((rad + 1) / (rad - 1)) / 2;
        }
    }
}