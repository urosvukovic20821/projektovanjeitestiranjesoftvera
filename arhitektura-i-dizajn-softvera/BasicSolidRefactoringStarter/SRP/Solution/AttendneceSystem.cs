using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSolidRefactoringStarterSolution.SRP.Solution
{
    public static class AttendneceSystem
    {
        public static void Flow()
        {
            var attendenceFlow = new AttendenceFlow();
            attendenceFlow.AddAttendnece();
            attendenceFlow.DeleteAttendence();
        }
    }

    public class AttendenceFlow
    {
        private readonly MailSender _mailSender;
        private readonly Logger _logger;

        public AttendenceFlow()
        {
            _mailSender = new MailSender();
            _logger = new Logger();
        }

        public void AddAttendnece()
        {
            Console.WriteLine("Attendnece added");
            _mailSender.SendAttendneceEmail();
            _logger.LogInformation();
        }

        public void DeleteAttendence()
        {
            Console.WriteLine("Attendence deleted");
            _mailSender.SendAttendneceEmail();
            _logger.LogInformation();
        }
    }

    internal class Logger
    {
        public void LogInformation()
        {
            Console.WriteLine($"Information logged.");
        }
    }

    internal class MailSender
    {
        public void SendAttendneceEmail()
        {
            Console.WriteLine("Email sent");
        }
    }
}
