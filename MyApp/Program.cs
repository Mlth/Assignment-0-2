namespace MyApp;

public class Program{
    public static void Main(String[] args){
        var calculator = new LeapYearCalculator();
        
        Console.Write("Write a year: ");
        int userYear = Convert.ToInt32(Console.ReadLine());

        calculator.IsLeapYear(userYear);
    }
}