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

        bool isLeapYearFalse = calculator.IsLeapYear(1300);

        isLeapYearFalse.Should().Be(false);
    }

    [Fact]
    public void isLeapYearWhenDivisibleByFourHundred(){
        var calculator = new LeapYearCalculator();

        bool isLeapYearCorrect = calculator.IsLeapYear(1600);

        isLeapYearCorrect.Should().Be(true);
    }
}