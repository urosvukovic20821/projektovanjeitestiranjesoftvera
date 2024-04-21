using BusinessLogic;

namespace ConsoleApp3Layer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyBusiness myBusiness = new MyBusiness();
            myBusiness.ProcessData();
        }
    }
}
