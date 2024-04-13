using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSolidRefactoringStarterSolution.ISP.Starter
{
    public static class CarSystem
    {
        public static void Flow()
        {
            ICar dagonJeep = new OldJeep();
            dagonJeep.StartEngine();
            dagonJeep.Drive();
            dagonJeep.StartAIAssistant();
        }
    }

    public interface ICar
    {
        void StartEngine();
        void Drive();
        void StartAIAssistant();
    }

    public class OldJeep : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Old Jeep driving");
        }

        public void StartAIAssistant()
        {
            throw new NotImplementedException();
        }

        public void StartEngine()
        {
            Console.WriteLine("Old Jeep engine started");
        }
    }
}
