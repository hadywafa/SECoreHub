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
        var result = IsValidSudoku(board2);

        System.Console.WriteLine(result);
    }

    public static bool IsValidSudoku(char[][] board)
    {
        bool isUniqueX = true;
        bool isUniqueY = true;
        bool isUniqueInside = true;

        for (int i = 0; i < board.Length; i++)
        {
            // x direction
            var tempX = new HashSet<char>();
            // foreach (var item in board[i])
            for (int j = 0; j < 9; j++)
            {
                var item = board[i][j];
                if (item == '.')
                    continue;
                if (!tempX.Add(item))
                    isUniqueX = false;
            }

            // y direction
            var tempY = new HashSet<char>();
            for (int j = 0; j < 9; j++)
            {
                var item = board[j][0];
                if (item == '.')
                    continue;
                if (!tempY.Add(item))
                    isUniqueY = false;
            }

            // inside direction
            var tempInside = new HashSet<char>();
            for (int j = 0; j < 9; j++)
            {
                var minI = Math.Min(i, j / 3);
                var minJ = Math.Min(j, i / 3);
                var item = board[minI][minJ];
                if (item == '.')
                    continue;
                if (!tempInside.Add(item))
                    isUniqueInside = false;
            }
            //Clear

        }
        return isUniqueX && isUniqueY && isUniqueInside;
    }
}