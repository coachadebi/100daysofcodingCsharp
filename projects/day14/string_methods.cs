using System;

class StringMethods{

    static void Main(string[] args){

	string fname = "Sam";
	string lname = "Samson";

	string name = string.Format("{0} {1}", fname, lname);
	Console.WriteLine(name);

	var animals = new string[]{"Cow", "Goat", "Penguin", "Dolphine", "Mosquito"};

	string animes = string.Join(" | ", animals);

	Console.WriteLine(animes);

    }
}
