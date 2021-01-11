using System;

class Logical{

    static void Main(string[] args){

	int firstNumber, secNumber, thirdNumber = 78234;
	firstNumber = -32651;
	secNumber = 739913;

	Console.WriteLine(firstNumber < secNumber && thirdNumber > (secNumber *= 2) );
	Console.WriteLine(thirdNumber == firstNumber || secNumber != firstNumber);
	Console.WriteLine(!(secNumber <= thirdNumber && firstNumber > thirdNumber));

    }

}
