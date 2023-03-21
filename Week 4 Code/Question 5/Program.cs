namespace Question_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] originalArray = { 1, 2, 5, 4, 7, 9, 8, 6, 3 };
            //int[] sortedArray = MySort(originalArray);
            //Console.WriteLine("The original array is {0}",
            //    ArrayToString(originalArray));
            //Console.WriteLine("The sorted array is {0}",
            //    ArrayToString(sortedArray));

            //int myNumber = 13;
            //int changedNumber = ChangeAnyNumberToTwo(myNumber);
            //Console.WriteLine("The original number is {0}", myNumber);
            //Console.WriteLine("The changed number is {0}", changedNumber);

            //string[] arrayOfStrings =
            //{
            //    "Hello", "World", "CAB201", "June", "Tenth"
            //};
            //Console.WriteLine("The array is {0}",
            //    ArrayToString(arrayOfStrings));

            Person[] people = new Person[]
            {
                new Person("Tran", "Dan"),
                new Person("Smith", "John"),
                new Person("Reynolds", "Ryan")
            };

            Console.WriteLine("The people are {0}",
                ArrayToString(people));
        }

        static int ChangeAnyNumberToTwo(int number)
        {
            number = 2;
            Console.WriteLine("In the method, number is {0}", number);
            return number;
        }

        static int[] MySort(int[] array)
        {
            // This will cause a "pass by reference" behaviour
            int[] newArray = array;

            // Make a copy of the original array, to enforce the
            // "pass by value" behaviour
            //int[] newArray = new int[array.Length];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    newArray[i] = array[i];
            //}

            // Print the array
            Console.WriteLine("The original array is {0}",
                ArrayToString(newArray));
            Console.WriteLine("Sorting...");
            // Sort the array
            Array.Sort(newArray);
            return newArray;
        }

        /// <summary>
        /// Convert an array to a string, separating
        /// each element by a comma (and a space)
        /// </summary>
        /// <typeparam name="T">The type of
        /// the elements</typeparam>
        /// <param name="array">The array to be converted</param>
        /// <returns>The string representation of the array</returns>
        static string ArrayToString<T>(T[] array)
        {
            // T is generic, and can be replaced by any type
            string myStr = "";
            foreach (T element in array)
            {
                myStr += element + ", ";
            }
            // Add a linebreak at the end
            myStr += "\n";
            return myStr;
        }
    }

    class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public Person(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}