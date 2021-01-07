using System;

class Overflow{

    static void Main(string[] args){

	byte number = 255;
	number += 1;
	Console.WriteLine(number); // Overflow occurs as the output is 0
	}
}
