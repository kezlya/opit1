using System.Collections.Generic;
using System.Linq;
using Pirozgok.Pieces;

namespace Pirozgok
{
    public static class Helper
    {
        // Find perfect place for current pice
        public static List<Position> FindFitPositions(PieceType type, int[] columns)
        {
            List<Position> goodPositions = new List<Position>();
            switch (type)
            {
                //TODO: subcases should only represent rotations No More deep holes
                case PieceType.I:
                    var deepHolesI = PiceI.PositionsDeepHole(columns);
                    if (deepHolesI.Count != 0)
                    {
                        goodPositions.AddRange(deepHolesI);
                        //finalPosition = ChoosePosition(deepHolesI);
                        //break;
                    }

                    var flatsI = PiceI.PositionsFlat(columns);
                    if (flatsI.Count != 0)
                    {
                        goodPositions.AddRange(flatsI);
                        //finalPosition = ChoosePosition(flatsI);
                        //break;
                    }

                    var stepsI = PiceI.PositionsOneLevelStep(columns);
                    if (stepsI.Count != 0)
                    {
                        goodPositions.AddRange(stepsI);
                        //finalPosition = ChoosePosition(stepsI);
                    }
                    break;
                case PieceType.J:
                    var deepHolesJ = PiceJ.PositionsDeepHole(columns);
                    if (deepHolesJ.Count != 0)
                    {
                        goodPositions.AddRange(deepHolesJ);
                        //finalPosition = ChoosePosition(deepHolesJ);
                        //break;
                    }

                    var flatHolesJ = PiceJ.PositionsFlatHole(columns);
                    if (flatHolesJ.Count != 0)
                    {
                        goodPositions.AddRange(flatHolesJ);
                        //finalPosition = ChoosePosition(flatHolesJ);
                        //break;
                    }

                    var flatsJ = PiceJ.PositionsFlat(columns);
                    if (flatsJ.Count != 0)
                    {
                        goodPositions.AddRange(flatsJ);
                        //finalPosition = ChoosePosition(flatsJ);
                        //break;
                    }
                    var notFlatsJ = PiceJ.PositionsNotFlat(columns);
                    if (notFlatsJ.Count != 0)
                    {
                        goodPositions.AddRange(notFlatsJ);
                        //finalPosition = ChoosePosition(notFlatsJ);
                    }
                    break;
                case PieceType.L:
                    var deepHolesL = PiceL.PositionsDeepHole(columns);
                    if (deepHolesL.Count != 0)
                    {
                        goodPositions.AddRange(deepHolesL);
                        //finalPosition = ChoosePosition(deepHolesL);
                        //break;
                    }

                    var flatHolesL = PiceL.PositionsFlatHole(columns);
                    if (flatHolesL.Count != 0)
                    {
                        goodPositions.AddRange(flatHolesL);
                        //finalPosition = ChoosePosition(flatHolesL);
                        //break;
                    }

                    var flatsL = PiceL.PositionsFlat(columns);
                    if (flatsL.Count != 0)
                    {
                        goodPositions.AddRange(flatsL);
                        //finalPosition = ChoosePosition(flatsL);
                        //break;
                    }
                    var notFlatsL = PiceL.PositionsNotFlat(columns);
                    if (notFlatsL.Count != 0)
                    {
                        goodPositions.AddRange(notFlatsL);
                        //finalPosition = ChoosePosition(notFlatsL);
                    }
                    break;
                case PieceType.O:
                    var deepHolesO = PiceO.PositionsDeepHole(columns);
                    if (deepHolesO.Count != 0)
                    {
                        goodPositions.AddRange(deepHolesO);
                        //finalPosition = ChoosePosition(deepHolesO);
                        //break;
                    }

                    var stepsO = PiceO.PositionsOneLevelStep(columns);
                    if (stepsO.Count != 0)
                    {
                        goodPositions.AddRange(stepsO);
                        //finalPosition = ChoosePosition(stepsO);
                        //break;
                    }

                    var flatsO = PiceO.PositionsFlat(columns);
                    if (flatsO.Count != 0)
                    {
                        goodPositions.AddRange(flatsO);
                        //finalPosition = ChoosePosition(flatsO);
                    }
                    break;
                case PieceType.S:
                    var flatsS = PiceS.PositionsFlat(columns);
                    if (flatsS.Count != 0)
                    {
                        goodPositions.AddRange(flatsS);
                        //finalPosition = ChoosePosition(flatsS);
                        //break;
                    }

                    var verticlesS = PiceS.PositionsVerticle(columns);
                    if (verticlesS.Count != 0)
                    {
                        goodPositions.AddRange(verticlesS);
                        //finalPosition = ChoosePosition(verticlesS);
                    }
                    break;
                case PieceType.T:
                    var pointsUp = PiceT.PositionsPointUp(columns);
                    if (pointsUp.Count != 0)
                    {
                        goodPositions.AddRange(pointsUp);
                        //finalPosition = ChoosePosition(pointsUp);
                        //break;
                    }

                    var pointsDown = PiceT.PositionsPointDown(columns);
                    if (pointsDown.Count != 0)
                    {
                        goodPositions.AddRange(pointsDown);
                        //finalPosition = ChoosePosition(pointsDown);
                        //break;
                    }

                    var pointRight = PiceT.PositionsPointRight(columns);
                    if (pointRight.Count != 0)
                    {
                        goodPositions.AddRange(pointRight);
                        //finalPosition = ChoosePosition(pointRight);
                        //break;
                    }

                    var pointsLeft = PiceT.PositionsPointLeft(columns);
                    if (pointsLeft.Count != 0)
                    {
                        goodPositions.AddRange(pointsLeft);
                        //finalPosition = ChoosePosition(pointsLeft);
                    }
                    break;
                case PieceType.Z:
                    var flatsZ = PiceZ.PositionsFlat(columns);
                    if (flatsZ.Count != 0)
                    {
                        goodPositions.AddRange(flatsZ);
                        //finalPosition = ChoosePosition(flatsZ);
                        //break;
                    }

                    var verticlesZ = PiceZ.PositionsVerticle(columns);
                    if (verticlesZ.Count != 0)
                    {
                        goodPositions.AddRange(verticlesZ);
                        //finalPosition = ChoosePosition(verticlesZ);
                    }
                    break;
            }
            return goodPositions;
        }

