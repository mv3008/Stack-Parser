using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Parser.Helpers
{
    class InfixtoPostfix
    {
        private string inputstring;
        private string output = string.Empty;
        private StackX mystack;
        private char prev;
        public InfixtoPostfix(string s)
        {

            mystack = new StackX(s.Length);
            inputstring = s;

        }


        public string ConverttoPostfix()
        {
            Console.WriteLine("******************************************************");
            Console.WriteLine("************************PostFix Notation Conversion View************************************");

            foreach (var ch in inputstring)
            {
                switch (ch)
                {
                    case '+':
                    case '-':
                        itsOper(ch, 1);
                        break;
                    case '*':
                    case '/':
                        itsOper(ch, 2);
                        break;

                    case '(':
                        mystack.push(ch);
                        break;

                    case ')':
                        getleftparen(ch);
                        break;

                    default:
                        output = output + ch;
                        break;
                }

            }

            while (!mystack.IsEmpty())
            {
                output += mystack.pop();

            }

            Console.WriteLine("********************** Final PostFix Notation ****************************");
            Console.WriteLine("");
            Console.WriteLine(output);
            return output;

        }

        public void itsOper(char c, int predc)
        {
            while (!mystack.IsEmpty())
            {
                char Topoper = mystack.pop();
                if (Topoper == '(')
                {
                    mystack.push(Topoper);
                    break;
                }
                else
                {
                    int predc2;
                    //Set precedence
                    if (Topoper == '+' || Topoper == '-')
                        predc2 = 1;
                    else
                        predc2 = 2;

                    if (predc2 < predc)
                    {
                        mystack.push(Topoper);
                        break;
                    }
                    else
                    {
                        output += Topoper;
                    }
                }
            }
            mystack.push(c);

            //display cotents
            Console.WriteLine("Operands :" + output);
            Console.WriteLine("Stack View :"); mystack.displayStack();
        }

        public void getleftparen(char c)
        {
            while (!mystack.IsEmpty())
            {
                char charX = mystack.pop();
                if (charX == '(')
                {
                    break;
                }
                else
                {
                    output += charX;
                }
            }
        }

    }
}
