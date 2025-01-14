﻿// C# Collections
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pass_By_Value_Example
{
    class Pass_By_Value
    {
        public void swap(int x, int y)
        {
            int temp;

            temp = x; /* save the value of x */
            x = y;    /* put y into x */
            y = temp; /* put temp into y */
            Console.WriteLine("In swap function, value of a : {0}", x);
            Console.WriteLine("In swap function, value of b : {0}", y);
        }
        static void Main(string[] args)
        {
            Pass_By_Value n = new Pass_By_Value();

            /* local variable definition */
            int a = 100;
            int b = 200;

            Console.WriteLine("Before swap, value of a : {0}", a);
            Console.WriteLine("Before swap, value of b : {0}", b);

            /* calling a function to swap the values */
            n.swap(a, b);

            Console.WriteLine("After swap, value of a : {0}", a);
            Console.WriteLine("After swap, value of b : {0}", b);

            Console.ReadLine();
        }
    }
}