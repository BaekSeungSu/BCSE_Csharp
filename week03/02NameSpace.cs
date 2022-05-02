using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 문법을 공부할때.
// 응용법까지 욕심내는 경우가 있다.
// 게임프로그래밍에서는
// 실제 코드를 짜면서 보기전까지는
// 응용에대해서 느낄수가 없다.


// 프로그래머가 2명이다.
// RGP를 만들기로 했다.
// 몬스터
// 무기
// 아이템

// A프로그래머
// HP 포션
// B프로그래머
// MP 포션

// 클래스의 이르들은
// 전문적인 용어로 식별자
// 어떠한 코드적 내용을
// 묶는 하나의 명칭이다.


// A프로그래머
// 네임스페이스는 개념의 표현이라기 보다는 개념의 분류이다.
namespace APRO
{
    class /*APRO.*/Potion
    {
        //플레이어가 마시면 HP가 차는 내용
    }
}


// 식별자가 겹칠때의 문제는
// 사용할때이다.
// Potion쓸게 <- 어떤 포션을 사용할지 특정할 수 없기 때문에 오류 발생

// B프로그래머
namespace BSS
{
    class /*BPRO.*/Potion
    {
        //플레이어가 마시면 MP가 차는 내용
    }
}
