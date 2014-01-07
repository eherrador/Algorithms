using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeakFinding
{
    class PeakFinder
    {
        public byte[] InitArray4PeakFinding(int arraySize)
        {
            Random rand = new Random();
            byte[] A = new byte[arraySize];
            rand.NextBytes(A);

            return A;
        }

        public int[,] InitMatrix4PeakFinding(int arraySize)
        {
            Random rand = new Random();
            int[,] M = new int[arraySize, arraySize];
            for (int i = 0; i < arraySize; i++)
                for (int j = 0; j < arraySize; j++)
                    M[i, j] = rand.Next(999);

            return M;
        }

        public int PeakFinding1DScanAllArray(byte[] A)
        {
            int peak = 0;

            if (A.Length > 1)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    if (i == 0)
                        peak = A[i] >= A[i + 1] ? A[i] : 0;
                    else if (i == A.Length - 1)
                        peak = A[i] >= A[i - 1] ? A[i] : 0;
                    else
                        peak = (A[i] >= A[i - 1] && A[i] >= A[i + 1]) ? A[i] : 0;

                    if (peak > 0)
                        break;
                }
            }
            else
                peak = A[0];

            return peak;
        }

        public int PeakFinding1DDivideAndConquer(byte[] A)
        {
            int peak;
            byte[] newArray;

            if (A.Length > 2)
            {
                if (A[(A.Length / 2) - 1] > A[A.Length / 2])
                {
                    newArray = new byte[A.Length / 2];
                    Array.Copy(A, newArray, A.Length / 2);

                    return PeakFinding1DDivideAndConquer(newArray);
                }
                else if (A[A.Length / 2] < A[(A.Length / 2) + 1])
                {
                    newArray = new byte[(A.Length / 2) + (A.Length % 2)];

                    for (int i = A.Length / 2, j = 0; i < A.Length; i++, j++)
                        newArray[j] = A[i];

                    return PeakFinding1DDivideAndConquer(newArray);
                }
                else
                {
                    peak = A[A.Length / 2];
                }
            }
            else
                peak = PeakFinding1DScanAllArray(A);

            return peak;
        }

        public int PeakFinding2DScanMatrixRTB(int[,] M, int matrixDimension)
        {
            int peak;



            peak = 1;
            return peak;
        }
    }
}
