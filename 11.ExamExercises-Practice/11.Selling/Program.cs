namespace _11.Selling
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

            int sellRow = 0;
            int sellCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'S')
                    {
                        sellRow = row;
                        sellCol = col;
                    }
                }
            }

            int money = 0;


            while (money < 50)
            {
                string command = Console.ReadLine();

                matrix[sellRow, sellCol] = '-';

                sellRow = MoveRow(sellRow, command);
                sellCol = MoveCol(sellCol, command);

                if (!IsPositionValid(sellRow, sellCol, n, n))
                {
                    Console.WriteLine($"Bad news, you are out of the bakery.");
                    break;
                }

                if (matrix[sellRow, sellCol] == '0')
                {
                    money += 0;
                }
                else if (matrix[sellRow, sellCol] == '1')
                {
                    money += 1;
                }
                else if (matrix[sellRow, sellCol] == '2')
                {
                    money += 2;
                }
                else if (matrix[sellRow, sellCol] == '3')
                {
                    money += 3;
                }
                else if (matrix[sellRow, sellCol] == '4')
                {
                    money += 4;
                }
                else if (matrix[sellRow, sellCol] == '5')
                {
                    money += 5;
                }
                else if (matrix[sellRow, sellCol] == '6')
                {
                    money += 6;
                }
                else if (matrix[sellRow, sellCol] == '7')
                {
                    money += 7;
                }
                else if (matrix[sellRow, sellCol] == '8')
                {
                    money += 8;
                }
                else if (matrix[sellRow, sellCol] == '9')
                {
                    money += 9;
                }

                if (matrix[sellRow, sellCol] == 'O')
                {
                    matrix[sellRow, sellCol] = '-';

                    for (int row = 0; row < n; row++)
                    {
                        for (int col = 0; col < n; col++)
                        {
                            if (matrix[row, col] == 'O')
                            {
                                sellRow = row;
                                sellCol = col;
                            }
                        }
                    }

                    if (!IsPositionValid(sellRow, sellCol, n, n))
                    {
                        Console.WriteLine($"Bad news, you are out of the bakery.");
                        break;
                    }
                }

                matrix[sellRow, sellCol] = 'S';
            }

            if (money >= 50)
            {
                Console.WriteLine("Good news! You succeeded in collecting enough money!");
            }

            Console.WriteLine($"Money: {money}");

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
