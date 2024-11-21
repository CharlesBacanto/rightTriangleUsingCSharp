class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a character: "); // Prompt the User to enter a character
        char character = Convert.ToChar(Console.ReadLine()); // Fetch character
        Console.Write("Please enter the max amount: "); // Prompt the User to enter the max amount 
        int maxValue = Convert.ToInt32(Console.ReadLine()); // Fetch amount

        for (int i = 0; i <= maxValue; i++) // For loop to generate each line
        {
           Console.WriteLine(clone(character, i));
        }
    }
    

    static string clone(char c, int value) // Method/Function for generating lines
    {
        string cloned ="";
        for(int i = 0; i < value; i++)
        {
            cloned += c;
        }
        return cloned;
    }
}