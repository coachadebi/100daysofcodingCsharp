using System;

class Program{

    static void Main(string[] args){

	StaticMethod.GetInformation();
	StaticMethod.Introduction();

	Cakus.Mathematics();

	var result = Cakus.Add();
	Console.WriteLine($"The Total Is: {result}");
    }
}
	
