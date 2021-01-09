using System;

class ExplicitType{

    static void Main(string[] args){

        float number = 562f;
        int otherNumber = (int)number;

        Console.WriteLine($"intValue: {number} , floatValue: {otherNumber}");
    }
}
