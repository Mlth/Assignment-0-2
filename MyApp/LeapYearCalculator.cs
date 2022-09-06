namespace MyApp;

using Exceptions;

public class LeapYearCalculator {
    public bool IsLeapYear(int year){
        if(year < 1582){
            throw new YearTooEarlyException();
        } else if(year%4 == 0 && (year%100 != 0 || year%400 == 0)){
            Console.Write("yay");
            return true;
        }
        Console.Write("nay");
        return false;
    }
}