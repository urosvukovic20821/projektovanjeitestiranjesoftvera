using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSolidRefactoringStarterSolution.LSP.Starter
{
    public static class ColorSystem
    {
        public static void Flow()
        {
            Melon melon = new Melon();
            Melon waterMelon = new WaterMelon();

            Console.WriteLine(melon.GetColor());
            Console.WriteLine(waterMelon.GetColor());
        }
    }

    public class Melon 
    {
        public virtual string GetColor()
        {
            return "Yellow";
        }
    }

    public class WaterMelon : Melon 
    {
        public override string GetColor()
        {
            return "Red";
        }
    }

    
}
