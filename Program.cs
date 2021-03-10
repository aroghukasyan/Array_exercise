using System;
using System.Collections.Generic;

namespace Array_exercise
{
    class Program
    {
        static void Main(string[] args)
        {     
            //int[] array = { 5, 8, 3, 4, 2, 8, 7, 6, 1, 4, 1};
            //int[] _array = ConectTwoElements(ref array);

            //for (int i = 0; i < _array.Length; i++)
            //{
            //    Console.Write($" {_array[i]} ");
            //}
            //Console.WriteLine();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.Write($" {array[i]} ");
            //}
            var arr = ConectTwoElementsWithList(new List<int> { 1, 5, 8, 9, 4, 2, 4 });
            arr.ForEach(x => Console.Write($"| {x} |"));
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
            array[0] = 1000;
            return _array;
        }
        public static List<int> ConectTwoElementsWithList(List<int> array)
        {
            array.ForEach(x => Console.Write($" {x} "));
            Console.WriteLine();
            List<int> arr = new List<int>();
            if(array.Count % 2 == 0)
            {
                for (int i = 0; i < array.Count / 2; i++)
                { 
                    arr.Add(array[i]);
                }
                array.Reverse();
                for (int i = 0; i < array.Count / 2; i++)
                {
                    arr[i] += array[i];
                }
            }
            else
            {
                for (int i = 0; i < array.Count / 2; i++)
                {
                    arr.Add(array[i]);
                }
                array.Reverse();
                for (int i = 0; i < array.Count / 2; i++)
                {
                    arr[i] += array[i];
                }
                arr.Add(array[array.Count / 2]);
            }
            return arr;
        }
    }
}
