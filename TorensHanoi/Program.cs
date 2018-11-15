﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace TorensHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kies een grote");
            int size = Int32.Parse(Console.ReadLine());
            int i = 0; 

            Stack diskStack  = new Stack();
            Stack diskStack1 = new Stack();
            Stack diskStack2 = new Stack();
            
            for (int j = size;0 < j;j--)
            {
                diskStack.Push(j);
            }

            bool play = true;

            while(play)
            {
                Console.WriteLine("Kies stapel 1, 2 of 3 of stop spel -1");
                int swap1 = Int32.Parse(Console.ReadLine());

                Console.WriteLine("kies een andere stapel om te vullen");
                int swap2 = Int32.Parse(Console.ReadLine());

                if (swap1 == 1 && swap2 == 2)
                {
                    swapStack(diskStack1,diskStack);
                }
                else if(swap1 == 2 && swap2 == 1)
                {
                    swapStack(diskStack, diskStack2);
                }
                else
                {
                    Console.WriteLine("11111");
                }

               
                if (i == -1)
                {
                    play = false;
                }           
            }

            Console.WriteLine("Spel klaar");
            Console.Read();
        }

        public static void swapStack(Stack stack,Stack stack1)
        {
            stack.Push(stack1.Pop());
        }
    }
}
