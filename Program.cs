using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nhập kích thước của ma trận vuông:");
        int size = int.Parse(Console.ReadLine());

        double[,] matrix = new double[size, size];

        Console.WriteLine("Nhập các phần tử của ma trận:");

        // Nhập giá trị cho từng phần tử của ma trận
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.WriteLine($"Nhập giá trị cho phần tử [{i}, {j}]:");
                matrix[i, j] = double.Parse(Console.ReadLine());
            }
        }

        double diagonalSum = 0;

        // Tính tổng của các số trong đường chéo chính
        for (int i = 0; i < size; i++)
        {
            diagonalSum += matrix[i, i];
        }

        Console.WriteLine($"Tổng của các số trong đường chéo chính là {diagonalSum}.");
    }
}