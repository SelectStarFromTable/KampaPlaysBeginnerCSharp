namespace Lesson20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // PersonGenerator();
            PersonConsole();
        }

        static void PersonGenerator(string FirstName, string LastName)
        {

            List<Person> people = new List<Person>();
            people.Add(new Person { FirstName = FirstName, LastName = LastName });
            string FullName = people[0].GetFullName();
            Console.WriteLine(FullName);

        }

        static void PersonConsole()
        {
            while (true)
            {
                Console.WriteLine("Enter any text to create and print a person's name.  Type Exit to quit application");
                string text = Console.ReadLine();
                Console.Clear();
                if (text != "exit" | text != "Exit")
                {
                    Console.WriteLine("Enter FirstName");
                    string InputFirstName = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Enter LastName");
                    string InputLastName = Console.ReadLine();
                    Console.Clear();
                    PersonGenerator(InputFirstName, InputLastName);

                }
                else { break; }

            }


        }
    }
}
