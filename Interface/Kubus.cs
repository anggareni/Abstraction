using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Interface
{
    public class Kubus : IBangunRuang
    {
        public int s;
        public void Volume()
        {
            Console.Write("Masukan nilai sisi :  ");
            s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Volume Kubus : " + (s * s * s));
        }
    }
}
