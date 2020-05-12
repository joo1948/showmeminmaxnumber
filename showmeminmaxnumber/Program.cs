using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace showmeminmaxnumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            for(int i = 0; i < 5; i++)//입력하는 for문
            {
                Console.Write("숫자를 입력해주세요: ");
                num[i]=int.Parse(Console.ReadLine());
            }
            int min = num[0], max = num[0];
            for(int i = 0; i < 5; i++)//min, max 구하는 for문
            {
                for(int j = 0; j <= i; j++)
                {
                    if (min > num[j]) min = num[j];
                    if (max < num[j]) max = num[j];
                }
            }
            Console.WriteLine("------------------------");
            Console.WriteLine("가장 큰 수 : " + max);
            Console.WriteLine("가장 작은 수 : " + min);
        }
    }
}
