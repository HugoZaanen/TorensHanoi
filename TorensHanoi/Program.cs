using System;
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
            Console.WriteLine("Kies een grote boven de drie");
            int size = Int32.Parse(Console.ReadLine());
            int i = 0;

            while(size < 3)
            {
                Console.WriteLine("size niet boven de drie");
                size = Int32.Parse(Console.ReadLine());
            }

            Stack diskStack  = new Stack();
            Stack diskStack1 = new Stack();
            Stack diskStack2 = new Stack();
            
            for (int j = size;0 < j;j--)
            {
                diskStack.Push(j);
            }

            bool play = true;

            while (play)
            {
                Console.WriteLine("Kies stapel 1, 2 of 3 of stop spel -1");
                int swap1 = Int32.Parse(Console.ReadLine());
                int swap2 = 0;

                while (swap1 > 4 || swap1 < 1 && swap1 != -1)
                {
                    swap1 = Int32.Parse(Console.ReadLine());
                }

                if (swap1 != -1)
                {
                    Console.WriteLine("kies een andere stapel om te vullen");
                    swap2 = Int32.Parse(Console.ReadLine());
                }

                while (swap2 == swap1 )
                {
                    swap2 = Int32.Parse(Console.ReadLine());
                }

                Console.WriteLine("\n");

                if (swap1 == 1 && swap2 == 2)
                {                   
                    swapStack(diskStack1, diskStack);
                }
                else if(swap1 == 2 && swap2 == 1)
                {
                    swapStack(diskStack, diskStack1);
                }
                else if(swap1 == 1 && swap2 == 3)
                {                    
                    swapStack(diskStack2, diskStack);
                }
                else if(swap1 == 3 && swap2 == 1)
                {
                    swapStack(diskStack, diskStack2);
                }
                else if(swap1 == 2 && swap2 == 3)
                {
                    swapStack(diskStack2, diskStack1);
                }
                else if (swap1 == 3 && swap2 == 2)
                {
                    swapStack(diskStack1, diskStack2);
                }

                try
                {
                    Console.WriteLine("stapel 1: " + diskStack.Peek() );
                }
                catch (Exception e)
                {
                    Console.WriteLine("Nothing in stack");
                }
                try
                {
                    Console.WriteLine("stapel 2: " + diskStack1.Peek());
                }
                catch (Exception e)
                {
                    Console.WriteLine("nothing in stack");
                }
                try
                {
                    Console.WriteLine("stapel 3: " + diskStack2.Peek());
                }
                catch (Exception e)
                {
                    Console.WriteLine("nothing in stack");
                }
                Console.WriteLine("\n");

                if (swap1 == -1)
                {
                    play = false;
                }           
            }

            Console.WriteLine("Spel klaar");
            Console.Read();
        }

        public static void swapStack(Stack stack,Stack stack1)
        {
            int i = 0;
                
            try
            {
                stack.Peek();
            }
            catch (Exception e)
            {
                try
                {
                    stack.Push(stack1.Pop());
                }
                catch(Exception x)
                {
                    Console.WriteLine("Allebei de stapels leeg");
                }
                i++;
            }

            if (i == 0)
            {
                if ((int)stack1.Peek() < (int)stack.Peek())
                {
                    stack.Push(stack1.Pop());
                }
                else
                {
                    Console.WriteLine("disk kan niet worden geplaats\n");
                }
            }
        }
    }
}
