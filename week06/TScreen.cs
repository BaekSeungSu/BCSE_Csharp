using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class TETRISSCREEN
{
    //블록을 표현하는 부분
    //메모리를 더 할당해서 정보를 분리하면 대부분의 문제는 해결됨.

    protected List<List<string>> BlockList = new List<List<string>>();

    public int Y
    {
        get
        {
            return BlockList.Count;
        }
    }

    public int X
    {
        get
        {
            return BlockList[0].Count;
        }
    }

    public void SetBlock(int _y, int _x, string _Type)
    {
        BlockList[_y][_x] = _Type;
    }

    public bool IsBlock(int _y, int _x, string _Type)
    {
        return BlockList[_y][_x] == _Type;
    }

    public void Clear()
    {
        for (int y = 0; y < BlockList.Count; ++y)
        {
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                if (y == 0 || y == BlockList.Count - 1)
                {
                    BlockList[y][x] = "▣";
                    continue;
                }

                //BlockList[y][x] = "□";
            }
        }
    }

    public virtual void Render()
    {
        for (int y = 0; y < BlockList.Count; ++y)
        {
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                Console.Write(BlockList[y][x]);
            }
            Console.WriteLine("");
        }
    }

    public TETRISSCREEN(int _x, int _y, bool TopBottomLine)
    {
        for (int y = 0; y < _y; ++y)
        {
            BlockList.Add(new List<string>());

            for (int x = 0; x < _x; ++x)
            {
                BlockList[y].Add("□");
            }
        }

        if (false == TopBottomLine)
        {
            return;
        }

        for (int i = 0; i < BlockList[0].Count; i++)
        {
            BlockList[0][i] = "▣";
        }
        for (int i = 0; i < BlockList[BlockList.Count - 1].Count; i++)
        {
            BlockList[BlockList.Count - 1][i] = "▣";
        }
    }
}