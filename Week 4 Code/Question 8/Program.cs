namespace Question_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myNumber = 13;
            Console.WriteLine("My number was {0}",
                myNumber);
            ChangeNumber(out myNumber);
            Console.WriteLine("My number is now {0}",
                myNumber);
        }

        static void ChangeNumber(out int number)
        {
            number = 201;
        }

        //static void ChangeNumber(ref int number)
        //{
        //    number = 201;
        //}
    }
}