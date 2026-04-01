public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];
        
        for (int i = 0; i < 9; i ++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int r = 0; r < 9; r++)
        {
            for (int c = 0; c < 9; c++)
            {
                char temp = board[r][c];
                if (temp == '.') continue;
                if (rows[r].Contains(temp)) return false;
                // Kiểm tra Cột
                rows[r].Add(temp);
                //Kiểm tra hàng
                if (cols[c].Contains(temp)) return false;
                cols[c].Add(temp);
                // Kiểm tra hộp
                // (r/3)*3 để xác định tầng (0,1,2)
                // c/3 để xác định cột (0,1,2)
                int boxIndex = (r/3)*3 + (c/3);
                if (boxes[boxIndex].Contains(temp)) return false;
                boxes[boxIndex].Add(temp);
            }
        }
        return true;
    }
}
