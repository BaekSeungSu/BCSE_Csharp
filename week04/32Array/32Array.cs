using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Item
{
    public string Name;
    int AT;
    int DF;
}
namespace _32Array
{
    class Program
    {


        static void Main(string[] args)
        {
            // 배열은 기본적으로 자료형이라고 할 수 있으며
            // 기본 자료형에 속한다.
            // 선언 방식은 어떤 자료형[]

            // 모든 자료형은 구조체 혹은 클래스에 가까운데,
            // 기본자료형도 마찬가지라고 표현하였다.
            int[] Arrint = new int[10];
            float[] Arrfloat = new float[10];


            // 정수형 short
            // int 64
            // Arrint는 int의 배열형(int의 집합)
            // Arrint[0]은 무슨 자료형인가? int형

            // C#에서는 모든 자료형은 클래스 혹은
            // 구조체에 가깝다.
            // 멤버 변수와 멤버 함수가 있다.

            // 여러 개가 모여있는 것.
            // 연속되어 있다.
            // 접근 방법 그 모여있는 자료들을 접근하는 방법

            for (int i = 0; i < Arrint.Length; i++)
            {
                Console.WriteLine(Arrint[i]);
            }

            // 배열을 언제 사용하느냐?
            // 아이템 100개가 있다.


            // 아이템이라는 참조형을
            // 담을수 있는 공간이 10개 생겼다.

            // new Item();
            // 이것은 아이템을 만든 것이 아니다.
            // 아이템을 100개 담을 수 있는 공간을 만든 것이다.
            // new Item[100];

            // 아이템이라는 메모리를
            // 가리킬 수 있는 참조형이 10개 생겼다
            Item[] ArrItem = new Item[10];

            for (int i = 0; i < ArrItem.Length; i++)
            {
                ArrItem[i] = new Item();
            }

            Console.WriteLine(Arrint[0]);
            ArrItem[0].Name = "철검";
            ArrItem[1].Name = "전설의 검";
            ArrItem[2].Name = "갑옷";
            ArrItem[3].Name = "멋진 갑옷";

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(ArrItem[i].Name);
            }
        }
    }
}