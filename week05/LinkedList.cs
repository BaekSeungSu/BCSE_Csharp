using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Zone
{
    public string Name = "Zone";

    public List<Zone> LinkZone = new List<Zone>();

    public Zone(string _Name)
    {
        Name = _Name;
    }
}
class Node<T>
{
    // 보통 게임 맵에서 많이 사용한다.
    public Node<T> Next;
    public Node<T> Prev;
}

class MyLinkList<T>
{
    public Node<T> First;
    public Node<T> Last;
}

namespace LinkedList
{
    class LinkedList
    {
        static void Main(string[] args)
        {
            // 시퀀스 배열형 List
            // 시퀀스 노드형 LinkedList

            LinkedList<int> LList = new LinkedList<int>();


            // 가장 앞에 붙인다.
            LList.AddFirst(10);
            LList.AddLast(90);
            LList.AddFirst(50);
            LList.AddLast(70);

            // LList.AddFirst(20);
            // LList.AddFirst(33);

            LinkedListNode<int> Cur = LList.First;
            Cur = Cur.Next;

            LList.AddAfter(Cur, 999);

            for (LinkedListNode<int> StartNode = LList.First;
                null != StartNode;
                StartNode = StartNode.Next)
            {
                Console.WriteLine(StartNode.Value);
            }
        }
    }
}