using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.AbstractClass
{
    public class Kubus : BangunRuang
    {
        public int s;

        public override void Volume()
        {
            Console.Write("Masukan nilai sisi :  ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volume Kubus : " + (s * s * s));
        }

    }
}
