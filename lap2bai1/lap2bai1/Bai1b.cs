using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap2bai1
{
    public class Bai1b
    {
        public static void GetDetal(dynamic value)
        {
            Console.WriteLine("value:" + value);
        }
        public static void bai1b()
        {
            GetDetal(10);
            GetDetal("game");
            GetDetal(true);
            GetDetal(9.5);
        }


    }
}
