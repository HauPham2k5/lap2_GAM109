using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap2bai3
{
    internal class UserData
    {
        public int? id;
        public string name;
        public List<float> scores;
        public UserData()
        {
            id = null;
            name = null;
            scores = new List<float>();
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            UserData userData = new UserData();
            // Nhập tên từ người dùng và gán vào thuộc tính name của UserData
            Console.WriteLine("nhap ten:");
            userData.name = Console.ReadLine();
            Console.WriteLine("Userdata.name :" + userData.name);
            // Nhập ID từ người dùng và gán vào thuộc tính id của UserData
            Console.WriteLine("nhap id:");
            string id = Console.ReadLine();
            userData.id = Convert.ToInt32(id);
            Console.WriteLine("Userdata.id:" + userData.id);
            // Nhập danh sách điểm từ người dùng và lưu vào List scores của UserData
            Console.WriteLine("nhap danh sach diem. nhap so luong diem can nhap:");
            int soLuongDiem = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < soLuongDiem; i++)
            {
                userData.scores.Add(Convert.ToInt32(Console.ReadLine()));
            }
            Console.WriteLine("danh sach diem vua nhap la:");
            // in ra các phần tử trong list
            foreach(var i  in userData.scores)
            {
                Console.WriteLine(" " + i);
            }
            Console.ReadLine();
        }
    }
}
