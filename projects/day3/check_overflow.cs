using System;

class CheckOverflow{

    static void Main(string[] args){

	checked{
            byte number = 255;
            number += 1;
            Console.WriteLine(number);
            /* Overflow will not occurs as the output
	    throws an exception*/
	    }
        }
}
