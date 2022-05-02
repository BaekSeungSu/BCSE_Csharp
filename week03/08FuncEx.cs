using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    // 보통 외부에서 접근하지 못하게 private로 정의한다.
    // 
    private int LV = 1;
    private int AT = 10;
    private int HP = 100;

    // 플레이어의 레벨이 얼마인지 알고싶다.
    // 리턴 값 : 자신의 상태를 외부에 알려주는 용도
    // 외부에 알려주는 순간 함수가 끝나게 된다.
    public int GetLv()
    {
        LV = 10000;
        return LV;
    }

    // 함수를 통해서 접근한다.
    public void SetHP(int _HP)
    {
        // 조건문을 통해 다양한 조건 가능
        // 가장 큰 핵심은 디버깅이 된다는 것이다.
        HP = _HP;
    }

    public void LVUP()
    {
        AT = 100;
        HP = 1000;
    }

    // 함수는 보통 선언/내용으로 나뉜다.
    // 함수는 보통 클래스 외부와의 소통을 위해서 만든다.
    // 외부에서 1개의 int값을 넣어서 플레이어에게 전달해 주겠다는 뜻이다.
    public void Damage1(int _Dmg)
    {
        HP = HP - _Dmg;
    }

    // 리턴값은 자신이 리턴해주려는 자료형과 동일한 자료형이어야 한다.
    public int DamageToHPReturn(int _Dmg, int _Dmg1)
    {
        HP = HP - _Dmg - _Dmg1;
        return HP;
    }
    // 개수는 신경 안 써도 된다.
    public void Damage2(int _Dmg, int _SubDmg)
    {
        HP = HP - _Dmg;
        HP = HP - _SubDmg;
    }
}
// 플레이어가 어떤 사양과 내용을 갖췄다.

namespace _08FuncEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player();
            // NewPlayer.LVUP();

            //NewPlayer.SetHP(1000);

            // 외부의 값을 받아서 객체가 내부의 상태를 변화시키기 위해서 함수를 선언하는 경우가 많다.
            //NewPlayer.Damage1(10);
            //NewPlayer.Damage1(20);
            //NewPlayer.Damage2(10,20);

            Console.WriteLine(NewPlayer.GetLv());

            Console.WriteLine(NewPlayer.DamageToHPReturn(50, 20));

        }
    }
}