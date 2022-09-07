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

    public void takeUserInput(){
        Console.Write("Write a year: ");
        try{
            int userYear = Convert.ToInt32(Console.ReadLine());
            IsLeapYear(userYear);
        } catch(YearTooEarlyException e) {
            Console.Write(e.GetMessage());
        } catch(Exception) {
            Console.Write("You have to write a number!");
        }
    }
}