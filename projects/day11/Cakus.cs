using System;

public class Cakus{

    private static double firstNumber, secNumber, total;



    public static void Mathematics(){

	Console.WriteLine("Addition Of Two Numbers");
	Console.Write("Enter 1st Number: ");
	firstNumber = Convert.ToDouble(Console.ReadLine());
	Console.Write("Enter 2nd Number: ");
	secNumber = Convert.ToDouble(Console.ReadLine());

    }


    public static double Add(){

	total = firstNumber + secNumber;
	return total;

    }

}
