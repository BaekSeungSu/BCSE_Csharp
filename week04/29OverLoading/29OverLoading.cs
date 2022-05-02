using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum DMGTYPE
{
    PYDMG,
    FIREDMG,
    ICEDMG
}
class Player
{

    //물리방어
    int AttDef = 5;
    //불방어
    int FireDef = 5;
    //물방어
    int IceDef = 5;

    int HP = 100;

    public Player()
    {

    }

    public Player(int _HP)
    {

    }

    //Damageint
    //함수 오버로딩
    public void Damage(int _Damage)
    {
        HP -= _Damage;
    }

    //Damagefloat
    public void Damage(float _Damage)
    {

    }

    //Damagefloatint
    public void Damage(float _dddd,int _Type)
    {

    }

    //Damageintint
    public void Damage(int _Damage,DMGTYPE _Type)
    {
        switch (_Type)
        {
            case DMGTYPE.PYDMG:
                _Damage -= AttDef;
                break;

            case DMGTYPE.FIREDMG:
                _Damage -= FireDef;
                break;

            case DMGTYPE.ICEDMG:
                _Damage -= IceDef;
                break;

            default:
                break;
        }
        Damage(_Damage);
    }
}

namespace _29OverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Player NewPlayer = new Player(100);
            NewPlayer.Damage(100,DMGTYPE.FIREDMG);
        }
    }
}
