using System.Xml.Serialization;
using System.Linq;
namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = { 1, 5, 4, 6, 8, 9, 7, 2, 3 };
            int[] newArray = MySort(myArray);
            Console.WriteLine("\nThe sorted array");
            foreach (int number in myArray)
            {
                Console.Write(number + ", ");
            }
        }

        static int[] MySort(int[] array)
        {
            // Print out the array
            Console.WriteLine("The original array:");
            foreach (int number in array)
            {
                Console.Write(number + ", ");
            }
            // Sort the array
            Array.Sort(array);
            // Then return it
            return array;
        }









        static void ValueAndReferenceDemo()
        {
            int[] myNumber = { 13 };
            Console.WriteLine("Before changing, my number was {0}",
                myNumber[0]);
            ChangeNumber(myNumber);
            Console.WriteLine("After changing, my number is {0}",
                myNumber[0]);
            // Guess: 13 - 13 - 201 - 13 (or 201?)
        }

        /// <summary>
        /// Change any integer to 201
        /// </summary>
        /// <param name="number">The number to be changed to 201</param>
        static void ChangeNumber(int number)
        {
            Console.WriteLine("Inside method, before changing, my number is {0}",
                number);
            number = 201;
            Console.WriteLine("Inside method, after changing, my number is {0}",
                number);
        }

        static void ChangeNumber(int[] numbers)
        {
            Console.WriteLine("Inside method, before changing, my number is {0}",
                numbers[0]);
            numbers[0] = 201;
            Console.WriteLine("Inside method, after changing, my number is {0}",
                numbers[0]);
        }
    }
}