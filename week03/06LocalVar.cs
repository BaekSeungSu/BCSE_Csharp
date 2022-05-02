using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 클래스 내부에 있다고해서 멤버변수
    int Atk;
    int Hp;
    public void Fight()
    {
        int Damage = 0;
        Console.WriteLine("플레이어가 싸운다.");
    }
}

namespace _06LocalVar
{
    // C#은 고지식한 객체지향 언어
    // 클래스밖에 모름

    class Program
    {
        static void Main(string[] args)
        {
            //함수 안에 있으면 지역변수
            int ATK = 0;
            ATK = 50;
            Player NewPlayer1 = new Player();
            Player NewPlayer2 = new Player();
            NewPlayer1.Fight();
        }
    }
}
