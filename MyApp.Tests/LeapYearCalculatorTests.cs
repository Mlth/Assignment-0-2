namespace MyApp.Tests;

public class leapYearCalculatorTests
{
    [Fact]
    public void IsLeapYearWhenDivisibleByFour(){
        //Arrange
        var calculator = new LeapYearCalculator();

        //Act
        bool isLeapYearCorrect = calculator.IsLeapYear(1604);
        bool isLeapYearFalse = calculator.IsLeapYear(1602);

        //Assert
        isLeapYearCorrect.Should().Be(true);
        isLeapYearFalse.Should().Be(false);
    }

    [Fact]
    public void isNotLeapYearDivisibleByHundred(){
        var calculator = new LeapYearCalculator();

        bool isLeapYearFalse = calculator.IsLeapYear(1700);

        isLeapYearFalse.Should().Be(false);
    }

    [Fact]
    public void isLeapYearWhenDivisibleByFourHundred(){
        var calculator = new LeapYearCalculator();

        bool isLeapYearCorrect = calculator.IsLeapYear(1600);

        isLeapYearCorrect.Should().Be(true);
    }

    [Fact]
    public void triggerYearTooEarlyException(){
        var calculator = new LeapYearCalculator();

        Assert.Throws<YearTooEarlyException>(() => calculator.IsLeapYear(1300));
    }
    
    [Fact]
    public void handleStringInsteadOfYear(){
        var calculator = new LeapYearCalculator();

        using var reader = new StringReader("mads\n");
        Console.SetIn(reader);

        using var writer = new StringWriter();
        Console.SetOut(writer);

        calculator.takeUserInput();

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().BeEquivalentTo("Write a year: You have to write a number!");
    }
}