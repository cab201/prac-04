namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] array =
            {
                1.1, 2.3, 4.8, 9.2, 0.7, 6.5, 3.3
            };
            double average = AverageArray(array);
            foreach (double number in array)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine("\nThe average is {0}",
                average);
        }

        static double AverageArray(double[] array)
        {
            double total = 0;
            foreach (double number in array)
            {
                total += number;
            }
            // Average = Sum / Number of elements
            return total / array.Length;
        }
    }
}