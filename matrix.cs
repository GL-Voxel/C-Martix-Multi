using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorSpace
{
    public class Martix
    {//Класс: Матрица
        uint numOfStrings, 
            numOfColumns;
        float[][] values;

        public Matrix()
        {
            numOfStrings = numOfColumns = 0;
            values = null;
        }

        public static Martix operator *(Matrix m1, Matrix m2)
        {
            for(uint i = 0; i < m1.numberOfStrings; i++)
            return m1;
        }

        public Matrix(uint s, uint c, float[][] vals)
        {
            numOfStrings = s;
            numOfColumns = c;
            for (uint i = 0; i < s; i++)
                for (uint j = 0; j < c; j++)
                    values[i][j] = vals[i][j]; 
        }
    }
}
