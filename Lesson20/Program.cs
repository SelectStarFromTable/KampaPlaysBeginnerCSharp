namespace Lesson20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PersonGenerator();
            PersonConsole();
        }

        static void PersonGenerator()
        {
            
            List<Person> people = new List<Person>();

            people.Add(new Person
            {
                FirstName = Console.ReadLine()
                ,LastName = Console.ReadLine()

            }); ; ;
            people.ForEach(person => { string fname; fname = person.GetFullName(); Console.WriteLine(fname); });    
      
        }

        static void PersonConsole()
        {
            while(true)
            {
                Console.WriteLine("Enter Any Text to Print Person or Exit to Quit");
                string text = Console.ReadLine();
                Console.Clear();
                if (text != "Exit" ) 
                { 
                    PersonGenerator(); 
               
                     
                } 
                else { break; }
                
            }


        }
    }
}