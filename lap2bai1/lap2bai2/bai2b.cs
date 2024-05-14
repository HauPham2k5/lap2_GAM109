using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    internal class Bai2b
    {
        public  Bai2b() 
        {
            int y = 10;
            Action<int> Anonymousmethod = delegate (int x)
            {
                int sum = x + y;
                int sub = x - y;
                Console.WriteLine("sum:" + sum);
                Console.WriteLine("sub:" + sub);
            };
            Anonymousmethod(5);
        }
    }

