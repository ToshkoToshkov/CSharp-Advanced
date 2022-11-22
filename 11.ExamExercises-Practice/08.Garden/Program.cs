namespace _08.Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = dimensions[0];
            int m = dimensions[1];

            int[,] matrix = new int[n, m];

            string command;

            while ((command = Console.ReadLine()) != "Bloom Bloom Plow")
            {
                int[] cordinates = command
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int row = cordinates[0];
                int col = cordinates[1];

                int rowToChange = row;
                int colToChange = col;

                if (Check(n, m, row, col))
                {
                    while (rowToChange >= 0) //up
                    {
                        matrix[rowToChange, colToChange]++;
                        rowToChange--;
                    }

                    rowToChange = row + 1;

                    while (rowToChange < n) //down
                    {
                        matrix[rowToChange, colToChange]++;
                        rowToChange++;
                    }

                    rowToChange = row;

                    colToChange--;

                    while (colToChange >= 0)//left
                    {
                        matrix[rowToChange, colToChange]++;
                        colToChange--;
                    }

                    colToChange = col + 1;

                    while (colToChange < m)//right
                    {
                        matrix[rowToChange, colToChange]++;
                        colToChange++;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates.");
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }

        public static bool Check(int row, int col, int initialRow, int initialCol)
        {
            if ((initialRow >= 0 && initialRow < row) && (initialCol >= 0 && initialCol < col))
            {
                return true;
            }
            return false;
        }
    }
}
