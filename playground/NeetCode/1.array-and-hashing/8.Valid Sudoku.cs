namespace NeetCode.ArraysAndHashing;

public class P8
{
    public static void Run()
    {
        char[][] board1 =
                [['5','3','.','.','7','.','.','.','.']
                ,['6','.','.','1','9','5','.','.','.']
                ,['.','9','8','.','.','.','.','6','.']
                ,['8','.','.','.','6','.','.','.','3']
                ,['4','.','.','8','.','3','.','.','1']
                ,['7','.','.','.','2','.','.','.','6']
                ,['.','6','.','.','.','.','2','8','.']
                ,['.','.','.','4','1','9','.','.','5']
                ,['.','.','.','.','8','.','.','7','9']];

        char[][] board2 =
                [['8','3','.','.','7','.','.','.','.']
                ,['6','.','.','1','9','5','.','.','.']
                ,['.','9','8','.','.','.','.','6','.']
                ,['8','.','.','.','6','.','.','.','3']
                ,['4','.','.','8','.','3','.','.','1']
                ,['7','.','.','.','2','.','.','.','6']
                ,['.','6','.','.','.','.','2','8','.']
                ,['.','.','.','4','1','9','.','.','5']
                ,['.','.','.','.','8','.','.','7','9']];

        char[][] board3 =
                [['.', '.', '4', '.', '.', '.', '6', '3', '.'],
                ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
                ['5', '.', '.', '.', '.', '.', '.', '9', '.'],
                ['.', '.', '.', '5', '6', '.', '.', '.', '.'],
                ['4', '.', '3', '.', '.', '.', '.', '.', '1'],
                ['.', '.', '.', '7', '.', '.', '.', '.', '.'],
                ['.', '.', '.', '5', '.', '.', '.', '.', '.'],
                ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
                ['.', '.', '.', '.', '.', '.', '.', '.', '.']];

        var result = IsValidSudoku(board3);

        System.Console.WriteLine(result);
    }

    public static bool IsValidSudoku(char[][] board)
    {
        bool isUniqueX = true;
        bool isUniqueY = true;
        bool isUniqueInside = true;

        for (int i = 0; i < board.Length; i++)
        {
            var tempX = new HashSet<char>();
            var tempY = new HashSet<char>();
            var tempInside = new HashSet<char>();
            char item = '.';
            for (int j = 0; j < 9; j++)
            {
                // x direction
                item = board[i][j];
                if (IsDigit(item) && !tempX.Add(item))
                    isUniqueX = false;

                // y direction
                item = board[j][i];
                if (IsDigit(item) && !tempY.Add(item))
                    isUniqueY = false;

                // 🔞 inside direction
                var row = (i / 3) * 3 + j / 3;
                var col = (i % 3) * 3 + j % 3;
                item = board[row][col];
                if (IsDigit(item) && !tempInside.Add(item))
                    isUniqueInside = false;
            }

        }
        return isUniqueX && isUniqueY && isUniqueInside;
    }
    static char[] list = ['1', '2', '3', '4', '5', '6', '7', '8', '9'];

    static bool IsDigit(char ch)
    {
        return list.Contains(ch);
    }
}