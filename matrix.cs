using System;
using System.IO;

public class Matrix
{//Класс: Матрица.
    private double[][] values; //Значения элементов матрицы. Тип значения на самом деле может быть разный

    public Matrix()
    {
        values = null;
    }

    public Matrix(double[][] vals)
    {//Конструктор, который получает просто значения матрицы на прямую
        values = vals;
    }

    public Matrix(string name)
    {//Достает матрицу из файла
        string[] stringMartix = File.ReadAllLines(name); //Считываем строки из файла в массив строк.
        values = new double[stringMartix.Length][];
        for (uint i = 0; i < stringMartix.Length; i++)
            values[i] = new double[stringMartix[1].Length];
        for (uint i = 0; i < stringMartix[1].Length; i++)
        {
            string [] splitStrings = stringMartix[i].Split(' '); //Временный массив, которые делит одну строку на подстроки.
            values[i] = new double[stringMartix.Length];
            for (uint j = 0; j < stringMartix.Length; j++) //Каждую подстроку переводим в даубл через цикл.
                values[i][j] = Convert.ToDouble(splitStrings[j]);
        }
    }

    override
    public string ToString()
    {//Метод, который переводит матрицу в стринг
        string matrixTable = null;
        for(uint i = 0; i < values.Length; i++)
        {
            for (uint j = 0; j < values[1].Length; j++)
            {
                matrixTable += (values[i][j]);
                matrixTable += " ";
            }
            matrixTable += "\n";
        }
        return matrixTable;
    }

    public static Matrix operator *(Matrix m1, Matrix m2)
    {//Перегрузка умножения для двух матриц
        Matrix result = new Matrix(new double[m2.values.Length][]);
        for (uint i = 0; i < m2.values.Length; i++)
            result.values[i] = new double[m1.values[1].Length];
        for (uint i = 0; i < result.values[1].Length; i++)
            for (uint j = 0; j < result.values[1].Length; j++)
                for (uint k = 0; k < m1.values[1].Length; k++)
                    result.values[i][j] += m1.values[i][k] * m2.values[k][i];
        return result;
    }
}
