using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TorensHanoi
{
    class DiskCollection
    {
        public Disk[] disks { get; set; }

        public DiskCollection(int size)
        {
            InitializeCollection(size);
        }

        public Disk[] InitializeCollection(int size)
        {
            disks = new Disk[size];

            for(int i = 0;i < size;i++)
            {
                disks[i] = initializeDisk(i);
            }
            return disks;
        }

        public Disk initializeDisk(int size)
        {
            Disk disk = new Disk(size);

            return disk;
        }

        public void printSize()
        {
            Console.WriteLine(disks.Length);
        }
    }
}
