using System;

public class Matrix
{//Класс: Матрица
    private uint numOfRows, //Количество строк в матрице
        numOfColumns; //Количество столбцов в матрице
    private double[,] values; //Значения элементов матрицы

    public Matrix()
    {
        numOfRows = numOfColumns = 0;
        values = null;
    }

    public Matrix(uint r, uint c, double[,] vals)
    {
        numOfRows = r;
        numOfColumns = c;
        for (uint i = 0; i < r; i++)
            for (uint j = 0; j < c; j++)
                values[i, j] = vals[i, j];
    }

    public double[,] GetValues()
    {
        return values;
    }

    public static Matrix operator *(Matrix m1, Matrix m2)
    {//Перегрузка умножения для двух матриц
        Matrix result = new Matrix(m2.numOfRows, m1.numOfColumns, null);
        for (uint i = 0; i < result.numOfRows; i++)
            for (uint j = 0; j < result.numOfRows; j++)
                for (uint k = 0; k < m1.numOfRows; k++)
                    result.values[i, j] += m1.values[i, k] * m2.values[k, i];
        return result;
    }

}
