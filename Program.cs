using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Podaj wysokość wieży...");
                string line = Console.ReadLine();
                int height;
                if (!int.TryParse(line, out height))
                {
                    Console.WriteLine("Podano niepoprawną wartość!");
                    continue;
                }

                Tower<Disk>[] towers = new Tower<Disk>[3];

                for (int i = 0; i < 3; i++) towers[i] = new Tower<Disk>(height);

                for (int i = 0; i < height; i++)
                {
                    towers[0].Push(new Disk(height - i, height));
                }

                Console.Clear();
                for (int i = 0; i < towers.Length; i++)
                {
                    Console.WriteLine("Wieża " + (i+1) + ": \n");
                    towers[i].Print();
                    Console.WriteLine();
                }

                while (true)
                {
                    Console.WriteLine("Wybierz wieżę, z której podniesiesz klocek...");
                    line = Console.ReadLine();
                    int first;
                    if (!int.TryParse(line, out first) || (first != 1 && first != 2 && first != 3))
                    {
                        Console.WriteLine("Podano niepoprawną wartość!");
                        continue;
                    }

                    Console.WriteLine("Wybierz wieżę, do której dołożysz klocek...");
                    line = Console.ReadLine();
                    int second;
                    if (!int.TryParse(line, out second) || (second != 1 && second != 2 && second != 3))
                    {
                        Console.WriteLine("Podano niepoprawną wartość!");
                        continue;
                    }

                    try
                    {
                        towers[second - 1].Push(towers[first - 1].Pop());
                    }
                    catch (EmptyTowerException)
                    {
                        Console.WriteLine("Próba wybrania klocka z pustej wieży!");
                        continue;
                    }
                    catch (LargerOnSmallerElementException)
                    {
                        Console.WriteLine("Próba położenia większego klocka na mniejszy!");
                        continue;
                    }

                    Console.Clear();
                    for (int i = 0; i < towers.Length; i++)
                    {
                        Console.WriteLine("Wieża " + (i+1) + ": \n");
                        towers[i].Print();
                        Console.WriteLine();
                    }

                    if (towers[2].Height == towers[2].CurrentHeight)
                    {
                        Console.WriteLine("Wygrałeś!");
                        break;
                    }
                }

                break;
            }

            Console.ReadKey();
        }
    }
}
