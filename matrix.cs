using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorSpace
{
    public class Matrix
    {//Класс: Матрица
        uint numOfRows, 
            numOfColumns;
        float[][] values;

        public Matrix()
        {
            numOfRows = numOfColumns = 0;
            values = null;
        }

        public static Matrix operator *(Matrix m1, Matrix m2)
        {
            Matrix result = new Matrix(m2.numOfRows, m1.numOfColumns, null);
            for (uint i = 0; i < result.numOfRows; i++)
                for (uint j = 0; j < result.numOfRows; j++)
                    for (uint k = 0; k < m1.numOfRows; k++)
                        result.values[i][j] += m1.values[i][k] * m2.values[k][i];
            return result;
        }

        public Matrix(uint r, uint c, float[][] vals)
        {
            numOfRows = r;
            numOfColumns = c;
            for (uint i = 0; i < r; i++)
                for (uint j = 0; j < c; j++)
                    values[i][j] = vals[i][j]; 
        }
    }
}
