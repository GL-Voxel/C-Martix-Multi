using System;

public class Matrix
{//Класс-шаблон: Матрица.
    private uint numOfRows, //Количество строк в матрице
        numOfColumns; //Количество столбцов в матрице
    private double[,] values; //Значения элементов матрицы. Тип значения может быть разный

    public Matrix()
    {
        numOfRows = numOfColumns = 0;
        values = null;
    }

    public Matrix(uint r, uint c, double[ , ] vals)
    {
        numOfRows = r;
        numOfColumns = c;
        values = vals;
    }
    public string toString()
    {//Метод, который переводит матрицуу в стринг
        string matrixTable = null;
        for (uint i = 0; i < numOfRows; i++)
        {
            for (uint j = 0; j < numOfColumns; j++)
                matrixTable += Convert.ToString(values[i, j]);
            matrixTable += "\n";
        }
        return matrixTable;
    }

    public double[,] GetValues()
    {
        return values;
    }

    public static Matrix operator *(Matrix m1, Matrix m2)
    {//Перегрузка умножения для двух матриц
        Matrix result = new Matrix(m2.numOfRows, m1.numOfColumns, new double[m2.numOfRows, m1.numOfColumns]);
        for (uint i = 0; i < result.numOfRows; i++)
            for (uint j = 0; j < result.numOfRows; j++)
                for (uint k = 0; k < m1.numOfRows; k++)
                    result.values[i, j] += m1.values[i, k] * m2.values[k, i];
        return result;
    }
}
