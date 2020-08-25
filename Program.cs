using System;

//Print numbers starting from 1 to 100. 
//When a number is multiple of three, print “Fizz” instead of a number on the console 
//And if multiple of five then print “Buzz” on the console.
//For numbers which are multiple of three as well five, print “FizzBuzz” on the console.

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 101; i++) //Creating the loop to count to 100 don't ask why it's 101//
            {
                if (i % 3 == 0 && i % 5 == 0)//Stating that if the number counted is a multiple of 3, and if 5 is too! Write FizzBuzz//
                {
                    Console.WriteLine("FizzBuzz");
                }
                    else 
                    if (i % 3 == 0) //This says "Yo i'm just a multiple of 3 write Fizz."//
                {
                    Console.WriteLine("Fizz");
                }
                else 
                if (i % 5 == 0) //This one says "Me me a multiple of 5 only."//
                {
                    Console.WriteLine("Buzz");
                }
                else    //This bit says if all of the above doesn't jive, just write the number.//
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
