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
            string riadok;
            string riadok1 = File.ReadLines("C:\\Users\\kille\\Desktop\\SW-test.txt").ElementAt(6 - 1);
            string riadok2 = File.ReadLines("C:\\Users\\kille\\Desktop\\SW-test.txt").ElementAt(12 - 1);
            string riadok3 = File.ReadLines("C:\\Users\\kille\\Desktop\\SW-test.txt").ElementAt(18 - 1);



            while (cisloriadku < 5 && (riadok = subor.ReadLine()) != null)
            {
                Console.WriteLine(riadok);
                cisloriadku++;
            }
            
            Console.WriteLine("zadaj svoju odpoved:");
            string odpoved = Console.ReadLine();
            
            while(true)
            {
                if ((riadok = subor.ReadLine()) != null)
                {
                    cisloriadku++;
                }

                if (odpoved == riadok1)
                {
                    while (cisloriadku < 11 && (riadok = subor.ReadLine()) != null)
                    {
                        Console.WriteLine(riadok);
                        cisloriadku++;
                    }
                    break;
                }
                else
                    Console.WriteLine("nespravna odpoved, zadaj odpoved znova ");
                    odpoved = Console.ReadLine();
            }
            
            Console.WriteLine("zadaj svoju odpoved:");
            string odpoved2 = Console.ReadLine();

            while (true)
            {
                if ((riadok = subor.ReadLine()) != null)
                {
                    cisloriadku++;
                }

                if (odpoved2 == riadok2)
                {
                    while (cisloriadku < 17 && (riadok = subor.ReadLine()) != null)
                    {
                        Console.WriteLine(riadok);
                        cisloriadku++;
                    }
                    break;
                }
                else
                    Console.WriteLine("nespravna odpoved, zadaj odpoved znova ");
                odpoved = Console.ReadLine();
            }

            Console.WriteLine("zadaj svoju odpoved:");
            string odpoved3 = Console.ReadLine();

            while (true)
            {
                if ((riadok = subor.ReadLine()) != null)
                {
                    cisloriadku++;
                }

                if (odpoved3 == riadok3)
                {
                    Console.WriteLine("uspesne si zvladol test. huraaaaaaaa");
                    break;
                }
                else
                    Console.WriteLine("nespravna odpoved, zadaj odpoved znova ");
                odpoved = Console.ReadLine();
            }

            subor.Close();
        }
    }
}