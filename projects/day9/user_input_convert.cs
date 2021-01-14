using System;

class UserInputConvert{

    static void Main(string[] args){

	double amount, total;
	int quantity;

	Console.WriteLine("Place Your Bid");
	Console.Write("Enter Bid Amount: ");
	amount = Convert.ToDouble(Console.ReadLine());
	Console.Write("Now Enter Item Quantity: ");
	quantity = Convert.ToInt32(Console.ReadLine());

	Console.WriteLine($"Bid Amount:${amount} Item Quantity: {quantity}");
	total = amount * quantity;
	Console.WriteLine("Total Amount To Be Paid: $" + total);

    }

}
