using System;

class Program{

    static void Main(string[] args){

	byte aByte = 65;
    	short aShort = -2000;
    	int anInt = 587664;
    	long aLong = 2765843;
	float aFloat = 72.81f;
	double aDouble = -87678.878;
	decimal aDecimal = 637828863.80m;
	char aChar = 'B';
	bool aBoolean = true;
	string aString = "C Sharp";
	const int ConstVar = -58221;
	
	var username = "csharp_demo";
	var age = 97;

	Console.WriteLine(aByte);
	Console.WriteLine(aShort);
	Console.WriteLine("{0} {1} {2} {3}", anInt, aFloat, aLong, aDouble);
	Console.WriteLine($"{aDecimal} {aChar} {aBoolean} {aString} {ConstVar}");

	Console.WriteLine($"{float.MinValue} {float.MaxValue}");
	Console.WriteLine("{0} {1}", short.MinValue, short.MaxValue);

	Console.WriteLine(username);
	Console.WriteLine(age);

        }
}
