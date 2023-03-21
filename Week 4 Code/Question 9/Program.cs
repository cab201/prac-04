namespace Question_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double celsius = 37.5;
            Convert(celsius, out double fahrenheit, out double kelvin);
            Console.WriteLine("{0} celsius is equivalent to {1} fahrenheit and {2} kelvin",
                celsius, fahrenheit, kelvin);
        }

        static void Convert(double celsius,
            out double fahrenheit,
            out double kelvin)
        {
            fahrenheit = celsius * 9.0 / 5 + 32;
            kelvin = celsius + 273;
        }
    }
}