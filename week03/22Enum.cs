using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 사용자 정의 자료형 중 하나이다.

enum ITEMTYPE
{
    EQUIP,
    POTION,
    QUEST,
    NONESELECT
}

class Item
{
    // 아이템 타입
    public ITEMTYPE ItemType = ITEMTYPE.NONESELECT;

    public void PotionTypeSetting()
    {
        ItemType = ITEMTYPE.POTION;
    }
}
namespace _22Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            Item NewItem = new Item();
            NewItem.ItemType = ITEMTYPE.POTION;
            NewItem.PotionTypeSetting();

            // 값형이고 int라고 생각해도 된다.
            Console.WriteLine(ITEMTYPE.POTION);

            ITEMTYPE Type = ITEMTYPE.POTION;

            // alt + enter switch 자동완성
            switch (Type)
            {
                case ITEMTYPE.EQUIP:
                    break;
                case ITEMTYPE.POTION:
                    break;
                case ITEMTYPE.QUEST:
                    break;
                case ITEMTYPE.NONESELECT:
                    break;
                default:
                    break;
            }
        }
    }
}