using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorensHanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kies een grote");
            int size = Int32.Parse(Console.ReadLine());
            int i = 0; 

            DiskCollection game = new DiskCollection(size);
            Disk[] toren2 = new Disk[size];
            Disk[] toren3 = new Disk[size];
            

            bool play = true;

            while(play)
            {
                Console.WriteLine("Kies stapel 1, 2 of 3");
                
                int choice = Int32.Parse(Console.ReadLine());
                i = Int32.Parse(Console.ReadLine());
                if (i == 1)
                {
                    play = false;
                }
            }

            Console.Read();
        }
    }
}