        // Look for lowest y and select position
        public static Position ChoosePosition(List<Position> positions, int[] columns)
        {
            if (positions.Count > 1)
            {
                Position cache = positions[0];

                for (var i = 1; i < positions.Count; i++)
                {
                    if (columns[cache.X] > columns[positions[i].X])
                        cache = positions[i];
                }
                return cache;
            }

            return positions[0];
        }

        public static MoveType[] MovesForPosition(Position position, int x)
        {
            var moves = new List<MoveType>();

            //position.Rotation
            if (position.Rotation > 0)
            {
                moves.AddRange(Enumerable.Repeat(MoveType.TurnRight, position.Rotation));
            }

            var offset = (position.Rotation == 1) ? (position.Type == PieceType.I) ? 2 : 1 : 0;
            var origenX = x + offset;

            var destinationX = position.X;

            if (origenX > destinationX)
            {
                //move left
                for(int i=0;i<origenX-destinationX;i++)
                    moves.Add(MoveType.Left);

            }
            else if (origenX < destinationX)
            {
                //move right
                for (int i = 0; i < destinationX - origenX; i++)
                    moves.Add(MoveType.Right);
            }
            else
            {
                moves.Add(MoveType.Down);
            }
            return moves.ToArray();
        }

        public static Position MinimumDamagePosition(PieceType type, int[] columns)
        {
            var result = new Position
            {
                Type = type,
                Rotation = 0,
                X = 0,
            };
            int minDammage = 1000;

            int rotationMax = 0;
            switch (type)
            {
                case PieceType.O:
                    rotationMax = 1;
                    break;
                case PieceType.I:
                case PieceType.Z:
                case PieceType.S:
                    rotationMax = 2;
                    break;
                case PieceType.J:
                case PieceType.L:
                case PieceType.T:
                    rotationMax = 4;
                    break;
            }
            
            int columnsSum = columns.Sum();
            for (int r = 0; r < rotationMax; r++)
            {
                for (int i = 0; i < columns.Length; i++)
                {
                    int afterSum = columns.GetColomnsAfterWithHoles(i, r, type).Sum();
                    if (afterSum <= columnsSum) break;

                    var damage = afterSum - columnsSum;
                    if (damage < minDammage)
                    {
                        minDammage = damage;
                        result.Rotation = r;
                        result.X = i;
                    }

                    if (damage == minDammage && columns[result.X] > columns[i])
                    {
                        result.X = i;
                    }
                }
            }
            return result;
        }
    }
}
