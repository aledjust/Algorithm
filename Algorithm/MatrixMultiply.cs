using System;
using System.Linq;
using System.Windows.Media;

namespace Algorithm
{
    public class MatrixMultiply
    {
        //Base of Matriks A x B , which size column A must same with  size row B
        public static Matrix MatrixMultiplyAuto(Matrix ma, Matrix mb)
        {
            return Matrix.Multiply(ma, mb);
        }

        public static Matrix MatrixMultiplyMan(Matrix ma, Matrix mb)
        {
            return ma * mb;
        }
    }
}
