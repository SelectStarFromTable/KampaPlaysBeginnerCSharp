namespace Lesson20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonGenerator();
        }

        static void PersonGenerator()
        {
            //TODO create person

            List<Person> people = new List<Person>();

            people.Add(new Person
            {
                FirstName = "John",
                LastName = "Smith"
            });

            string test = people[0].GetFullName();

            Console.WriteLine(test);
        }
    }
}