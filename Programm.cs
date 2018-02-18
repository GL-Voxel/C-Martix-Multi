using System;
using System.IO;
using static Matrix;

class App
{
    void MatrixToFile(string name, Matrix m)
    {//Записывает матрицу в файл
        File.Create(name);
        StreamWriter matrixFile = new StreamWriter(name);
        matrixFile.Write(m);
    }

    Matrix MatrixFromFile(string name)
    {
        return new StreamReader(name).Read();
    }

    static void Main(string[] args)
    {
        Matrix[] matricies = new Matrix[2];
        for (uint i = 0; i < 2; i++)
        {//В этом цикле происходит ввод и вывод матриц.
            uint rows = 0,
            columns = 0;
            StreamWriter w = new StreamWriter("matrix.txt");
            Console.Write("Сколько строк будет в матрице #" + (i + 1) + "? ");
            rows = Convert.ToUInt32(Console.ReadLine());
            Console.Write("Сколько столбцов будет в матрице #" + (i + 1) + "? ");
            columns = Convert.ToUInt32(Console.ReadLine());
            double[,] values = new double[rows, columns];
            for (uint j = 0; j < rows; j++)
                for (uint k = 0; k < columns; k++)
                {
                    Console.WriteLine("Введите значение [" + (j + 1) + "," + (k + 1) + "]");
                    values[j, k] = Convert.ToDouble(Console.Read());
                }
            matricies[i] = new Matrix(rows, columns, values);
            Console.Write(matricies[i]);
            w.Write(matricies[i]);
        }
        Console.Write(matricies[0] * matricies[1]); //Тестируем умножение двух матриц.
    }
}
