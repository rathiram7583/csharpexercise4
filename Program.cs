using System;

namespace Csharpexercise4
{
    class Program
    {
        static void Main(string[] args)
        {
           /* Console.WriteLine("Enter Your Name");
            string name=Console.ReadLine();
            Console.WriteLine(":)"+name+":(");*/
             string input=GetInput();
            input=AddSmileyToEnd(input);
            input=AddSmileyToBeginning(input);
             WriteName(input);
        }
        static string GetInput()
        {
            Console.WriteLine("Please Input Some text");
            return Console.ReadLine();

        }
        static string AddSmileyToEnd( string input)
        {
              input=input+":)";
              return input;

        }
        static string AddSmileyToBeginning(string input)
        {
              input=":("+input;
             return input;
             
        }
        static void WriteName(string input)
        {
            Console.WriteLine(input);
        }
    }
}
