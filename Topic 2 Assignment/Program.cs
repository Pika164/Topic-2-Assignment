namespace Topic_2_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Linkin Krysa
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("The year I was born minus my age is:" + (2008 - 16));
            Console.WriteLine();
            Console.WriteLine("The average of 14 + 15 + 16 is:" + ((14 + 15 + 16) / 3));
            Console.WriteLine();
            Console.WriteLine("The average of 14 + 15 + 16 + 17 :" + ((14.0 + 15.0 + 16.0 + 17.0) / 4));
            Console.WriteLine();
            Console.WriteLine("The Area of a circle when it has a radius of 3cm is :" + (3.1415926 * (3 * 3)));
            Console.WriteLine();
            Console.WriteLine("The reason why C# knows when to add when you use + is if you have brackets around numbers. For example, if you want 10 * 10 plus some text either to the side and you accidentally have brackets around the numbers or you didn't put enough brackets around the line of code, it wont work. This happens because it is very very picky about what a program's code will take and what it wont.");
            Console.ReadLine();
        }
    }
}
