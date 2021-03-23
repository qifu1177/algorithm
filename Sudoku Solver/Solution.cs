public class Solution
{
    public void SolveSudoku(char[][] board)
    {
        Backtrace(board);
    }
    private bool Backtrace(char[][] board)
    {
        bool b = true;
        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                if (board[i][j] == '.')
                {
                    return Backtrace(board, i, j);
                }
            }
        }
        return b;
    }
    private bool Backtrace(char[][] board, int si, int sj)
    {
        bool b = true;
        string strLine = "";
        string strColumn = "";
        string strZone = "";
        for (int i = 0; i < 9; i++)
        {
            strLine += board[si][i];
        }
        for (int i = 0; i < 9; i++)
        {
            strColumn += board[i][sj];
        }
        int startI = (int)Math.Floor((decimal)si / 3) * 3;
        int startJ = (int)Math.Floor((decimal)sj / 3) * 3;

        for (int i = startI; i < startI + 3; i++)
        {
            for (int j = startJ; j < startJ + 3; j++)
            {
                strZone += board[i][j];
            }
        }
        for (int i = 1; i <= 9; i++)
        {
            char c = ("" + i)[0];
            if (strLine.Contains(c + "") || strColumn.Contains(c + "") || strZone.Contains(c + ""))
                continue;
            else
            {
                board[si][sj] = c;
                b = Backtrace(board);
                if (b)
                {
                    break;
                }
                else
                {
                    board[si][sj] = '.';
                }
            }
        }
        b = board[si][sj] != '.';
        return b;
    }
}