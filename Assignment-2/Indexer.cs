using System;

class Cube
{
    private int[,,] data;

    public Cube(int depth, int rows, int cols)
    {
        data = new int[depth, rows, cols];
    }

    public int this[int d, int r, int c]
    {
        get { return data[d, r, c]; }
        set { data[d, r, c] = value; }
    }
}

class Program
{
    static void Main()
    {
        Cube myCube = new Cube(2, 3, 4);

        myCube[0, 0, 0] = 5;
        myCube[0, 1, 2] = 10;
        myCube[1, 2, 3] = 15;

        for (int d = 0; d < 2; d++)
        {
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(myCube[d, r, c] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
