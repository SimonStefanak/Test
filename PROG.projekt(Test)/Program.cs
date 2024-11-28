using System;
using System.IO;
using System.Reflection.PortableExecutable;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader subor = new StreamReader("C:\\Users\\kille\\Desktop\\SW-test.txt");
            int cisloriadku = 0;
            int PocetNespravnychOdpovedi = 0;
            string riadok;
            string riadok1 = File.ReadLines("C:\\Users\\kille\\Desktop\\SW-test.txt").ElementAt(6 - 1);
            string riadok2 = File.ReadLines("C:\\Users\\kille\\Desktop\\SW-test.txt").ElementAt(12 - 1);
            string riadok3 = File.ReadLines("C:\\Users\\kille\\Desktop\\SW-test.txt").ElementAt(18 - 1);

            Console.WriteLine("VITAJ V TOMTO TESTE.");
            Console.WriteLine("Pre začiatok stlač ENTER.");
            Console.WriteLine("=======================================");
            Console.ReadKey();


            while (cisloriadku < 5 && (riadok = subor.ReadLine()) != null)
            {
                Console.WriteLine(riadok);
                cisloriadku++;
            }
            
            Console.WriteLine("Zadaj svoju odpoveď:");
            string odpoved = Console.ReadLine();
            
            while(true)
            {
                if (odpoved == riadok1)
                {
                    Console.WriteLine("---------------------------------------");
                    if ((riadok = subor.ReadLine()) != null)
                    {
                        cisloriadku++;
                    }
                    while (cisloriadku < 11 && (riadok = subor.ReadLine()) != null)
                    {
                        Console.WriteLine(riadok);
                        cisloriadku++;
                    }
                    break;
                }
                else
                {
                    PocetNespravnychOdpovedi++;
                    Console.WriteLine("Nesprávna odpoveď, zadaj odpoveď znova!");
                    odpoved = Console.ReadLine();
                }
            }

            Console.WriteLine("Zadaj svoju odpoveď:");
            string odpoved2 = Console.ReadLine();

            while (true)
            {
                if (odpoved2 == riadok2)
                {
                    Console.WriteLine("---------------------------------------");
                    if ((riadok = subor.ReadLine()) != null)
                    {
                        cisloriadku++;
                    }
                    while (cisloriadku < 17 && (riadok = subor.ReadLine()) != null)
                    {
                        Console.WriteLine(riadok);
                        cisloriadku++;
                    }
                    break;
                }
                else
                {
                    PocetNespravnychOdpovedi++;
                    Console.WriteLine("Nesprávna odpoveď, zadaj odpoveď znova!");
                    odpoved2 = Console.ReadLine();
                }
            }

            Console.WriteLine("Zadaj svoju odpoveď:");
            string odpoved3 = Console.ReadLine();

            while (true)
            {
                if (odpoved3 == riadok3)
                { 
                    Console.WriteLine("Úspešne si zvládol test. Huraaaaaa.");
                    Console.WriteLine("Mal si " + PocetNespravnychOdpovedi + " nesprávnych odpovedí");
                    Console.WriteLine("=======================================");
                    break;
                }
                else
                {
                    PocetNespravnychOdpovedi++;
                    Console.WriteLine("Nesprávna odpoveď, zadaj odpoveď znova!");
                    odpoved3 = Console.ReadLine();
                }
            }
        }
    }
}