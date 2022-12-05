using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    class Stack
    {
        private string[] aan;
        private int top;
        private int max;
        public Stack(int size)
        {
            aan = new string[size];
            top = -1;
            max = size;
        }
        static void Main(string[] args)
        {
        }
    }
}
