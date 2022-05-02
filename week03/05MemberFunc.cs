using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 행동에 대해서 설명해 보세요.
// 지형에서 움직인다.
// 몬스터를 공격한다.
// NPC와 대화한다.
// 스킬을 사용한다.

class Player
{
    // 명사 만으로는 부족
    int atk = 100;
    int Hp = 50;

    // 행동으로 나타내게 된다.
    // 이런 것들을 표현하는 것이 맴버함수라고 한다.
    // 굉장히 다양한 방법으로 함수를 선언할 수 있다.
    void Fight()
    {

    }

    void Skill_use()
    {

    }

    void Talk()
    {

    }
}

// RPG를 만든다 -> 프로젝트를 만든다.
// 주인공이 있다. -> 클래스
// 주인공이 공격력이 있다. -> 멤버 변수
// 주인공이 공격력으로 때린다. -> 멤버함수