using System.Collections.Immutable;

namespace HospitalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Enter any key to Continue. Type Exit to quit application");
                string text = Console.ReadLine();
                Console.Clear();
                if (text == "Exit" | text == "exit")

                {
                    break;
                }
                else
                {
                    //Doctor doctor = new Doctor("Joe", "Smith", 99, "Lung");
                    Console.WriteLine("Enter Doctor FirstName");
                    string InputFirstName = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Enter Doctor LastName");
                    string InputLastName = Console.ReadLine();
                    Console.WriteLine("Enter Doctor EmpID"); 
                    int InputEmpID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Doctor Speciality");
                    string InputSpeciality = Console.ReadLine();
                    //Doctor(InputFirstName, InputLastName, InputEmpID, InputSpeciality);
                  
                    Console.WriteLine();
                    
                    //Console.Clear(); }

                }

            }
        }
    }
}