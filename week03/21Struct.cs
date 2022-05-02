using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

struct StructData
{
    // 클래스와 비슷하지만 리터럴 초기화를 할 수 없다.
    // = 0 이 기본이다.

    public int a;
    public int b;

    public void Func()
    {
        a = 100;
        b = 100;
    }
}

namespace _21Struct
{
    class Program
    {
        static void Test(StructData _Data)
        {
            _Data.a = 1000;
        }

        // TestNumber 함수와 동일하게 작동한다.
        // 참조가 아니라 복사가 이루어진다.

        static void TestNumber(int _Number)
        {
            _Number = 1000;
        }
        static void Main(string[] args)
        {
            StructData newData = new StructData();

            newData.a = 10;
            newData.b = 10;

            // 클래스를 객체화하면 참조형

            Test(newData);
        }
    }
}