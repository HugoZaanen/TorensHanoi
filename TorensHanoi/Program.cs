﻿using System;
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
            DiskCollection game = new DiskCollection(10);
            game.printSize();
            Console.Read();
        }
    }
}
