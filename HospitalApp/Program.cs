using System.Xml;

namespace HospitalApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var Doctors = new List<Doctor>();
            while (true)
            {
                //TODO: Create Menu to select different things to add 1-4 etc.
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
                Doctor TempDoc = new Doctor(InputFirstName, InputLastName, (int)InputEmpID, InputSpeciality);
                File.AppendAllText("c:\\test\\test.txt", WriteFileDoctor(TempDoc));
                Console.WriteLine(TempDoc.GetDetails() + " added to the file system.");
                ReadFileDoctor("c:\\test\\test.txt");
                //Doctors.Add(TempDoc);  // not going to add doc to list from UI - going to write to file and then input to list from file
                //Doctors.Add(new Doctor(InputFirstName, InputLastName, (int)InputEmpID, InputSpeciality));
                WriteToConsoleAllDoctors();
                //TODO add logic to import data from file into Doctors list
            };

            string WriteFileDoctor(Doctor doctor)
            {
                return
                doctor.EmpID.ToString() + ',' + doctor.FirstName + ',' + doctor.LastName + ',' + doctor.Speciality + "\n";
            }

            void WriteToConsoleAllDoctors()
            {
                Doctors.ForEach(doctor =>
                {
                    Console.WriteLine(doctor.EmpID);
                    Console.WriteLine(doctor.FirstName);
                    Console.WriteLine(doctor.LastName);
                    Console.WriteLine(doctor.Speciality);
                });
            }

            void ReadFileDoctor(string filename)
            {
                var lines = File.ReadLines(filename);
                //lines.ForEach(line => { Console.WriteLine(line); });
                foreach (var line in lines)
                {
                    string[] newLine = line.Split(',');
                    Doctor doctor = new Doctor(newLine[1], newLine[2], System.Convert.ToInt16(newLine[0]), newLine[3]);
                    Doctors.Add(doctor);
                }

                

            }
        }
    }
}