using System;

namespace ArrayLib
{
    public static class ArrayHelper
    {
        public static int FindMax(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array must not be empty");
            int max = arr[0];
            foreach (var n in arr)
                if (n > max) max = n;
            return max;
        }

        public static int FindMin(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                throw new ArgumentException("Array must not be empty");
            int min = arr[0];
            foreach (var n in arr)
                if (n < min) min = n;
            return min;
        }
    }
}