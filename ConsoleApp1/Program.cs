
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Home_Work_1;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input Your Name");
        var name = Console.ReadLine();

        Console.WriteLine($"\n Привет, {name}!");

        for (int i = 0; i < name.Length; i += 2)

        {
            Console.Write(name[i] + " ");
        }


        Console.WriteLine("!");


        Console.Write($"Enter any key.....");
        Console.ReadKey(true);
    }

}
