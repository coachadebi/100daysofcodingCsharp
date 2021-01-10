using System;

class Comparison{

    static void Main(string[] args){

	var firstName = "John";
	var lastName = "Johnson";

	Console.WriteLine(firstName == lastName);
	Console.WriteLine(firstName != lastName);

	int a;
	a = 7;
	int b = ++a;
	int k = b++;

	Console.WriteLine($"a = b: {a == b}");
	Console.WriteLine($"k >= a: { k == a}");
	Console.WriteLine($"b > a: {b > a}");
	Console.WriteLine($"k >= b: {k >= b}");
	Console.WriteLine($"b != k: {b != k}");

    }

}
