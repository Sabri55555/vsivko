﻿using System;

namespace ConsoleApp4
{
     abstract class absClass
    {
        protected int myNumber;

        public abstract int numbers
        {
            get;
            set;
        }
 class absDerived : absClass
 {
            public override int numbers
            {
                get
                {
                    return myNumber;
                }
                set
                {
                    myNumber = value;
                }
            }
  }
class Example
{
            public static void Main()
            {
                absDerived d = new absDerived();
                d.numbers = 5;
                Console.WriteLine(d.numbers);
            }
}       
            
        
    

