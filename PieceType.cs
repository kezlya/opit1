using System.Collections.Generic;

namespace Pirozgok
{
    public enum PieceType : byte
    {
        None,
        I,
        J,
        L,
        O,
        S,
        T,
        Z
    }

    public interface IPieceTypeSettings
    {
        Position GetFit(int[] columns);
        //TODO: List<Position> GetFits(int[] columns);
    }


    //TODO: look for lowest y and select position


    public class PiceI : IPieceTypeSettings
    {
        public Position GetFit(int[] c)
        {
            var result = new Position();

            result.Rotation = 1;
            for (int i = 0; i < c.Length; i++)
            {
                result.x = i;
                // holl 2 plus deep
                if (i - 1 >= 0 && i + 1 < c.Length
                    && c[i - 1] > (c[i] + 1) && (c[i] + 1) < c[i + 1])
                    return result;
                //left conner
                if(i==0 && (c[i] + 1) < c[i + 1])
                    return result;

                //right conner
                if(i==c.Length-1 && (c[i] + 1) < c[i - 1])
                    return result;
            }

            result.Rotation = 0;
            for (int i = 0; i < c.Length; i++)
            {
                result.x = i;
                if (c.Length < i + 3) break;

                if (c[i] != c[i + 1] || c[i + 1] != c[i + 2] || c[i + 2] != c[i + 3]) continue;

                if (i + 4 < c.Length && c[i] == c[i+4]) //shift it to the right a to give more options for next shape
                    result.x = i + 1;
                return result;
            }

            return result;
        }
    }

    public class PiceJ : IPieceTypeSettings
    {
        public Position GetFit(int[] c)
        {
            var result = new Position();

            result.Rotation = 1;
            for (int i = 0; i < c.Length; i++)
            {
                result.x = i;
                if (i+1 < c.Length && c[i] + 2 == c[i + 1])
                    return result;
            }

            result.Rotation = 2;
            for (int i = 0; i < c.Length; i++)
            {
                result.x = i;
                if (i+2 < c.Length && c[i] == c[i + 1] && c[i + 1] == c[i + 2]-1)
                    return result;
            }

            result.Rotation = 0;
            for (int i = 0; i < c.Length; i++)
            {
                result.x = i;
                if (c.Length < i + 2) break;

                if (c[i] != c[i + 1] || c[i + 1] != c[i + 2]) continue;
                
                return result;
            }

            result.Rotation = 3;
            for (int i = 0; i < c.Length; i++)
            {
                result.x = i;
                if (c.Length < i + 1) break;

                if (c[i] != c[i + 1]) continue;

                return result;
            }

            return result;
        }
    }

    public class Position
    {
        public int Rotation { get; set; }
        public int x { get; set; }
    }
}
