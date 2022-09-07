namespace MyApp;

using Exceptions;

public class Program{
    public static void Main(String[] args){
        var calculator = new LeapYearCalculator();
        
        calculator.takeUserInput();
    }
}