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
                }
                else
                    Console.WriteLine("nespravna odpoved, zadaj odpoved znova ");
                    odpoved = Console.ReadLine();
            }
            



            subor.Close();

        }
    }
}