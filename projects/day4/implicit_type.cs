using System;

class ImplicitType{

    static void Main(string[] args){

	byte number = 5;
	int otherNumber = number;

	Console.WriteLine($"byteValue: {number} , intValue: {otherNumber}");
    }
} 
