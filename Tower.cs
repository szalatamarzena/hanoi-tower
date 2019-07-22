using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hanoi
{
    class Tower<T> where T : IPrintable, IComparable<T>
    {
        Stack<T> elements;

        public int Height { get; set; }

        public Tower(int height)
        {
            Height = height;
            elements = new Stack<T>();
        }

        public int CurrentHeight { get { return elements.Count; } }

        public void Push(T elem)
        {
            if (elements.Count > 0)
            {
                T stackTop = elements.Peek();

                int comp = stackTop.CompareTo(elem);

                if (comp == -1)
                {
                    throw new LargerOnSmallerElementException();
                }
                else
                {
                    elements.Push(elem);
                }
            }
            else
            {
                elements.Push(elem);
            }
        }

        public T Pop()
        {
            if (elements.Count > 0)
            {
                return elements.Pop();
            }
            else
            {
                throw new EmptyTowerException();
            }
        }

        public void Print()
        {
            foreach (T element in elements)
            {
                element.Print();
            }
        }
    }
}
