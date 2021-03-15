using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject.NUnitTest
{
    class TwoDimArrayMock
    {
        public static int[,] GetMock(int number)
        {
            int[,] result = new int[0, 0];

            switch (number)
            {
                case 1:
                    result = new int[5, 5]
                    {
                        { 12, 565, 768, 56, -545 },
                        { -434, -46, 563, 232, 64 },
                        { 3534, 797, 12, 46, 34 },
                        { 4, 5, 234, 67889, 24 },
                        { 667, -424, 24, 231, 13 }
                    };
                    break;
                case 2:
                    result = new int[1, 5]
                    {
                        { 12, 565, 768, 56, -545 }
                    };
                    break;
                case 3:
                    result = new int[5, 1]
                    {
                        { 12 },
                        { -434 },
                        { 3534 },
                        { 4 },
                        { 667 }
                    };
                    break;
                case 4:
                    result = new int[2, 3]
                    {
                        { 355, 242, 2442 },
                        { 13, -17, 11553 }
                    };
                    break;
                case 5:
                    result = new int[0, 0];
                    break;
                case 6:
                    result = null;
                    break;
                case 7:
                    result = new int[5, 5]
                    {
                        { 12, -434, 3534, 4, 667 },
                        { 565, -46, 797, 5, -424 },
                        { 768, 563, 12, 234, 24 },
                        { 56, 232, 46, 67889, 231 },
                        { -545, 64, 34, 24, 13 }
                    };
                    break;
                case 8:
                    result = new int[5, 1]
                    {
                        { 12 },
                        { 565 },
                        { 768 },
                        { 56 },
                        { -545 }
                    };
                    break;
                case 9:
                    result = new int[1, 5]
                    {
                        { 12, -434, 3534, 4, 667 }
                    };

                    break;
                case 10:
                    result = new int[3, 2]
                    {
                        { 355, 13 },
                        { 242, -17 },
                        { 2442, 11553 },
                    };
                    break;
            }

            return result;
        }
    }
}
