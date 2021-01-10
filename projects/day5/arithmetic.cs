using System;

class Arithmetic{

    static void Main(string[] args){

	var a = 5;
	var b = a++;

	Console.WriteLine($"a becomes: {a} after using a++");
	Console.WriteLine($"b becomes: {b} after it has been assigned with a++");

	var c = 10;
	var d = ++c;

	Console.WriteLine($"After assigning d with ++c, both have same value, c = {c} , d = {d}");

	double currentPrice = 546.767;
	int quantity = 6;
	double totalPayment = currentPrice * quantity;

	Console.WriteLine($"Your Total Amount To Be Paid Is {totalPayment}");
	
	Console.WriteLine(totalPayment / a * --quantity + d % b);

    }

}
