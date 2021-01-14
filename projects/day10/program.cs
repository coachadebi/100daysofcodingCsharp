using System;

class Program{

    static void Main(string[] args){

	Introduction user1 = new Introduction();

	Console.WriteLine("Please Provide Your Information Below For Registration");
        Console.Write("First Name: ");
        user1.firstName = Console.ReadLine();
	Console.Write("Last Name: ");
	user1.lastName = Console.ReadLine();
	Console.Write("Country: ");
	user1.country = Console.ReadLine();
	Console.Write("Age: ");
	user1.age = Convert.ToInt32(Console.ReadLine());

	user1.Intro();

    }

}
