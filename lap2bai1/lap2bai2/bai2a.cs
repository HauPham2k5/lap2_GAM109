using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class Bai2a
{
    public static void bai2a()
    {
        // Tạo một kiểu ẩn danh đại diện cho thông tin người dùng
        var userInfp = new
        {
            id = "2024",
            name = "faker",
            isplaying = false,  // Biến cho biết người dùng có đang chơi không
            bag = new  // Kiểu ẩn danh lồng vào đại diện cho túi của người dùng
            {
                skins = 0,// Số lượng skin trong túi
                cups = 20,// Số lượng cốc trong túi
            }
        };
        // In thông tin người dùng ra màn hình
        Console.WriteLine("id:" + userInfp.id);
        Console.WriteLine("name:" + userInfp.name);
        Console.WriteLine("isplaying:" + userInfp.isplaying);
        Console.WriteLine("bag skins:" + userInfp.bag.skins);
        Console.WriteLine("bag cups:" + userInfp.bag.cups);

    }

}

