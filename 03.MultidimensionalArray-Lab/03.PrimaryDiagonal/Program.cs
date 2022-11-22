namespace PrimaryDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[,] matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                int[] currInput = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = currInput[col];
                }
            }

            int sum = 0;

            for (int i = 0; i < matrix.GetLength(1); i++) // column
            {
                for (int j = 0; j < matrix.GetLength(0); j++) // row
                {
                    if (i == j)
                    {
                        sum += matrix[j, i];
                    }
                }
            }

            Console.WriteLine(sum);
        }
    }
}
