namespace Question_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstValue = 2;
            int secondValue = 3;
            Console.WriteLine("The original values are: {0} and {1}",
                firstValue, secondValue);
            SwapValues(ref firstValue, ref secondValue);
            Console.WriteLine("The new values are: {0} and {1}",
                firstValue, secondValue);
        }

        // This method tries to swap, but doesn't because it's passing the
        // parameters by value
        static void SwapValues(int firstValue, int secondValue)
        {
            int tempValue = secondValue;
            secondValue = firstValue;
            firstValue = tempValue;
        }

        // This is the correct method
        static void SwapValues(ref int firstValue, ref int secondValue)
        {
            int tempValue = secondValue;
            secondValue = firstValue;
            firstValue = tempValue;
        }
    }
}