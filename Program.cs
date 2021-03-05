using System;

namespace Array_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 8, 3, 4, 2, 8, 7, 6, 1, 4, 1};
            int[] _array = ConectTwoElements(ref array);

            for (int i = 0; i < _array.Length; i++)
            {
                Console.WriteLine(_array[i]);
            }
        }
        public static int[] ConectTwoElements(ref int[] array)
        {
            int[] _array = new int[10];
            for (int i = 0; i < array.Length / 2; i++)
            {
                _array[i] = array[i];
            }
            int j = 0;
            for (int i = array.Length - 1; i >= array.Length / 2; i--)
            {
                _array[j++] += array[i];
            }
            return array;
        }
    }
}
