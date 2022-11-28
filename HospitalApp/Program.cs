namespace HospitalApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Doctor> doctors = new List<Doctor>();
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
                    Console.WriteLine("Enter Doctor FirstName");
                    string InputFirstName = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("Enter Doctor LastName");
                    string InputLastName = Console.ReadLine();
                    Console.WriteLine("Enter Doctor EmpID");
                    int InputEmpID = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Doctor Speciality");
                    string InputSpeciality = Console.ReadLine();
                    doctors.Add(new Doctor(InputFirstName, InputLastName, InputEmpID, InputSpeciality));
                    //Console.WriteLine(NewDoctor.GetFullName());
                    //Console.Clear(); }

                }

            }
        }
    }
}