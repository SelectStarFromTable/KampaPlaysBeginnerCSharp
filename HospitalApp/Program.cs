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
                    Doctor doctor = new Doctor("Joe", "Smith", 99, "Lung");
                    Console.WriteLine(doctor.GetDetails());
                    doctor.Page();
                    //Console.WriteLine("Enter FirstName");
                    //string InputFirstName = Console.ReadLine();
                    //Console.Clear();
                    //Console.WriteLine("Enter LastName");
                    //string InputLastName = Console.ReadLine();
                    //Console.Clear(); }

                }

            }
        }
    }
}