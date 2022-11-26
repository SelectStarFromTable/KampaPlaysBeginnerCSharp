namespace HospitalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor("Joe", "Smith", 99, "Lung");
            
                     
            Console.WriteLine(doctor.GetDetails());
            doctor.Page();
        }
    }
}