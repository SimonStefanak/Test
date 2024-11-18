using System;
using System.IO;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader subor = new StreamReader("C:\\Users\\kille\\Desktop\\SW-test.txt");

            while (true)
            {
                string test = subor.ReadLine();

                if (test == null)
                    break;

                Console.WriteLine(test);
            }
            subor.Close();
        }
    }
}