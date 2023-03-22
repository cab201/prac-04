namespace Question_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings =
            {
                "HeLlo",
                "WOrLd",
                "CAB201",
                "DaN",
                "Cat"
            };
            PrintArray(strings);
            ToLower(strings);
            PrintArray(strings);
        }

        static void ToLower(string[] strings)
        {
            for (int i = 0; i < strings.Length; i++)
            {
                strings[i] = strings[i].ToLower();
            }
        }

        /// <summary>
        /// Display an array, sepearated by commas.
        /// </summary>
        /// <param name="array">The array to be displayed</param>
        static void PrintArray(string[] array)
        {
            foreach (string str in array)
            {
                Console.Write(str + ", ");
            }
            // Add a linebreak
            Console.WriteLine();
        }
    }
}