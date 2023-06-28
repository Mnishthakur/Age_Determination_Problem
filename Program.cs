namespace Age_Determination_Problem
{
    public class InvalidAgeException : Exception
{
    public InvalidAgeException() : base("Invalid age entered.")
    {
    }
}

public class AgeCategorizer
{
    public static string CategorizeAge(int age)
    {
        if (age >= 1 && age <= 14)
            return "Children";
        else if (age >= 15 && age <= 24)
            return "Youth";
        else if (age >= 25 && age <= 64)
            return "Adults";
        else if (age >= 65)
            return "Seniors";
        else
            throw new InvalidAgeException();
    }

    public static void Main()
    {
        Console.WriteLine("Enter age:");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            throw new InvalidAgeException("Age cannot be null or empty.");
        }

        if (!int.TryParse(input, out int age))
        {
            throw new InvalidAgeException();
        }

        try
        {
            string category = CategorizeAge(age);
            Console.WriteLine("Person's category: " + category);
        }
        catch (InvalidAgeException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}

}
