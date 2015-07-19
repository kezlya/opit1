namespace Pirozgok.Pieces
{
    public static class PiceO
    {
        public static Position GetFit(int[] c)
        {
            var result = new Position {Rotation = 0};

            for (int i = 0; i < c.Length; i++)
            {
                result.X = i;
                var cc = c[i];

                if (!c.IsRight(i)) break;

                if (cc != c.Right(i)) continue;
                return result;
            }

            result.X = 0;
            return result;
        }
    }
}