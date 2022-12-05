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
        public void Push()
        {
            if (top == max - 1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                Console.WriteLine("Masukan Element: ");
                aan[++top] = Console.ReadLine();
            }
        }
        public void Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                Console.WriteLine("Poped Element is : " + aan[top]);
                top--;
                return;
            }
        }
        public void display()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is Empty");
                return;
            }
            else
            {
                for (int i = 0; i < aan.Length; i++)
                {
                    Console.WriteLine(aan[i]);
                }
            }
        }
        static void Main(string[] args)
        {
            Stack s = new Stack(35);
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("\n ***Stack Menu***\n");
                Console.WriteLine("1. Push");
                Console.WriteLine("2. Pop");
                Console.WriteLine("3. Display");
                Console.WriteLine("4. Exit");
                Console.Write("\n Enter your choice : ");
                string input = Console.ReadLine();
                char ch = Convert.ToChar(input == "" ? "o" : input);

                switch (ch)
                {
                    
                }
            }
        }
    }
}
