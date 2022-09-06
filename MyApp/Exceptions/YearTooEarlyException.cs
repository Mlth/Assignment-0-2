namespace Exceptions;

public class YearTooEarlyException : Exception {
    public YearTooEarlyException(){

    }

    public string GetMessage(){
        return "A year before 1582 was chosen!";
    }
}