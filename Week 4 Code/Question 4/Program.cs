namespace Question_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] myArray = 
                { 1.2, 2.3, 3.5, 6.0, 9.9 };
            double myAverage = AverageArray(myArray);
            Console.WriteLine("My average is {0}",
                myAverage);
        }

        static double AverageArray(double[] array)
        {
            // Average = sum / number_of_elements
            double sum = 0;
            foreach (double number in array)
            {
                sum += number;
            }
            return sum / array.Length;
        }
    }
}