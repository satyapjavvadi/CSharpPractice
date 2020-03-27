using System;

namespace ArrayPractice
{
    class Program
    {
        public static void printArray(int[] array)
        {
            Console.Write("[");
            for (int i = 0; i < array.Length; i++)
            {
                int item = array[i];
                Console.Write(item);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.Write("]");
            Console.WriteLine();

        }
        static void Main(string[] args)
        {
            int[] intArray1;
            int[] intArray2 = new int[4];
            printArray(intArray2);
            int[] intArray3 = { 5, 2, 9, 1, 3 };

            string[] shoppingList = { "bannans", "apples", "pears" };


            //string[] stArray = Array.ConvertAll(intArray2, ele => ele.ToString());
            //Console.WriteLine(string.Join(" ", stArray));

            intArray2[0] = 10;
            intArray2[1] = 8;
            intArray2[2] = 5;
            intArray2[3] = 10;

            //print out arrays

            Console.WriteLine(string.Join(" ", intArray2));

            Console.WriteLine(string.Join(" ", intArray3));

            printArray(intArray2);
            printArray(intArray3);

            //retrieve objects
            Console.WriteLine(intArray2[3]);

            //Given functions
            Array.Sort(intArray3);
            printArray(intArray3);


        }
    }
}