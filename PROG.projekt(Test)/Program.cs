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
            string riadok;
            int cisloriadku = 0;

                while (cisloriadku < 5 && (riadok = subor.ReadLine()) != null)
                {
                    Console.WriteLine(riadok);
                    cisloriadku++;
                }
                subor.Close();
        }
    }
}