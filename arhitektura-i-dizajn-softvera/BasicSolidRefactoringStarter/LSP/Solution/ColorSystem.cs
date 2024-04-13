using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicSolidRefactoringStarterSolution.LSP.Solution
{
    public static class ColorSystem
    {
        public static void Flow()
        {
            Fruit fruit = new WaterMelon();
            Console.WriteLine(fruit.GetColor());
            fruit = new Melon();
            Console.WriteLine(fruit.GetColor());
        }
    }
    public abstract class Fruit
    {
        public abstract string GetColor();
    }
    public class Melon:Fruit
    {
        public override string GetColor()
        {
            return "Yellow";
        }
    }

    public class WaterMelon : Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
}
