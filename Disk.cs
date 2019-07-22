using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Disk : IPrintable, IComparable<Disk>
    {
        public int Size { get; private set; }
        private int Height { get; set; }

        public Disk(int size, int height)
        {
            Size = size;
            Height = height;
        }

        public int CompareTo(Disk other)
        {
            if (other == null) return 1;

            return Size.CompareTo(other.Size);
        }

        public void Print()
        {
            int limit = (Size * 2) - 1;

            for (int i = Height - Size; i > 0; i--)
            {
                Console.Write(" ");
            }

            for (int i = 0; i < limit; i++)
            {
                Console.Write("X");
            }

            Console.Write("\n");
        }
    }

}
