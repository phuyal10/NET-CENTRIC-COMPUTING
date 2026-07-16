using System;

class Program
{
    static void Main()
    {
        int depth = 2;
        int rows = 3;
        int cols = 4;

        int[,,] cube = new int[depth, rows, cols];

        cube[0, 0, 0] = 5;
        cube[0, 1, 2] = 10;
        cube[1, 2, 3] = 15;

        for (int d = 0; d < depth; d++)
        {
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < cols; c++)
                {
                    Console.Write(cube[d, r, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}