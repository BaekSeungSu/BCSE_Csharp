using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DicTest
{
    public Dictionary<string, int> NewDic = new Dictionary<string, int>();

    public void Print(string _Name)
    {
        if (false == NewDic.ContainsKey(_Name))
        {
            return;
        }

        Console.WriteLine(NewDic[_Name]);
    }
    public void Add(string _Name, int Value)
    {
        if (true == NewDic.ContainsKey(_Name))
        {
            return;
        }

        NewDic.Add(_Name, Value);
    }
}
namespace Dictionary
{
    class Dictionary
    {
        static void Main(string[] args)
        {
            // 연관 복합
            // string 키
            // int 밸류(데이터)
            Dictionary<string, int> NewDic = new Dictionary<string, int>();

            if (false == NewDic.ContainsKey("일이에요"))
            {
                NewDic.Add("일이에요", 1);
            }
            NewDic.Add("이에요", 2);
            NewDic.Add("뭘까요", 877978);
            // 같은 키를 두번 넣어주는 것은 불가능하다.
            NewDic.Add("중복테스트", 122);
            // NewDic.Add("중복테스트", 122);

            string key = "테스트용";
            // 인덱서
            // 연산자 겹지정이라고 한다.
            // 찾는다는 작업에 특화됐다.

            if (true == NewDic.ContainsKey("중복테스트"))
            {
                Console.WriteLine(NewDic["중복테스트"]);
            }
            if (true == NewDic.ContainsKey(key))
            {
                Console.WriteLine(NewDic[key]);
            }

            Console.WriteLine(NewDic["일이에요"]);

            DicTest NewTest = new DicTest();

            NewTest.Add("하하하", 1);
            NewTest.Add("하하하", 1);
            NewTest.Add("하하하1", 21);
            NewTest.Add("키입니다", 1);

            NewTest.Print("키입니다");
            NewTest.Print("하하하1");

        }
    }
}