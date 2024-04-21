using Core.Interfaces;
using DomainLogic;
using Infrastructure;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPersonBusiness personBusiness = new PersonBusiness(new InMemoryDataRepository());
        }
    }
}
