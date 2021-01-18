using System;

public class StaticMethod{

    private static string name, gender;


    public static void GetInformation(){
	Console.WriteLine("Please Provide Your Name And Gender Below");
	Console.Write("Name: ");
	name = Console.ReadLine();
	Console.Write("Gender: ");
	gender = Console.ReadLine();

    }


    public static void Introduction(){
	Console.WriteLine($"Welcome {name}, we are glad to have a {gender} gender");

    }

}
