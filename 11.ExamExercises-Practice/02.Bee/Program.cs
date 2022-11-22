namespace _02.Bee
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                string currInput = Console.ReadLine();

                for (int col = 0; col < currInput.Length; col++)
                {
                    matrix[row, col] = currInput[col];
                }
            }


            int beeRow = 0;
            int beeCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'B')
                    {
                        beeRow = row;
                        beeCol = col;
                    }
                }
            }
            
            int f = 0;

            string command = Console.ReadLine();

            while (command != "End")
            {
                matrix[beeRow, beeCol] = '.';

                beeRow = MoveRow(beeRow, command);
                beeCol = MoveCol(beeCol, command);

                if (!IsPositionValid(beeRow, beeCol, n, n))
                {
                    Console.WriteLine("The bee got lost!");
                    break;
                }

                if (matrix[beeRow, beeCol] == 'f')
                {
                    f += 1;
                }

                if (matrix[beeRow, beeCol] == 'O')
                {
                    matrix[beeRow, beeCol] = '.';
                    beeRow = MoveRow(beeRow, command);
                    beeCol = MoveCol(beeCol, command);

                    if (!IsPositionValid(beeRow, beeCol, n, n))
                    {
                        Console.WriteLine("The bee got lost!");
                        break;
                    }

                    if (matrix[beeRow, beeCol] == 'f')
                    {
                        f += 1;
                    }
                }

                matrix[beeRow, beeCol] = 'B';

                command = Console.ReadLine();
            }

            if (f < 5)
            {
                int dif = 5 - f;
                Console.WriteLine($"The bee couldn't pollinate the flowers, she needed {dif} flowers more");
            }
            else
            {
                Console.WriteLine($"Great job, the bee managed to pollinate {f} flowers!");
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static bool IsPositionValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }

            if (col < 0 || col >= cols)
            {
                return false;
            }

            return true;
        }

        public static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                return row - 1;
            }

            if (movement == "down")
            {
                return row + 1;
            }

            return row;
        }

        public static int MoveCol(int col, string movement)
        {
            if (movement == "left")
            {
                return col - 1;
            }

            if (movement == "right")
            {
                return col + 1;
            }

            return col;
        }
    }
}
