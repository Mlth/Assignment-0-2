namespace MyApp;

public class LeapYearCalculator {
    public bool IsLeapYear(int year){
        if(year%4 == 0 && (year%100 != 0 || year%400 == 0)){
            Console.WriteLine("yay");
            return true;
        }
        Console.WriteLine("nay");
        return false;
    }
}