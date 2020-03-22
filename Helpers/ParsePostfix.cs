using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Text;

namespace Stack_Parser.Helpers
{
    class ParsePostfix
    {
        private StackInt operandstack;
        private string input;

        public ParsePostfix(string s)
        {
            input = s;
            operandstack = new StackInt(input.Length);
           
        }

        public long Evaluate()
        {
            int num1, num2, transientnum;

            foreach(var c in input.ToString())
            {
                if(Char.IsDigit(c))
                {
                    operandstack.push((int)c - '0');
                }
                else 
                {
                    Console.WriteLine("Operator Encountered : " + c);
                    num2 = (int)operandstack.pop();
                    num1 = (int)operandstack.pop();

                    switch (c)
                    {
                        case '+':
                            transientnum = num1 + num2;
                            break;

                        case '-':
                            transientnum = num2 - num1;
                            break;

                        case '*':
                            transientnum = num2 * num1;
                            break;

                        case '/':
                            transientnum = num2 / num1;
                            break;

                        default:
                            transientnum = 0;
                            break;
                            
                    }

                    operandstack.push((int)transientnum);
                }

                //display cotents
                Console.WriteLine("Operands Stack View :"); operandstack.displayStack();
            }

            
            return operandstack.pop();
        }
    }
}
