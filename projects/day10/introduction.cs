using System;

public class Introduction{

    public string firstName, lastName,  country;

    public int age;


    public void Intro(){

	Console.WriteLine("Welcome To The Program");
	Console.WriteLine("Below Are Your Informations Provided By You");
	Console.WriteLine($"FullName: {firstName} {lastName}");
	Console.WriteLine("Country: " + country + " Age: " + age + "year(s).");

    }
}
