namespace HospitalApp
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            var Doctors = new List<Doctor>();
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

                    InputDoctor();
                    //Console.WriteLine("Enter Doctor FirstName");
                    //string? InputFirstName = Console.ReadLine();
                    //Console.Clear();
                    //Console.WriteLine("Enter Doctor LastName");
                    //string? InputLastName = Console.ReadLine();
                    //Console.WriteLine("Enter Doctor EmpID");
                    //int? InputEmpID = int.Parse(Console.ReadLine());
                    //Console.WriteLine("Enter Doctor Speciality");
                    //string? InputSpeciality = Console.ReadLine();
                    //Doctors.Add(new Doctor(InputFirstName, InputLastName, (int)InputEmpID, InputSpeciality));
                    //Doctors.ForEach(doctor => { Console.WriteLine(doctor.GetDetails()); });
                    //Console.WriteLine(NewDoctor.GetFullName());
                    //Console.Clear(); }

                }

            }

            void InputDoctor()
            {
                Console.WriteLine("Enter Doctor FirstName");
                string? InputFirstName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine("Enter Doctor LastName");
                string? InputLastName = Console.ReadLine();
                Console.WriteLine("Enter Doctor EmpID");
                int? InputEmpID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Doctor Speciality");
                string? InputSpeciality = Console.ReadLine();
                Doctors.Add(new Doctor(InputFirstName, InputLastName, (int)InputEmpID, InputSpeciality));
                Doctors.ForEach(doctor => { Console.WriteLine(doctor.GetDetails()); });
            };
        
        
        
        }
    }
}