using System;
using System.Collections.Generic;
using System.Linq;

namespace Calculator
{
    public static class MathConverter
    {
        // *** Radian To Degree ***

        public static double RadianToDegree(double radian)
        {
            return radian * 180 / Math.PI;
        }

        // *** Degree To Radian ***

        public static double DegreeToRadian(IEnumerable<int> arr)
        {
            var enumerable = arr as int[] ?? arr.ToArray();
            return DegreeToRadian(enumerable.ElementAtOrDefault(0),
                enumerable.ElementAtOrDefault(1),
                enumerable.ElementAtOrDefault(2));
        } 

        public static double DegreeToRadian(int degree)
        {
            return DegreeToRadian(degree, 0, 0);
        }

        public static double DegreeToRadian(int degree, int minute)
        {
            return DegreeToRadian(degree, minute, 0);
        }

        public static double DegreeToRadian(int degree, int minute, int second)
        {
            return ((degree + minute / 60 + second / 3600) * Math.PI) / 180;
        }

        // *** Radian To Grad ***

        public static double RadianToGrad(double radian)
        {
            return radian * 200 / Math.PI;
        }

        // *** Grad To Radian ***

        public static double GradToRadian(IEnumerable<int> arr)
        {
            var enumerable = arr as int[] ?? arr.ToArray();
            return GradToRadian(enumerable.ElementAtOrDefault(0),
                enumerable.ElementAtOrDefault(1),
                enumerable.ElementAtOrDefault(2));
        }

        public static double GradToRadian(int degree)
        {
            return GradToRadian(degree, 0, 0);
        }

        public static double GradToRadian(int degree, int minute)
        {
            return GradToRadian(degree, minute, 0);
        }

        public static double GradToRadian(int degree, int minute, int second)
        {
            return ((degree + minute / 100 + second / 10000) * Math.PI) / 200;
        }
    }
}