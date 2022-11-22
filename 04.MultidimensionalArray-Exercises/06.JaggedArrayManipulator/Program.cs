﻿namespace JaggedArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[][] jaggedMatrix = new int[n][];

            for (int row = 0; row < n; row++)
            {
                int[] rowData = Console.ReadLine()
                     .Split(" ")
                      .Select(int.Parse)
                      .ToArray();

                jaggedMatrix[row] = rowData;
            }

            for (int row = 0; row < n - 1; row++)
            {
                int[] firstArray = jaggedMatrix[row];
                int[] secondArray = jaggedMatrix[row + 1];

                if (firstArray.Length == secondArray.Length)
                {
                    jaggedMatrix[row] = firstArray.Select(e => e * 2).ToArray();
                    jaggedMatrix[row + 1] = secondArray.Select(e => e * 2).ToArray();
                }
                else
                {
                    jaggedMatrix[row] = firstArray.Select(e => e / 2).ToArray();
                    jaggedMatrix[row + 1] = secondArray.Select(e => e / 2).ToArray();
                }
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] commandData = command.Split(" ");

                int rowIndex = int.Parse(commandData[1]);
                int colIndex = int.Parse(commandData[2]);
                int value = int.Parse(commandData[3]);

                bool isValidCell = rowIndex >= 0 &&
                        rowIndex < n &&
                        colIndex >= 0 &&
                        colIndex < jaggedMatrix[rowIndex].Length;

                if (!isValidCell)
                {
                    command = Console.ReadLine();
                    continue;
                }

                if (commandData[0] == "Add")
                {
                    jaggedMatrix[rowIndex][colIndex] += value;
                }
                else if (commandData[0] == "Subtract")
                {
                    jaggedMatrix[rowIndex][colIndex] -= value;
                }

                command = Console.ReadLine();
            }

            for (int row = 0; row < n; row++)
            {
                Console.WriteLine(string.Join(" ", jaggedMatrix[row]));
            }
        }
    }
}
