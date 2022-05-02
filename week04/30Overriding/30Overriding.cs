using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class FightUnit
{
    public string Name = "NONE";
    protected int AT = 10;
    protected int HP = 100;

    //이 문법의 핵심은
    //자식에서 만약 나의 GetAT를 재구현했다면
    //자식의 형태의 GetAT를 호출해주세요.
    //이걸 오버라이딩
    //다형성(동적바인딩)의 핵심 문법중 하나이다.
    public virtual int GetAT()
    {
        Console.WriteLine("FightUnit의 GETAT");
        return AT;
    }
    public virtual void Damage(FightUnit _OtherFightUnit)
    {
        int AT = _OtherFightUnit.GetAT();
        Console.WriteLine(_OtherFightUnit.Name + "에게 " + AT + "만큼의 데미지를 입었습니다.");
        HP -= AT;
    }
}

class Player : FightUnit
{
    int ItemAt = 5;

    public override int GetAT()
    {
        Console.WriteLine("Player의 GETAT");
        return AT + ItemAt;
    }

    public Player(string _Name)
    {
        Name = _Name;
    }

    public override void Damage(FightUnit _OtherFightUnit)
    {
        int AT = _OtherFightUnit.GetAT();
        Console.WriteLine(_OtherFightUnit.Name + "에게 " + AT + "만큼의 데미지를 입었습니다.");
        HP -= AT;
    }

}

class Monster : FightUnit
{
    int MonsterLv = 2;

    public override int GetAT()
    {
        Console.WriteLine("Monster의 GETAT");
        return AT+MonsterLv;
    }

    public Monster(string _Name, int _MonsterLv)
    {
        Name = _Name;
        MonsterLv = _MonsterLv;
    }

    public override void Damage(FightUnit _OtherFightUnit)
    {
        int AT = _OtherFightUnit.GetAT();
        Console.WriteLine(_OtherFightUnit.Name + "에게 " + AT + "만큼의 데미지를 입었습니다.");
        HP -= AT;
    }

}

namespace _30Overriding
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player("플레이어");
            Monster NewMonster = new Monster("몬스터",10);

            NewPlayer.GetAT();
            NewPlayer.Damage(NewMonster);
            NewMonster.Damage(NewPlayer);

        }
    }
}
