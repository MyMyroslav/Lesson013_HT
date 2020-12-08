using System;
namespace Lesson013_HT_Task3
{
    public class MyMatrix
    {
        public int rows;
        public int columns;
        public MyMatrix()
        {
        }
        public MyMatrix(int rows, int columns)
        {
            this.rows = rows;
            this.columns = columns;
        }
        //public int[,] Create(int rows, int columns)
        //{
        //    int[,] array = new int[rows, columns];
        //    return array;
        //}
        public int[,] Fill(int[,] array, int rows, int columns)
        {
            Random random = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array[i, j] = random.Next(100);
                }
            }

            return array;
        }
        public void Show(int [,] array)
        {
            for(int i =0; i < array.GetLength(0); i++, Console.WriteLine()) {
                
                for(int j=0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine(String.Format("{0, 5}", array[i,j]));
                }
            }
            Console.WriteLine("-----------------------------------------");
        }
    }
}
