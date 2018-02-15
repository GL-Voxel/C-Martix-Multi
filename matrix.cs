using System;

public class Matrix<Type>
{//Класс-шаблон: Матрица.
    private uint numOfRows, //Количество строк в матрице
        numOfColumns; //Количество столбцов в матрице
    private Type[,] values; //Значения элементов матрицы. Тип значения может быть разный

    public Matrix()
    {
        numOfRows = numOfColumns = 0;
        values = null;
    }

    public Matrix(uint r, uint c, Type[,] vals)
    {
        numOfRows = r;
        numOfColumns = c;
        values = new Type[r, c];
        for (uint i = 0; i < numOfRows; i++)
            for (uint j = 0; j < numOfColumns; j++)
                values[i, j] = vals[i, j];
    }

    public Type[,] GetValues()
    {
        return values;
    }

    public static Matrix<Type> operator *(Matrix<Type> m1, Matrix<Type> m2)
    {//Перегрузка умножения для двух матриц
        Matrix<Type> result = new Matrix<Type>(m2.numOfRows, m1.numOfColumns, null);
        for (uint i = 0; i < result.numOfRows; i++)
            for (uint j = 0; j < result.numOfRows; j++)
                for (uint k = 0; k < m1.numOfRows; k++)
                    result.values[i, j] += m1.values[i, k] * m2.values[k, i];
        return result;
    }
}
