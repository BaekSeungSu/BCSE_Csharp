using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class AccScreen : TETRISSCREEN
{
    private TETRISSCREEN Parent;

    public AccScreen(TETRISSCREEN _Parent) : base(_Parent.X, _Parent.Y - 2, false)
    {
        Parent = _Parent;
    }

    public override void Render()
    {
        for (int y = 0; y < BlockList.Count; ++y)
        {
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                Parent.SetBlock(y + 1, x, BlockList[y][x]);
            }
        }
    }

    public void DestroyCheck()
    {
        for (int y = (BlockList.Count - 1); y >= 0; y--)
        {
            bool IsDestroy = true;
            for (int x = 0; x < BlockList[y].Count; ++x)
            {
                if (BlockList[y][x] == "□")
                {
                    IsDestroy = false;
                }
            }

            if (true == IsDestroy)
            {
                List<string> NewLine = new List<string>();

                for (int i = 0; i < X; i++)
                {
                    NewLine.Add("□");
                }

                BlockList.RemoveAt(BlockList.Count - 1);
                BlockList.Insert(0, NewLine);
                y = BlockList.Count - 1;
            }
        }
    }
}