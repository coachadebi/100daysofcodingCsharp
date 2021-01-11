using System;

class AssignOperators{

    static void Main(string[] args){

	int intNumber = 842;
	float floatNumber = 87.30f;
	byte byteNumber = 126;
	double doubleNumber = 921744.87532;
	short shortNumber = -4022;
	
	intNumber += 5;
	Console.WriteLine(intNumber);

	floatNumber *= 7;
	Console.WriteLine(floatNumber);

	byteNumber %= 3;
	Console.WriteLine(byteNumber);

	doubleNumber /= 20;
	Console.WriteLine(doubleNumber);

	shortNumber -= -5052;
	Console.WriteLine(shortNumber);

    }

}
