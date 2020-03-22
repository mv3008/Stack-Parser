using Stack_Parser.Helpers;
using System;

namespace Stack_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your Expression: ");

            string input = Console.ReadLine();
            InfixtoPostfix ifpf = new InfixtoPostfix(input);
            string Output = ifpf.ConverttoPostfix();

            ParsePostfix ppf = new ParsePostfix(Output);
            long result = ppf.Evaluate();
            Console.WriteLine("********************** Final Result ****************************");
            Console.WriteLine("");
            Console.WriteLine(result);

        }
    }
}
