using System;

class UserInput{

    static void Main(string[] args){

	string name, country, gender;
	Console.WriteLine("Please Enter Your NAME, COUNTRY and GENDER below");

	Console.Write("Name: ");
	name = Console.ReadLine();

	Console.Write("Country: ");
	country = Console.ReadLine();

	Console.Write("Gender: ");
	gender = Console.ReadLine();

	Console.WriteLine("Hello " + name + ", We Are Glad To Have A " + gender + " Partner From " + country + ".");

    }
}
