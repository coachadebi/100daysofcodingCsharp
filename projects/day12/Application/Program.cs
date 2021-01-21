using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
        	string True = "True";
        	bool seeme = Convert.ToBoolean(True);
            bool[] names = new bool[3];
            
            names[2] = seeme;
            Console.WriteLine($"{names[0]}, {names[1]}, {names[2]}");
            
            int[] numbers = new int[]{6,13,87,92,51,3,21,0};
            Console.WriteLine($"{numbers[2] + numbers[5]}, {numbers[3]}, {numbers[0]}");
            
            string[] continents = {"Africa", "Antarctica", "Asia", "Australia", "Europe", "North America", "South America"};
            Console.WriteLine($"{continents[5]}, {continents[2]}, {continents[0]}, {continents[6]}, {continents[3]}, {continents[4]}, {continents[1]}");
            
            var colours = new string[]{"RED", "YELLOW", "GREEN", "BLUE", "BLACK", "WHITE"};
            Console.WriteLine($"{colours[2]}, {colours[4]}, {colours[0]}, {colours[5]}, {colours[1]}. Also: " + colours[4] + " and " + colours[5]);
        }
    }
}
