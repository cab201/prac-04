namespace Question_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray =
            {
                1, 3, 4, 7, 2, 3, 6, 7, 4, 3, 7, 2, 8, 1
            };
            int gpa = 7;

            string[] myStrs =
            {
                "Hello",
                "Hi",
                "Hello",
                "CAB201",
                "Hello"
            };
            string key = "Hello";

            Person[] people =
            {
                new Person("Dan", "Tran"),
                new Person("John", "Smith"),
                new Person("Dan", "Tran"),
            };

            Person search = new Person("Dan", "Tran");

            PrintArray(people);
            Console.WriteLine("Key {0} first found at index {1}",
                search, FindFirst(people, search));
            Console.WriteLine("Key {0} last found at index {1}",
                search, FindLast(people, search));
            List<int> occurrences = FindAll(people, search);
            Console.WriteLine("Key {0} found at the following positions",
                search);
            //foreach (int position in occurrences)
            //{
            //    Console.Write(position + ",");
            //}
            PrintArray(occurrences.ToArray());
        }

        // Find the index of the first occurence of
        // the key in the array. If not found, return -1
        static int FindFirst<T>(T[] ints, T searchKey)
        {
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i].Equals(searchKey)) return i;
            }
            return -1;
        }

        // Find the index of the last occurence of
        // the key in the array. If not found, return -1
        static int FindLast<T>(T[] ints, T searchKey)
        {
            int lastIndex = -1;
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i].Equals(searchKey)) lastIndex = i;
            }
            return lastIndex;
        }

        // Find all the indices of occurrences of the key
        // in the array
        static List<int> FindAll<T>(T[] ints, T searchKey)
        {
            List<int> indices = new List<int>();
            for (int i = 0; i < ints.Length; i++)
            {
                if (ints[i].Equals(searchKey)) indices.Add(i);
            }
            return indices;
        }

        static void PrintArray<T>(T[] array)
        {
            foreach (T str in array)
            {
                Console.Write(str + ", ");
            }
            // Add a linebreak
            Console.WriteLine();
        }
    }

    class Person
    {
        string LastName { get; set; }
        string FirstName { get; set; }

        public Person(string lastName, string firstName)
        {
            LastName = lastName;
            FirstName = firstName;
        }

        public override bool Equals(object? obj)
        {
            Person otherPerson = (Person)obj;
            return otherPerson.LastName == LastName && otherPerson.FirstName == FirstName;
        }

        public override string? ToString()
        {
            return FirstName + " " + LastName;
        }
    }
}