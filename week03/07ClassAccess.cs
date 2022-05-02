using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 객체지향의 캡슐화 은닉화를 대표하는 문법
    // 접근제한 지정자입니다.
    public int HP; // 공개
    protected int ATK; // 자식에게만 공개
    private int DEF; // 내부에만 공개

    public void Fight()
    {
        Console.WriteLine("플레이어가 싸운다.");
    }
}


namespace _07ClassAccess
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            //만들어진 객체의 내용을 사용하기 위해서는 객체의 이름. 을 사용한다.

            //잘못쓰기도 힘들게 클래스를 만들어놔라.
            NewPlayer.HP = 0;
            NewPlayer.Fight();
        }
    }
}
