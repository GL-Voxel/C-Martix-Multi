uusing System;
using static Matrix;

class App
{
    static void Main(string[] args)
    {
        Matrix[] matricies = new Matrix[2];
        for (uint i = 0; i < 2; i++)
        {//В этом цикле происходит ввод и вывод матриц.
            UInt32 rows = 0,
            columns = 0;
            Console.WriteLine("Сколько строк будет в матрице #" + (i + 1) + "? ");
            rows = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Сколько столбцов будет в матрице #" + (i + 1) + "? ");
            columns = Convert.ToUInt32(Console.ReadLine());
            double[,] values = new double[rows, columns];
            for (UInt32 j = 0; j < rows; j++)
                for (UInt32 k = 0; k < columns; k++)
                {
                    Console.WriteLine("Введите значение [" + (j + 1) + " " + (k + 1) + "]");
                    values[j, k] = Convert.ToDouble(Console.ReadLine());
                }
            matricies[i] = new Matrix(rows, columns, new double[rows, columns]);
            Console.Write(matricies[i]);
        }
        Console.Write(matricies[0] * matricies[1]); //Тестируем умножение двух матриц.
    }
}
