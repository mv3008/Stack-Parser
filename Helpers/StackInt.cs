using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Parser.Helpers
{
    class StackInt
    {
        private int maxsize;
        private long[] stck;
        private int topptr;

        public StackInt(int s)
        {
            maxsize = s;
            stck = new long[maxsize];
            topptr = -1;  //becoz addition will be 2 step process 1. increment topptr to empty space and then  2. fill the space..

        }

        public void push(long j)
        {
            stck[++topptr] = j;
        }

        public long pop()
        {
            return stck[topptr--];
        }

        public long peek()
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

        public long peekN(int index)
        {
            return stck[index];
        }

        public void displayStack()
        {
            for (int i = 0; i < size(); i++)
            {
                Console.WriteLine("| " + peekN((size()-1)-i) + " |");
            }

            Console.WriteLine("------");
        }
    }
}
