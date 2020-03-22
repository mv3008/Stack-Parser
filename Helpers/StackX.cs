using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Parser.Helpers
{
    class StackX
    {
        //impelement push, pop, peek methods
        private int maxsize;
        private char[] stck;
        private int topptr;

        public StackX(int s)
        {
            maxsize = s;
            stck = new char[maxsize];
            topptr = -1;  //becoz addition will be 2 step process 1. increment topptr to empty space and then  2. fill the space..

        }

        public void push(char j)
        {
            stck[++topptr] = j;
        }

        public char pop()
        {
            return stck[topptr--];
        }

        public char peek()
        {
            return stck[topptr];
        }

        public Boolean IsEmpty()
        {
            return (topptr == -1);
        }

        public Boolean IsFull()
        {
            return (topptr == maxsize - 1);
        }

        public int size()  //stack may not be full to its max size..
        {
            return topptr + 1;
        }

        public char peekN(int index)
        {
            return stck[index];
        }

        public void displayStack()
        {
            for (int i=0; i<size();i++ )
            {
                Console.WriteLine("| " + peekN((size()-1)-i) + " |");
            }

            Console.WriteLine("------");
        }
    }
}
