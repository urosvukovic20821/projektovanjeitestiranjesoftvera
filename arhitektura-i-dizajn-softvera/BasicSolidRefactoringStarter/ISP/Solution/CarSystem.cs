using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSolidRefactoringStarterSolution.ISP.Solution
{
    public static class CarSystem
    {
        public static void Flow()
        {
            IAICar teslaCar = new TeslaCar();
            teslaCar.StartEngine();
            teslaCar.Drive();
            teslaCar.StartAIAssistant();
        }
    }

    public interface ICar
    {
        void StartEngine();
        void Drive();
    }

    public interface IAICar : ICar
    {
        void StartAIAssistant();
    }

    public class TeslaCar : IAICar
    {
        public void Drive()
        {
            Console.WriteLine("Tesla driving");
        }

        public void StartAIAssistant()
        {
            Console.WriteLine("Tesla AI assistent started");
        }

        public void StartEngine()
        {
            Console.WriteLine("Tesla engine started");
        }
    }

    
}
