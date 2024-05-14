using lap2bai1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Program
{
   public static void Main(string[] args)
    {
        Console.WriteLine("bai 1a:");
        Bai1a.start();
        Console.WriteLine();
        Console.WriteLine("bai 1b:");
        Bai1b.bai1b();

        Console.WriteLine("bai 1c:");
        var user = new UserDatalab(1,  "1st player" ,1);
        Bai1c.XuatThongTin("Level", user.level);
        Bai1c.XuatThongTin("Name", user.username);

        Console.ReadLine();
    }
    
}
