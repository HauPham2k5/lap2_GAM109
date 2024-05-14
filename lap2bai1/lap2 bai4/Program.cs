using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap2_bai4
{
    internal class Program
    {
        static void Main()
        {
            List<int>numberList = new List<int>();

            numberList.Add(10);
            numberList.Add(20);
            numberList.Add(7);
            numberList.Add(13);
            numberList.Add(23);
            numberList.Add(30);
            //yêu cầu1:hien thi danh sach cac so nguyen
            Console.WriteLine("Danh sach cac so nguyen:");
            foreach (int number in numberList)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();
            //yêu cầu 2:tính tổng các số nguyên trong danh sách
            int totalSum = numberList.Sum();
            Console.WriteLine("Tong cac so nguyen trong danh sach: " + totalSum);
            //yêu cầu 3:tính tổng các số nguyên tố có trong danh sách           
            int result = 0;
            foreach (int number  in numberList)
            {
                if (check(number))
                {
                    result += number;
                }
            }
            Console.WriteLine("Tong cac so nguyen to trong danh sach: " + result);

            int evenSumAtOddPositions = 0;
            for (int i = 0; i < numberList.Count; i++)
            {
                if (i % 2 != 0 && numberList[i] % 2 == 0)
                {
                    evenSumAtOddPositions += numberList[i];
                }
            }
            Console.WriteLine("Tong cac so chan o vi tri le trong danh sach: " + evenSumAtOddPositions);
            Console.ReadLine();
        }
       public static  Boolean check  (int num)
        {
            if (num <=1) return false;
            for (int i = 2;i<num; i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        

    }
}
