using System;

namespace Lesson013_HT_Task3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter count of Columns: ");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter count of Rows: ");
            int columns = int.Parse(Console.ReadLine());
            MyMatrix matrix = new MyMatrix(rows, columns);
            int[,] matrix2 = new int[rows, columns];
            int[,] matrix1 = matrix.Fill(matrix2 ,rows, columns);
            matrix.Show(matrix1);
        }
    }
}
