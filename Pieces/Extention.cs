using System;

namespace Pirozgok.Pieces
{
    public static class Extention
    {
        public static bool IsLeft(this int[] columns, int i)
        {
            return (i - 1 >= 0 && i - 1 < columns.Length);
        }
        public static bool IsLeftLeft(this int[] columns, int i)
        {
            return (i - 2 >= 0 && i - 2 < columns.Length);
        }

        public static int Left(this int[] columns, int i)
        {
            return columns[i - 1];
        }
        public static int LeftLeft(this int[] columns, int i)
        {
            return columns[i - 2];
        }

        public static bool IsRight(this int[] columns, int i)
        {
            return (i + 1 >= 0 && i + 1 < columns.Length);
        }
        public static bool IsRightRight(this int[] columns, int i)
        {
            return (i + 2 >= 0 && i + 2 < columns.Length);
        }
        public static bool IsRightRightRight(this int[] columns, int i)
        {
            return (i + 3 >= 0 && i + 3 < columns.Length);
        }
        public static bool IsRightRightRightRight(this int[] columns, int i)
        {
            return (i + 4 >= 0 && i + 4 < columns.Length);
        }

        public static int Right(this int[] columns, int i)
        {
            return columns[i + 1];
        }
        public static int RightRight(this int[] columns, int i)
        {
            return columns[i + 2];
        }
        public static int RightRightRight(this int[] columns, int i)
        {
            return columns[i + 3];
        }
        public static int RightRightRightRight(this int[] columns, int i)
        {
            return columns[i + 4];
        }

        public static int[] GetColomnsAfter(this int[] columns, int i, int rotation, PieceType pieceType)
        {
            int[] columnsAfter = new int[columns.Length];
            Array.Copy(columns, columnsAfter, columns.Length);
            switch (pieceType)
            {
                case PieceType.I:
                    switch (rotation)
                    {
                        case 0:
                            columnsAfter[i] = columnsAfter[i] + 1;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 1;
                            columnsAfter[i + 2] = columnsAfter[i + 2] + 1;
                            columnsAfter[i + 3] = columnsAfter[i + 3] + 1;
                            break;
                        case 1:
                            columnsAfter[i] = columnsAfter[i] + 4;
                            break;
                            
                    }
                    break;
                case PieceType.J:
                    switch (rotation)
                    {
                        case 0:
                            columnsAfter[i] = columnsAfter[i] + 2;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 1;
                            columnsAfter[i + 2] = columnsAfter[i + 2] + 1;
                            break;
                        case 1:
                            columnsAfter[i] = columnsAfter[i] + 3;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 3;
                            break;
                        case 2:
                            columnsAfter[i] = columnsAfter[i] + 2;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                            columnsAfter[i + 2] = columnsAfter[i + 2] + 2;
                            break;
                        case 3:
                            columnsAfter[i] = columnsAfter[i] + 1;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 3;
                            break;
                    }
                    break;
                case PieceType.L:
                     switch (rotation)
                    {
                        case 0:
                            columnsAfter[i] = columnsAfter[i] + 1;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 1;
                            columnsAfter[i + 2] = columnsAfter[i + 2] + 2;
                            break;
                        case 1:
                            columnsAfter[i] = columnsAfter[i] + 3;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 1;
                            break;
                        case 2:
                            columnsAfter[i] = columnsAfter[i] + 2;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                            columnsAfter[i + 2] = columnsAfter[i + 2] + 2;
                            break;
                        case 3:
                            columnsAfter[i] = columnsAfter[i] + 3;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 3;
                            break;
                    }
                    break;
                case PieceType.O:
                    columnsAfter[i] = columnsAfter[i] + 2;
                    columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                    break;
                case PieceType.S:
                     switch (rotation)
                    {
                        case 0:
                            columnsAfter[i] = columnsAfter[i] + 1;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                            columnsAfter[i + 2] = columnsAfter[i + 2] + 2;
                            break;
                        case 1:
                            columnsAfter[i] = columnsAfter[i] + 3;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                            break;
                    }
                    break;
                case PieceType.T:
                     switch (rotation)
                    {
                        case 0:
                            columnsAfter[i] = columnsAfter[i] + 1;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                            columnsAfter[i + 2] = columnsAfter[i + 2] + 1;
                            break;
                        case 1:
                            columnsAfter[i] = columnsAfter[i] + 3;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                            break;
                        case 2:
                            columnsAfter[i] = columnsAfter[i] + 2;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                            columnsAfter[i + 2] = columnsAfter[i + 2] + 2;
                            break;
                        case 3:
                            columnsAfter[i] = columnsAfter[i] + 2;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 3;
                            break;
                    }
                    break;
                case PieceType.Z:
                     switch (rotation)
                    {
                        case 0:
                            columnsAfter[i] = columnsAfter[i] + 2;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                            columnsAfter[i + 2] = columnsAfter[i + 2] + 1;
                            break;
                        case 1:
                            columnsAfter[i] = columnsAfter[i] + 2;
                            columnsAfter[i + 1] = columnsAfter[i + 1] + 3;
                            break;
                    }
                    break;
            }
            return columnsAfter;
        }
    }
}