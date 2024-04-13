using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSolidRefactoringStarterSolution.SRP.Starter
{
    public static class AttendneceSystem
    {
        public static void Flow()
        {
            AddAttendnece();
            DeleteAttendence();
            SendAttendenceEmail();
            LogInformation();
        }
        public static void AddAttendnece()
        {
            Console.WriteLine("Attendnece added");
        }

        public static void DeleteAttendence()
        {
            Console.WriteLine("Attendence deleted");
        }

        public static void SendAttendenceEmail()
        {
            Console.WriteLine("Email sent");
        }

        public static void LogInformation()
        {
            Console.WriteLine($"Information logged.");
        }
    }
}
