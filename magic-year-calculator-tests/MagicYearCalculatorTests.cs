using System.Runtime.InteropServices;
using magic_year_calculator;

namespace magic_year_calculator_tests;

public class MagicYearCalculatorTests
{
    [Theory]
    [InlineData("John", "Doe", "John Doe")]
    [InlineData("Samantha", "Brown", "Samantha Brown")]
    
    public void CreateFullName_ReturnsFullName(string firstName, string surname, string expected)
    {
        // ARRANGE
        var magicYearCalculator = new MagicYearCalculator();

        // ACT
        var actual = magicYearCalculator.CreateFullName(firstName, surname);
        
        // ASSERT
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("John", true)]
    [InlineData("Sarah1", false)]
    [InlineData("4To", false)]
    [InlineData(".Sally", false)]
    [InlineData("-Bob", false)]
    [InlineData("Max-", false)]
    [InlineData(" ", false)]
    [InlineData("", false)]
    [InlineData("Steph!", false)]
    [InlineData("Robert--Brown", false)]
    [InlineData("van der Waal", true)]
    [InlineData("B.K. Mary-Jane", true)]
    
    public void IsValidName_ReturnsAppropriateValidity(string name, bool expected)
    {
        // ARRANGE
        var magicYearCalculator = new MagicYearCalculator();
        
        // ACT
        var actual = magicYearCalculator.IsValidName(name);
        
        // ASSET
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData(2000, 2065)]
    [InlineData(2100, 2165)]
    public void CalculateMagicYear_ReturnsCorrectMagicYear(int workStartYear, int expected)
    {
        // ARRANGE
        var magicYearCalculator = new MagicYearCalculator();
        
        // ACT
        var actual = magicYearCalculator.CalculateMagicYear(workStartYear);
        
        // ASSERT
        Assert.Equal(expected, actual);
    }
}