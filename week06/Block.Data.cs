using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

partial class Block
{
   
    private List<List<string[][]>> AllBlock = new List<List<string[][]>>();

    private void DataInit()
    {
        for (int BlockType = 0; BlockType < (int)BLOCKTYPE.BT_MAX; ++BlockType)
        {
            AllBlock.Add(new List<string[][]>());

            for (int BlockDir = 0; BlockDir < (int)BLOCKDIR.MAX; ++BlockDir)
            {
                AllBlock[BlockType].Add(null);
            }
        }

        #region I

        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.UP] = new string[][]  {
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.RIGHT] = new string[][]  {
        new string[] { "■", "■", "■", "■" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.DOWN] = new string[][]  {
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_I][(int)BLOCKDIR.LEFT] = new string[][]  {
        new string[] { "■", "■", "■", "■" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        #endregion I

        #region T

        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.UP] = new string[][]  {
        new string[] { "□", "■", "□", "□" },
        new string[] { "■", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.RIGHT] = new string[][]  {
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.DOWN] = new string[][]  {
        new string[] { "□", "□", "□", "□" },
        new string[] { "■", "■", "■", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_T][(int)BLOCKDIR.LEFT] = new string[][]  {
        new string[] { "□", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        #endregion T

        #region J

        AllBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.UP] = new string[][]  {
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.RIGHT] = new string[][]  {
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.DOWN] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_J][(int)BLOCKDIR.LEFT] = new string[][]  {
        new string[] { "■", "■", "■", "□" },
        new string[] { "□", "□", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        #endregion J

        #region L

        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.UP] = new string[][]  {
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.RIGHT] = new string[][]  {
        new string[] { "■", "■", "■", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.DOWN] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_L][(int)BLOCKDIR.LEFT] = new string[][]  {
        new string[] { "□", "□", "■", "□" },
        new string[] { "■", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        #endregion L

        #region S

        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.UP] = new string[][]  {
        new string[] { "□", "■", "■", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.RIGHT] = new string[][]  {
        new string[] { "■", "□", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.DOWN] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_S][(int)BLOCKDIR.LEFT] = new string[][]  {
        new string[] { "□", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        #endregion S

        #region Z

        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.UP] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.RIGHT] = new string[][]  {
        new string[] { "□", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.DOWN] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "■", "■", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_Z][(int)BLOCKDIR.LEFT] = new string[][]  {
        new string[] { "□", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        #endregion Z

        #region O

        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.UP] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.RIGHT] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.DOWN] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        AllBlock[(int)BLOCKTYPE.BT_O][(int)BLOCKDIR.LEFT] = new string[][]  {
        new string[] { "■", "■", "□", "□" },
        new string[] { "■", "■", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        new string[] { "□", "□", "□", "□" },
        };

        #endregion O
    }
}