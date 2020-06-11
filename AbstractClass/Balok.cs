using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Balok : BangunRuang
    {
        public int p, l, t;
        public override void Volume()
        {
            Console.Write("Masukan nilai panjang :  ");
            p = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan nilai lebar :  ");
            l = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukan nilai tinggi :  ");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volume Balok : " + (p * l * t));
        }
    }
}
