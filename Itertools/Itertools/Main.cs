using System;
using System.IO;

namespace Itertools
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(File.ReadAllText("../README.md"));
        }
    }
}
