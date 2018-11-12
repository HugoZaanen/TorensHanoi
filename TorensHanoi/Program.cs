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
            int size = Int32.Parse(Console.ReadLine());

            DiskCollection game = new DiskCollection(size);
            Disk[] toren2 = new Disk[size];
            Disk[] toren3 = new Disk[size];

            bool play = true;

            while(play)
            {

            }
        }
    }
}
