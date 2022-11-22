namespace _05.Snake
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

            int snakeRow = 0;
            int snakeCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        snakeRow = row;
                        snakeCol = col;
                    }
                }
            }

            int food = 0;

            while (food < 10)
            {
                string command = Console.ReadLine();

                matrix[snakeRow, snakeCol] = '.';

                snakeRow = MoveRow(snakeRow, command);
                snakeCol = MoveCol(snakeCol, command);

                if (!IsPositionValid(snakeRow, snakeCol, n, n))
                {
                    Console.WriteLine("Game over!");
                    break;
                }

                if (matrix[snakeRow, snakeCol] == '*')
                {
                    food += 1;
                }

                if (matrix[snakeRow, snakeCol] == 'B')
                {
                    matrix[snakeRow, snakeCol] = '.';

                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            if (matrix[row, col] == 'B')
                            {
                                snakeRow = row;
                                snakeCol = col;
                            }
                        }
                    }

                    if (!IsPositionValid(snakeRow, snakeCol, n, n))
                    {
                        Console.WriteLine("Game over!");
                        break;
                    }
                }

                matrix[snakeRow, snakeCol] = 'S';
            }

            if (food >= 10)
            {
                Console.WriteLine("You won! You fed the snake.");
            }

            Console.WriteLine($"Food eaten: {food}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
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
    }
}
