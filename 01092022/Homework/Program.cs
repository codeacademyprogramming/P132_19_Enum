using System;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //==========================================
            //Remove array element
            //==========================================
            //int[] arr = { 1, 52, 33, -34, 15, 6, };

            //for(int i = 2; i < arr.Length-1; i++)
            //{
            //    var temp = arr[i];
            //    arr[i] = arr[i + 1];
            //    arr[i + 1] = temp;
            //}

            //Array.Resize(ref arr, arr.Length-1);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            object obj = 34;
            obj = "Hikmet";


            dynamic str = 45;
            str = new int[] {23,5,6};


            var result = str.Name;

            Console.WriteLine(result);

            var num = 45;
            dynamic numDyn = 56;

            Student student = new Student("fd","fd");

        }


    }
}
