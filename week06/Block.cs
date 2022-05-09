using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal enum BLOCKDIR
{
    UP,
    RIGHT,
    DOWN,
    LEFT,
    MAX
}

internal enum BLOCKTYPE
{
    BT_I,
    BT_L,
    BT_J,
    BT_Z,
    BT_S,
    BT_T,
    BT_O,
    BT_MAX,
}

internal partial class Block
{
    private int X = 0;
    private int Y = 0;
    private BLOCKDIR Dir = BLOCKDIR.UP;
    private string[][] Arr = null;

    private BLOCKTYPE CurBlockType = BLOCKTYPE.BT_T;
    private BLOCKDIR CurBlockDir = BLOCKDIR.UP;

    private TETRISSCREEN Screen = null;
    private AccScreen AccScreen = null;

    private Random NewRandom = new Random();

    public Block(TETRISSCREEN _screen, AccScreen _accScreen)
    {
        if (null == _screen || null == _accScreen)
        {
            return;
        }

        Screen = _screen;
        AccScreen = _accScreen;
        DataInit();

        Reset();
    }

    public void RandomBlockType()
    {
        int RandomIndex = NewRandom.Next((int)BLOCKTYPE.BT_I, (int)BLOCKTYPE.BT_MAX);
        CurBlockType = BLOCKTYPE.BT_I; //테스트중
    }

    private void SettingBlock(BLOCKTYPE _type, BLOCKDIR _dir)
    {
        Arr = AllBlock[(int)_type][(int)_dir];
    }

    public void SetAccScreen()
    {
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                if ("■" == Arr[y][x])
                {
                    AccScreen.SetBlock(Y + y - 1, X + x, Arr[y][x]);
                }
            }
        }
    }

    public void Reset()
    {
        RandomBlockType();
        X = 0;
        Y = 1;
        SettingBlock(CurBlockType, CurBlockDir);
    }

    public bool DownCheck()
    {
        for (int y = 0; y < 4; y++)
        {
            for (int x = 0; x < 4; x++)
            {
                if ("■" == Arr[y][x])
                {
                    if (AccScreen.Y == Y + y || true == AccScreen.IsBlock(Y + y, x + X, "■"))
                    {
                        SetAccScreen();
                        Reset();
                        return true;
                    }
                }
            }
        }
        return false;
    }

    public void Down()
    {
        if (true == DownCheck())
        {
            return;
        }

        Y += 1;
    }

    private void Input()
    {
        if (false == Console.KeyAvailable)
        {
            Down();
            return;
        }

        switch (Console.ReadKey().Key)
        {
            case ConsoleKey.A:
                X -= 1;
                break;

            case ConsoleKey.D:
                X += 1;
                break;

            case ConsoleKey.Q:
                --CurBlockDir;
                if (0 > CurBlockDir)
                {
                    CurBlockDir = BLOCKDIR.LEFT;
                }
                SettingBlock(CurBlockType, CurBlockDir);
                break;

            case ConsoleKey.E:
                ++CurBlockDir;
                if (BLOCKDIR.MAX == CurBlockDir)
                {
                    CurBlockDir = BLOCKDIR.UP;
                }
                SettingBlock(CurBlockType, CurBlockDir);
                break;

            case ConsoleKey.S:
                Down();
                break;

            default:
                break;
        }
    }

    public void Move()
    {
        Input();

        for (int y = 0; y < 4; ++y)
        {
            for (int x = 0; x < 4; ++x)
            {
                if (Arr[y][x] == "□")
                {
                    continue;
                }

                Screen.SetBlock(Y + y, X + x, Arr[y][x]);
            }
        }
    }
}