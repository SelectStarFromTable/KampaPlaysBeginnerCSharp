namespace HospitalApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor = new Doctor("David", "Lynch", 1, "Heart");
            
                     
            Console.WriteLine(doctor.GetDetails());
        }
    }
}