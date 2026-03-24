//14.create 2d array from user and count duplicate element
using System;
class arrcount14
{
    static void Main()
    {
        Console.Write("Enter row size: ");
        int r = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter column size: ");
        int c = Convert.ToInt32(Console.ReadLine());

        int[,] arr = new int[r, c];

        // get element from user
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j <arr.GetLength(1); j++)
            {
                Console.Write("Enter arr[" + i + "," + j + "] : ");
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        //Display
        Console.WriteLine("\nArray Elements:");
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Console.Write("arr[" + i + "," + j + "] : " + arr[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("\nElement Count:");

        //  Find Duplicates & Count 
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                int count = 0;
                bool Printed = false;

             
                for (int x = 0; x <= i; x++)
                {
                    for (int y = 0; y < c; y++)
                    {
                        if (x == i && y == j)
                            break;

                        if (arr[i, j] == arr[x, y])
                        {
                            Printed = true;
                            break;
                        }
                    }
                    if (Printed)
                        break;
                }

                if (Printed)
                    continue;

                // Count t
                for (int x = 0; x < r; x++)
                {
                    for (int y = 0; y < c; y++)
                    {
                        if (arr[i, j] == arr[x, y])
                            count++;
                    }
                }

                Console.WriteLine("Element " + arr[i, j] + " is " + count + " times.");
            }
        }
    }
}
