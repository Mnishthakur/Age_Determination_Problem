namespace Age_Determination_Problem
{
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
            throw new ArgumentNullException("age", "Age cannot be null.");
    }

    public static void Main()
    {
        Console.WriteLine("Enter age:");
        string input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("Age cannot be empty.");
            return;
        }

        if (!int.TryParse(input, out int age))
        {
            Console.WriteLine("Invalid age entered.");
            return;
        }

        try
        {
            string category = CategorizeAge(age);
            Console.WriteLine("Person's category: " + category);
        }
        catch (ArgumentNullException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
}
