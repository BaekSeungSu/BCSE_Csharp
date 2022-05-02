using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17while
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool 값이 들어가면 된다.
            // 조건문 -> 실행코드
            bool check = true;
            while (check)
            {
                Console.WriteLine("무한 출력");
                check = false;
            }

            // while문은 쓸때 빠져나올수 조건을 넣어놓고 실행해줘야 한다.
            int Count = 0;

            do
            {
               
                Console.WriteLine(Count);
                Count += 1;
            } while (Count<100);
        }
    }
}
