using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 자료구조를 직접 만들어 보는 것은
// 게임 프로그래머의 언어와도 같은 기초소양이다.
// 자료 구조에 대해서 알아보자.
// 총알이 1000발 발사된다. 어떻게 관리하지?
// NPC가 500명이 있다. 그중에서 '피오나'라는 NPC가 있는데, 어떻게 찾지?

class MyDataStruct<T>
{

    // 넣는다.()
    // 탐색.()
    // 확장한다.()


    public void Push(T _Data) { }

    //if (/* 이 자료가 들어왔을 때 내 사이즈를 오버하면 */)
    //{
    //  MDS.Ex()
    //}
    public void Find(T _Data) { }

    public void EX(int _Size) { }


}

namespace _38DataStructer
{
    class Program
    {
        static void Main(string[] args)
        {
            // 자료구조 하는 것은
            // int 10
            // 0 1 2 3 4 5 6 7 8 9

            // 자료구조에는
            // 다음의 구조와 인터페이스를 지원한다.

            // 넣는다.()
            // 탐색.()
            // 확장한다.()

            // 최악의 생각들
            // 나대면 안된다.
            // 질문해야 한다.
            // 모르면 나대면
            // 정확하게 어디까지 모르는지를
            // 확실히 상대방이 인지하게 해주어야 한다.
            // 자기가 모른다는 것을 감추려고 변명을 한다. 안된다는 것이다.
            // 나는 모른다.()
            // 정답을 말해야 한다는 압박감.
            // 모른다고 말하면 안된다.

            // 자료구조에는 보통 컨테이너라는 용어를 사용하는데,
            // 시퀀스 컨테이너와 List(c#) vector(c#에 c/c## 없다)
            // 연관 컨테이너 Dictionary(c# 해쉬 맵) map(c++)
            // 어댑터 컨테이너로 분류. stack queue

            // 데이터의 메모리 구조는
            // 배열과
            // 노드형

            int[] Arr = new int[10];

            Arr[0] = 312;
            Arr[1] = 5343;

            int[] Arr2 = Arr;
            Arr = new int[15];


            MyDataStruct<int> MDS = new MyDataStruct<int>();

            MDS.Push(100); // 100 넣기

            MDS.EX(56); // 사이즈 56으로 늘리기

            MDS.Find(50); // 50 찾기

            // 자동으로 이루어진다.
        }
    }
}