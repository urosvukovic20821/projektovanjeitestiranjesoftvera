try
{
    //Single Responsibility Principle (SRP)
    BasicSolidRefactoringStarterSolution.SRP.Starter.AttendneceSystem.Flow();
    BasicSolidRefactoringStarterSolution.SRP.Solution.AttendneceSystem.Flow();
    //Open/Closed Principle (OCP)
    BasicSolidRefactoringStarterSolution.OCP.Starter.FeeCalculatorSystem.Flow();
    BasicSolidRefactoringStarterSolution.OCP.Solution.FeeCalculatorSystem.Flow();
    //Liskov Substitution Principle (LSP)
    BasicSolidRefactoringStarterSolution.LSP.Starter.ColorSystem.Flow();
    BasicSolidRefactoringStarterSolution.LSP.Solution.ColorSystem.Flow();
    //Interface Segregation Principle (ISP)
    BasicSolidRefactoringStarterSolution.ISP.Starter.CarSystem.Flow();
    BasicSolidRefactoringStarterSolution.ISP.Solution.CarSystem.Flow();
    //Dependency Inversion Principle (DIP)
    BasicSolidRefactoringStarterSolution.DIP.Starter.SalarySystem.Flow();
    BasicSolidRefactoringStarterSolution.DIP.Solution.SalarySystem.Flow();
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}