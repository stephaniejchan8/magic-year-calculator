using System.Text.RegularExpressions;

namespace magic_year_calculator;

public class MagicYearCalculator
{
    public string CreateFullName(string firstName, string surname)
    {
        return $"{firstName} {surname}";
    }

    public int CalculateMagicYear(int workStartYear)
    {
        return workStartYear + 65;
    }

    public bool IsValidName(string name)
    {
        // if (String.IsNullOrWhiteSpace(name))
        // {
        //     return false;
        // }
        var regex = new Regex("^[a-zA-Z][a-zA-Z-. ]+[a-zA-Z.]$");
        return regex.IsMatch(name);
        // return !name.Any(char.IsDigit);
    }
}