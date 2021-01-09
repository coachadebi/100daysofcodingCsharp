using System;

class NonCompType{

    static void Main(string[] args){

        string isEmpty = "False";
        bool alsoEmpty = Convert.ToBoolean(isEmpty);
	string evenNumber = "2468";
	int anotherEven = Int32.Parse(evenNumber);
        
	Console.WriteLine($"string: {isEmpty} , bool: {alsoEmpty}");
	Console.WriteLine($"string: {evenNumber} , int: {anotherEven}");

    }
}
