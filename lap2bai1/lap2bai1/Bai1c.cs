using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap2bai1
{
    internal class UserDatalab
    {
        public int id;
        public string username;
        public int level;

        public UserDatalab()
        {
            id = 0;
            level = 0;
            username = "null";
        }
         public UserDatalab(int id, string username, int level)
        {
            this.id = id;
            this.username = username;
            this.level = level;
        }
        public void XuatThongTin()
        {
            Console.WriteLine("Id:" + id);
            Console.WriteLine("Level:" + level);
            Console.WriteLine("Username:" + username);
        }
    }
    public class Bai1c
    {
        public static void XuatThongTin(string attributeName,dynamic attribute)
        {
            Console.WriteLine(attributeName + ":" + attribute);
        }
    }
  
    
}
