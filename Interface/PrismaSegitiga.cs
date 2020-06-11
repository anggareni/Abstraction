using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class PrismaSegitiga : IBangunRuang
    {
        public int alas, t;
        public void Volume()
        {
            Console.Write("Masukan nilai alas :  ");
            alas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan nilai tinggi :  ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volume Prisma Segitiga : " + (alas * t));
        }
    }
}
