namespace CSharpExam1;

public class Program
{
    static void Main(string[] args)
    {
        CSharpEx1 person = new CSharpEx1();
        
        Console.WriteLine("What is your name? ");
        person.Name = Console.ReadLine();
        Console.WriteLine("Male or Female (1 for Male, 0 for Female): ");
        person.Gender = Console.ReadLine() == "1";
        Console.WriteLine("How old are you? ");
        person.Age = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Simple Properties Demo");
        Console.WriteLine($"Person details: Name = {person.Name}, Gender = {(person.Gender ? "Male" : "Female")}, Age = {person.Age}");
        
        Console.WriteLine("Enter the age number you change? ");
        int ageChange = int.Parse(Console.ReadLine());
        person.Age += ageChange;
        
        Console.WriteLine($"Person details (after incrementing age): Name = {person.Name}, Gender = {(person.Gender ? "Male" : "Female")}, Age = {person.Age}");
    }
}