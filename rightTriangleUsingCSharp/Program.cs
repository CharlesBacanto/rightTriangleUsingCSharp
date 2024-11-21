class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter a character: ");
        char character = Convert.ToChar(Console.ReadLine());
        Console.Write("Please enter the max amount: ");
        int maxValue = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= maxValue; i++)
        {
           Console.WriteLine(clone(character, i));
        }
    }
    

    static string clone(char c, int value)
    {
        string cloned ="";
        for(int i = 0; i < value; i++)
        {
            cloned += c;
        }
        return cloned;
    }
}