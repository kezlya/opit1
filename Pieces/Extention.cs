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
                            if (columns.IsRightRightRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 1;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 1;
                                columnsAfter[i + 2] = columnsAfter[i + 2] + 1;
                                columnsAfter[i + 3] = columnsAfter[i + 3] + 1;
                            }
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
                            if (columns.IsRightRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 2;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 1;
                                columnsAfter[i + 2] = columnsAfter[i + 2] + 1;
                            }
                            break;
                        case 1:
                            if (columns.IsRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 3;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 3;
                            }
                            break;
                        case 2:
                            if (columns.IsRightRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 2;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                                columnsAfter[i + 2] = columnsAfter[i + 2] + 2;
                            }
                            break;
                        case 3:
                            if (columns.IsRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 1;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 3;
                            }
                            break;
                    }
                    break;
                case PieceType.L:
                    switch (rotation)
                    {
                        case 0:
                            if (columns.IsRightRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 1;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 1;
                                columnsAfter[i + 2] = columnsAfter[i + 2] + 2;
                            }
                            break;
                        case 1:
                            if (columns.IsRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 3;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 1;
                            }
                            break;
                        case 2:
                            if (columns.IsRightRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 2;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                                columnsAfter[i + 2] = columnsAfter[i + 2] + 2;
                            }
                            break;
                        case 3:
                            if (columns.IsRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 3;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 3;
                            }
                            break;
                    }
                    break;
                case PieceType.O:
                    if (columns.IsRight(i))
                    {
                        columnsAfter[i] = columnsAfter[i] + 2;
                        columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                    }
                    break;
                case PieceType.S:
                    switch (rotation)
                    {
                        case 0:
                            if (columns.IsRightRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 1;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                                columnsAfter[i + 2] = columnsAfter[i + 2] + 2;
                            }
                            break;
                        case 1:
                            if (columns.IsRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 3;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                            }
                            break;
                    }
                    break;
                case PieceType.T:
                    switch (rotation)
                    {
                        case 0:
                            if (columns.IsRightRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 1;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                                columnsAfter[i + 2] = columnsAfter[i + 2] + 1;
                            }
                            break;
                        case 1:
                            if (columns.IsRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 3;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                            }
                            break;
                        case 2:
                            if (columns.IsRightRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 2;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                                columnsAfter[i + 2] = columnsAfter[i + 2] + 2;
                            }
                            break;
                        case 3:
                            if (columns.IsRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 2;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 3;
                            }
                            break;
                    }
                    break;
                case PieceType.Z:
                    switch (rotation)
                    {
                        case 0:
                            if (columns.IsRightRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 2;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 2;
                                columnsAfter[i + 2] = columnsAfter[i + 2] + 1;
                            }
                            break;
                        case 1:
                            if (columns.IsRight(i))
                            {
                                columnsAfter[i] = columnsAfter[i] + 2;
                                columnsAfter[i + 1] = columnsAfter[i + 1] + 3;
                            }
                            break;
                    }
                    break;
            }
            return columnsAfter;
        }
        public static int[] GetColomnsAfterWithHoles(this int[] c, int i, int rotation, PieceType pieceType)
        {
            int[] columnsAfter = new int[c.Length];
            Array.Copy(c, columnsAfter, c.Length);
            switch (pieceType)
            {
                case PieceType.I:
                    switch (rotation)
                    {
                        // ####
                        case 0:
                            if (c.IsRightRightRight(i))
                            {
                                // Piece 4 long
                                int pick = c[i] < c.Right(i)
                                    ? (c.Right(i) < c.RightRight(i)
                                        ? (c.RightRight(i) < c.RightRightRight(i)
                                            ? c.RightRightRight(i)
                                            : c.RightRight(i))
                                        : c.Right(i))
                                    : c[i];

                                columnsAfter[i] = pick + 1;
                                columnsAfter[i + 1] = pick + 1;
                                columnsAfter[i + 2] = pick + 1;
                                columnsAfter[i + 3] = pick + 1;
                            }
                            break;

                        // #
                        // #
                        // #
                        // #
                        case 1:
                            columnsAfter[i] = c[i] + 4;
                            break;
                    }
                    break;
                case PieceType.J:
                    switch (rotation)
                    {
                        // 
                        // #
                        // ###
                        case 0:
                            if (c.IsRightRight(i))
                            {
                                // Piece 3 long
                                int pick = c[i] < c.Right(i)
                                    ? (c.Right(i) < c.RightRight(i)
                                        ? c.RightRight(i)
                                        : c.Right(i))
                                    : c[i];

                                columnsAfter[i] = pick + 2;
                                columnsAfter[i + 1] = pick + 1;
                                columnsAfter[i + 2] = pick + 1;
                            }
                            break;

                        // ##
                        // #
                        // #
                        case 1:
                            if (c.IsRight(i))
                            {
                                // Piece 2 long
                                int pick = c[i] < c.Right(i) ? c.Right(i) : c[i];

                                columnsAfter[i] = pick + 3;
                                columnsAfter[i + 1] = pick + 3;
                            }
                            break;

                        // 
                        // ###
                        //   #
                        case 2:
                            if (c.IsRightRight(i))
                            {
                                // Piece 3 long
                                int pick = c[i] < c.Right(i)
                                    ? (c.Right(i) < c.RightRight(i)
                                        ? c.RightRight(i)
                                        : c.Right(i))
                                    : c[i];

                                columnsAfter[i] = pick + 2;
                                columnsAfter[i + 1] = pick + 2;
                                columnsAfter[i + 2] = pick + 2;
                            }
                            break;

                        //  #
                        //  #
                        // ##
                        case 3:
                            if (c.IsRight(i))
                            {
                                // Piece 2 long
                                int pick = c[i] < c.Right(i) ? c.Right(i) : c[i];

                                columnsAfter[i] = pick + 1;
                                columnsAfter[i + 1] = pick + 3;
                            }
                            break;
                    }
                    break;
                case PieceType.L:
                    switch (rotation)
                    {
                        case 0:
                            if (c.IsRightRight(i))
                            {
                                // Piece 3 long
                                int pick = c[i] < c.Right(i)
                                    ? (c.Right(i) < c.RightRight(i)
                                        ? c.RightRight(i)
                                        : c.Right(i))
                                    : c[i];

                                columnsAfter[i] = pick + 1;
                                columnsAfter[i + 1] = pick + 1;
                                columnsAfter[i + 2] = pick + 2;
                            }
                            break;
                        case 1:
                            if (c.IsRight(i))
                            {
                                // Piece 2 long
                                int pick = c[i] < c.Right(i) ? c.Right(i) : c[i];

                                columnsAfter[i] = pick + 3;
                                columnsAfter[i + 1] = pick + 1;
                            }
                            break;
                        case 2:
                            if (c.IsRightRight(i))
                            {
                                // Piece 3 long
                                int pick = c[i] < c.Right(i)
                                    ? (c.Right(i) < c.RightRight(i)
                                        ? c.RightRight(i)
                                        : c.Right(i))
                                    : c[i];

                                columnsAfter[i] = pick + 2;
                                columnsAfter[i + 1] = pick + 2;
                                columnsAfter[i + 2] = pick + 2;
                            }
                            break;
                        case 3:
                            if (c.IsRight(i))
                            {
                                // Piece 2 long
                                int pick = c[i] < c.Right(i) ? c.Right(i) : c[i];

                                columnsAfter[i] = pick + 3;
                                columnsAfter[i + 1] = pick + 3;
                            }
                            break;
                    }
                    break;
                case PieceType.O:
                    if (c.IsRight(i))
                    {
                        // Piece 2 long
                        int pick = c[i] < c.Right(i) ? c.Right(i) : c[i];

                        columnsAfter[i] = pick + 2;
                        columnsAfter[i + 1] = pick + 2;
                    }
                    break;
                case PieceType.S:
                    switch (rotation)
                    {
                        case 0:
                            if (c.IsRightRight(i))
                            {
                                // Piece 3 long
                                int pick = c[i] < c.Right(i)
                                    ? (c.Right(i) < c.RightRight(i)
                                        ? c.RightRight(i)
                                        : c.Right(i))
                                    : c[i];

                                columnsAfter[i] = pick + 1;
                                columnsAfter[i + 1] = pick + 2;
                                columnsAfter[i + 2] = pick + 2;
                            }
                            break;
                        case 1:
                            if (c.IsRight(i))
                            {
                                // Piece 2 long
                                int pick = c[i] < c.Right(i) ? c.Right(i) : c[i];

                                columnsAfter[i] = pick + 3;
                                columnsAfter[i + 1] = pick + 2;
                            }
                            break;
                    }
                    break;
                case PieceType.T:
                    switch (rotation)
                    {
                        case 0:
                            if (c.IsRightRight(i))
                            {
                                // Piece 3 long
                                int pick = c[i] < c.Right(i)
                                    ? (c.Right(i) < c.RightRight(i)
                                        ? c.RightRight(i)
                                        : c.Right(i))
                                    : c[i];

                                columnsAfter[i] = pick + 1;
                                columnsAfter[i + 1] = pick + 2;
                                columnsAfter[i + 2] = pick + 1;
                            }
                            break;
                        case 1:
                            if (c.IsRight(i))
                            {
                                // Piece 2 long
                                int pick = c[i] < c.Right(i) ? c.Right(i) : c[i];

                                columnsAfter[i] = pick + 3;
                                columnsAfter[i + 1] = pick + 2;
                            }
                            break;
                        case 2:
                            if (c.IsRightRight(i))
                            {
                                // Piece 3 long
                                int pick = c[i] < c.Right(i)
                                    ? (c.Right(i) < c.RightRight(i)
                                        ? c.RightRight(i)
                                        : c.Right(i))
                                    : c[i];

                                columnsAfter[i] = pick + 2;
                                columnsAfter[i + 1] = pick + 2;
                                columnsAfter[i + 2] = pick + 2;
                            }
                            break;
                        case 3:
                            if (c.IsRight(i))
                            {
                                // Piece 2 long
                                int pick = c[i] < c.Right(i) ? c.Right(i) : c[i];

                                columnsAfter[i] = pick + 2;
                                columnsAfter[i + 1] = pick + 3;
                            }
                            break;
                    }
                    break;
                case PieceType.Z:
                    switch (rotation)
                    {
                        case 0:
                            if (c.IsRightRight(i))
                            {
                                // Piece 3 long
                                int pick = c[i] < c.Right(i)
                                    ? (c.Right(i) < c.RightRight(i)
                                        ? c.RightRight(i)
                                        : c.Right(i))
                                    : c[i];

                                columnsAfter[i] = pick + 2;
                                columnsAfter[i + 1] = pick + 2;
                                columnsAfter[i + 2] = pick + 1;
                            }
                            break;
                        case 1:
                            if (c.IsRight(i))
                            {
                                // Piece 2 long
                                int pick = c[i] < c.Right(i) ? c.Right(i) : c[i];

                                columnsAfter[i] = pick + 2;
                                columnsAfter[i + 1] = pick + 3;
                            }
                            break;
                    }
                    break;
            }
            return columnsAfter;
        }

        public static int[] GetColomnsAfterWithHoles2(this int[] columns, int i, int rotation, PieceType pieceType)
        {
            int[] columnsAfter = new int[columns.Length];
            Array.Copy(columns, columnsAfter, columns.Length);
            switch (pieceType)
            {
                case PieceType.I:
                    switch (rotation)
                    {
                        case 0:
                            if (columns.IsRightRightRight(i))
                            {
                                var pick = columns[i];
                                if (pick < columns[i + 1]) pick = columns[i + 1];
                                if (pick < columns[i + 2]) pick = columns[i + 2];
                                if (pick < columns[i + 3]) pick = columns[i + 3];

                                columnsAfter[i] = pick + 1;
                                columnsAfter[i + 1] = pick + 1;
                                columnsAfter[i + 2] = pick + 1;
                                columnsAfter[i + 3] = pick + 1;
                            }
                            break;
                        case 1:
                            columnsAfter[i] = columns[i] + 4;
                            break;
                    }
                    break;
                case PieceType.J:
                    switch (rotation)
                    {
                        case 0:
                            if (columns.IsRightRight(i))
                            {
                                var pick = columns[i];
                                if (pick < columns[i + 1]) pick = columns[i + 1];
                                if (pick < columns[i + 2]) pick = columns[i + 2];

                                columnsAfter[i] = pick + 2;
                                columnsAfter[i + 1] = pick + 1;
                                columnsAfter[i + 2] = pick + 1;
                            }
                            break;
                        case 1:
                            if (columns.IsRight(i))
                            {
                                if (columns[i + 1] >= columns[i] + 2)
                                {
                                    columnsAfter[i] = columns[i+1] + 1;
                                    columnsAfter[i + 1] = columns[i + 1] + 1;
                                }
                                else
                                {
                                    columnsAfter[i] = columns[i] + 3;
                                    columnsAfter[i + 1] = columns[i] + 3;
                                }
                            }
                            break;
                        case 2:
                            if (columns.IsRightRight(i))
                            {
                                var pick = columns[i];
                                if (pick < columns[i + 1]) pick = columns[i + 1];
                                if (pick < columns[i + 2]) pick = columns[i + 2];

                                if (pick == columns[i+2])
                                {
                                    columnsAfter[i] = pick + 2;
                                    columnsAfter[i + 1] = pick + 2;
                                    columnsAfter[i + 2] = pick + 2;
                                }
                                else
                                {
                                    columnsAfter[i] = pick + 1;
                                    columnsAfter[i + 1] = pick + 1;
                                    columnsAfter[i + 2] = pick + 1;
                                }
                            }
                            break;
                        case 3:
                            if (columns.IsRight(i))
                            {
                                var pick = columns[i];
                                if (pick < columns[i + 1]) pick = columns[i + 1];

                                columnsAfter[i] = pick + 1;
                                columnsAfter[i + 1] = pick + 3;
                            }
                            break;
                    }
                    break;
                case PieceType.L:
                    switch (rotation)
                    {
                        case 0:
                            if (columns.IsRightRight(i))
                            {
                                var pick = columns[i];
                                if (pick < columns[i + 1]) pick = columns[i + 1];
                                if (pick < columns[i + 2]) pick = columns[i + 2];

                                columnsAfter[i] = pick + 1;
                                columnsAfter[i + 1] = pick + 1;
                                columnsAfter[i + 2] = pick + 2;
                            }
                            break;
                        case 1:
                            if (columns.IsRight(i))
                            {
                                var pick = columns[i];
                                if (pick < columns[i + 1]) pick = columns[i + 1];

                                columnsAfter[i] = pick + 3;
                                columnsAfter[i + 1] = pick + 1;
                            }
                            break;
                        case 2:
                            if (columns.IsRightRight(i))
                            {
                                var pick = columns[i];
                                if (pick < columns[i + 1]) pick = columns[i + 1];
                                if (pick < columns[i + 2]) pick = columns[i + 2];

                                if (pick == columns[i])
                                {
                                    columnsAfter[i] = pick + 2;
                                    columnsAfter[i + 1] = pick + 2;
                                    columnsAfter[i + 2] = pick + 2;
                                }
                                else
                                {
                                    columnsAfter[i] = pick + 1;
                                    columnsAfter[i + 1] = pick + 1;
                                    columnsAfter[i + 2] = pick + 1;
                                }
                            }
                            break;
                        case 3:
                            if (columns.IsRight(i))
                            {
                                if (columns[i] >= columns[i+1] + 2)
                                {
                                    columnsAfter[i] = columns[i] + 1;
                                    columnsAfter[i + 1] = columns[i] + 1;
                                }
                                else
                                {
                                    columnsAfter[i] = columns[i+1] + 3;
                                    columnsAfter[i + 1] = columns[i+1] + 3;
                                }
                            }
                            break;
                    }
                    break;
                case PieceType.O:
                    if (columns.IsRight(i))
                    {
                        var pick = columns[i];
                        if (pick < columns[i + 1]) pick = columns[i + 1];

                        columnsAfter[i] = pick + 2;
                        columnsAfter[i + 1] = pick + 2;
                    }
                    break;
                case PieceType.S:
                    switch (rotation)
                    {
                        case 0:
                            if (columns.IsRightRight(i))
                            {
                                var pick = columns[i];
                                if (pick < columns[i + 1]) pick = columns[i + 1];
                                if (pick < columns[i + 2]) pick = columns[i + 2];

                                if (pick == columns[i] || pick == columns[i+1])
                                {
                                    columnsAfter[i] = pick + 1;
                                    columnsAfter[i + 1] = pick + 2;
                                    columnsAfter[i + 2] = pick + 2;
                                }
                                else
                                {
                                    columnsAfter[i] = pick;
                                    columnsAfter[i + 1] = pick + 1;
                                    columnsAfter[i + 2] = pick + 1;
                                }
                            }
                            break;
                        case 1:
                            if (columns.IsRight(i))
                            {
                                var pick = columns[i];
                                if (pick < columns[i + 1]) pick = columns[i + 1];

                                if (pick == columns[i+1])
                                {
                                    columnsAfter[i] = pick + 3;
                                    columnsAfter[i + 1] = pick + 2;
                                }
                                else
                                {
                                    columnsAfter[i] = pick + 2;
                                    columnsAfter[i + 1] = pick + 1;
                                }
                            }
                            break;
                    }
                    break;
                case PieceType.T:
                    switch (rotation)
                    {
                        case 0:
                            if (columns.IsRightRight(i))
                            {
                                var pick = columns[i];
                                if (pick < columns[i + 1]) pick = columns[i + 1];
                                if (pick < columns[i + 2]) pick = columns[i + 2];

                                columnsAfter[i] = pick + 1;
                                columnsAfter[i + 1] = pick + 2;
                                columnsAfter[i + 2] = pick + 1;
                            }
                            break;
                        case 1:
                            if (columns.IsRight(i))
                            {
                                var pick = columns[i];
                                if (pick < columns[i + 1]) pick = columns[i + 1];

                                if (pick == columns[i])
                                {
                                    columnsAfter[i] = pick + 3;
                                    columnsAfter[i + 1] = pick + 2;
                                }
                                else
                                {
                                    columnsAfter[i] = pick + 2;
                                    columnsAfter[i + 1] = pick + 1;
                                }
                            }
                            break;
                        case 2:
                            if (columns.IsRightRight(i))
                            {
                                var pick = columns[i];
                                if (pick < columns[i + 1]) pick = columns[i + 1];
                                if (pick < columns[i + 2]) pick = columns[i + 2];

                                if (pick == columns[i+1])
                                {
                                    columnsAfter[i] = pick + 2;
                                    columnsAfter[i + 1] = pick + 2;
                                    columnsAfter[i + 2] = pick + 2;
                                }
                                else
                                {
                                    columnsAfter[i] = pick + 1;
                                    columnsAfter[i + 1] = pick + 1;
                                    columnsAfter[i + 2] = pick + 1;
                                }
                            }
                            break;
                        case 3:
                            if (columns.IsRight(i))
                            {
                                var pick = columns[i];
                                if (pick < columns[i + 1]) pick = columns[i + 1];

                                if (pick == columns[i+1])
                                {
                                    columnsAfter[i] = pick + 2;
                                    columnsAfter[i + 1] = pick + 3;
                                    
                                }
                                else
                                {
                                    columnsAfter[i] = pick + 1;
                                    columnsAfter[i + 1] = pick + 2;
                                }
                            }
                            break;
                    }
                    break;
                case PieceType.Z:
                    switch (rotation)
                    {
                        case 0:
                            if (columns.IsRightRight(i))
                            {
                                var pick = columns[i];
                                if (pick < columns[i + 1]) pick = columns[i + 1];
                                if (pick < columns[i + 2]) pick = columns[i + 2];

                                if (pick == columns[i + 1] || pick == columns[i + 2])
                                {
                                    columnsAfter[i] = pick + 2;
                                    columnsAfter[i + 1] = pick + 2;
                                    columnsAfter[i + 2] = pick + 1;
                                }
                                else
                                {
                                    columnsAfter[i] = pick + 1;
                                    columnsAfter[i + 1] = pick + 1;
                                    columnsAfter[i + 2] = pick;
                                }
                            }
                            break;
                        case 1:
                            if (columns.IsRight(i))
                            {
                                var pick = columns[i];
                                if (pick < columns[i + 1]) pick = columns[i + 1];

                                if (pick == columns[i])
                                {
                                    columnsAfter[i] = pick + 2;
                                    columnsAfter[i + 1] = pick + 3;
                                }
                                else
                                {
                                    columnsAfter[i] = pick + 1;
                                    columnsAfter[i + 1] = pick + 2;
                                }
                            }
                            break;
                    }
                    break;
            }
            return columnsAfter;
        }

    }
}

//int pick = c[i] < c.Right(i)
//                                    ? (c.Right(i) < c.RightRight(i)
//                                        ? (c.RightRight(i) < c.RightRightRight(i)
//                                            ? c.RightRightRight(i)
//                                            : c.RightRight(i))
//                                        : c.Right(i))
//                                    : c[i];