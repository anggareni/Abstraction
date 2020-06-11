using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using Abstraction.AbstractClass;    // Penggunaan Abstract Class
using Abstraction.Interface;        // Penggunaan Interface

namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BANGUN RUANG");
            Console.WriteLine();

            //BangunDatar bangundatar;  //Digunakan apabila menggunakan Abstract Class
            IBangunRuang bangunruang;   //Digunakan apabila menggunakan Interface

            Console.WriteLine("1. Balok");
            bangunruang = new Balok();
            bangunruang.Volume();

            Console.WriteLine();
            Console.WriteLine("2. Kubus");
            bangunruang = new Kubus();
            bangunruang.Volume();

            Console.WriteLine();
            Console.WriteLine("3. PrismaSegitiga");
            bangunruang = new PrismaSegitiga();
            bangunruang.Volume();

            Console.ReadKey(true);
        }
    }
}
