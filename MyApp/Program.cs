namespace MyApp;

using Exceptions;

public class Program{
    public static void Main(String[] args){
        var calculator = new LeapYearCalculator();
        
        bool validYearWritten = false;
        Console.Write("Write a year: ");
        while(!validYearWritten){
            try{
                int userYear = Convert.ToInt32(Console.ReadLine());
                calculator.IsLeapYear(userYear);
                validYearWritten = true;
            } catch(YearTooEarlyException e) {
                Console.Write(e.GetMessage() + " Try again: ");
            } catch(Exception) {
                Console.Write("You have to write a number! Try again: ");
            }
        }
    }
}