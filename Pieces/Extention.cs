namespace Pirozgok.Pieces
{
    public static class Extention
    {
        public static bool IsLeftWall(this int[] columns, int i)
        {
            return (i == 0);
        }
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

        public static bool IsRightWall(this int[] columns, int i)
        {
            return (i == columns.Length - 1);
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
    }
}