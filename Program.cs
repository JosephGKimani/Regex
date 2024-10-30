using System.Text.RegularExpressions;

class Program
{



    static void Main()
    {
        Console.WriteLine("Input a phone number to check whether its is a correct format");
        string input = Console.ReadLine();

        Match match = Regex.Match(input, @"\d{3}-\d{3}-\d{3}");


        if (match != null)
        {

            Console.WriteLine(match);



        }
        Console.WriteLine("Invalid phone number formart");



    }
}