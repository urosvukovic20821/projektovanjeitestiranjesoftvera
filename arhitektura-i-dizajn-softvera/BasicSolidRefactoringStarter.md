# C# Osnove – Primena SOLID Principa

# Zadatak

Potrebno je kreirati konzolnu aplikaciju u kojoj će te refaktorisati kod primenom odgovarajućeg SOLID princinpa.

# SINGLE RESPONSIBILITY PRINCIPLE (SRP)

Refaktoritisati kod tako da zadovolji _Single Responsibility Principle (SRP) => Modul ima samo jedan razlog za promenu._

```
public static void Main()
{
     AddAttendence();
     SendAttendenceEmail();
     LogInformation();
     DeleteAttendence();
     SendAttendenceEmail();
     LogInformation();
}

public static void AddAttendence()
{
     Console.WriteLine("Attendence added");
}

public static void DeleteAttendence()
{
     Console.WriteLine("Attendence deleted");
}

public static void SendAttendenceEmail()
{
     Console.WriteLine("Email sent");
}

void LogInformation()
{
     Console.WriteLine($"Information logged.");
}
```
# OPEN/CLOSED PRINCIPLE

Refaktoritisati kod tako da zadovolji _Open/Closed Principle => Modul je otvoren za proširenje a zatvoren za modifikaciju._

```
public enum PaymentType
{
      Visa,
      Mastercard
}

public class FeeCalculator
{
      public decimal GetTransactionFee(decimal amount,PaymentType paymentType)
      {
            decimal transactionFee = 0;
            if (paymentType == PaymentType.Visa)
            {
                  transactionFee = amount * 0.4m;
            }
            else if(paymentType == PaymentType.Mastercard)
            {
                  transactionFee = amount * 0.5m;
            }
            return transactionFee;
      }      
}

public static void Main()
{
      FeeCalculator fc = new FeeCalculator();
      Console.WriteLine(fc.GetTransactionFee(2500, PaymentType.Visa));
      Console.WriteLine(fc.GetTransactionFee(2500, PaymentType.Mastercard));
}
```
# LISKOV SUBSTITUTION PRINCIPLE (LSP)
Refaktoritisati kod tako da zadovolji _Liskov Substitution Principle (LSP) => moguće je koristiti bilo koju izvedenu klasu umesto roditeljske klase pri čenu se ponašanje zadržava bez modifikacije._

```
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

public static void Main()
{
      Melon melon = new Melon();
      Melon waterMelon = new WaterMelon();
      Console.WriteLine(melon.GetColor());
      Console.WriteLine(waterMelon.GetColor());
}
```
# INTERFACE SEGREGATION PRINCIPLE
Refaktoritisati kod tako da zadovolji _Interface Segregation Principle => klijenti ne smeju biti primorani da implementiraju interfejs koji ne koriste._

```
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

public static void Main()
{
      ICar oldJeep = new OldJeep();
      oldJeep.StartEngine();
      oldJeep.Drive();
      oldJeep.StartAIAssistant();
}
```
# DEPENDENCY INVERSION PRINCIPLE (DIP)
Refaktoritisati kod tako da zadovolji _Dependency Inversion Principle (DIP) =>moduli visokog nivoa ne smeju da zavise od modula niskog nivoa._ 

```
public class SalaryCalculator2022
{
      public decimal CalculateSalary(decimal hoursWorked,decimal hourlyRate)
      {
            return hoursWorked * hourlyRate;
      }
}

public class Employee
{
      public string Name { get; set; }
      public decimal HoursWorked { get; set; }
      public decimal HourlyRate { get; set; }

      public decimal GetSalary()
      {
            SalaryCalculator2022 salaryCalculator = new SalaryCalculator2022();
            return salaryCalculator.CalculateSalary(HoursWorked,HourlyRate);
      }
}

public static void Main()
{
      Employee employee = new Employee();
      employee.Name = "John";
      employee.HoursWorked = 40;
      employee.HourlyRate = 10;
      Console.WriteLine(employee.GetSalary());
}
```

