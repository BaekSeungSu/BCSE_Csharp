using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Player
{
    int HP = 100;

    void Damage(int _HP)
    {
        HP = HP - 10;
    }

    public int Plus(int _Left, int _Right)
    {
        return _Left + _Right;
    }

    bool ReturnTrue()
    {
        return true;
    }
}
namespace _09Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int Result = 0;
            int Left = 7;
            int Right = 3;

            // = 대입연산자
            // 함수에서 리턴된 값이나 연산된 값 또는 리터럴 값을 
            // 그 값을 받을 수 있는 변수에 넣어라.

            Player NewPlayer = new Player();
            // 산술연산자
            // =연산자의 우선순위는 오른쪽부터다.
            Result = NewPlayer.Plus(Left, Right);
            Result = Left - Right;
            Result = Left * Right;
            Result = Left / Right;
            Result = Left % Right;

            // 나누기, 나머지에 0을 넣지 말아야 한다.

            // 비교 연산자
            bool BResult = true;
            BResult = false;
            // 연속되어 있을때 단 1개라도 false면 false다.
            BResult = true && false; // and
            // 연속되어 있을때 단 1개라도 true면 true다.
            BResult = true || false; // or
            BResult = true ^ false; // xor
            BResult = !true; // not

        }
    }
}