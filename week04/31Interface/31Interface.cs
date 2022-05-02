using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//사용자 정의 자료형인데.
interface QuestUnit
{
    //맴버변수 X
    //int A = 0;

    //함수의 형태만 물려 줄수 있는 문법이다.
    void Talk(QuestUnit _OtherUnit);
    void Event(QuestUnit _OtherUnit);
}

class FightUnit
{
    int AT;
    int DMG;
    public void Damage()
    {

    }
}
//인터페이스는 함수구현을 강제할수 있다.
//인터페이스는 상속이라고 안하는 사람도 있다.
//포함의 개념이다라고 말하는 사람도있다.
//인퍼페이스를 상속받았다고 치면
//
class Player : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }

    public void Event(QuestUnit _OtherUnit)
    {

    }
}

class NPC : FightUnit, QuestUnit
{
    public void Talk(QuestUnit _OtherUnit)
    {

    }

    public void Event(QuestUnit _OtherUnit)
    {

    }
}

class Monster : FightUnit
{

}

class Program
{
     static void Main(string[] args)
    {
        Player NewPlayer = new Player();
        NPC NewNPC = new NPC();
        
        //업캐스팅이 된다.
        NewPlayer.Talk(NewNPC);
    }
}

