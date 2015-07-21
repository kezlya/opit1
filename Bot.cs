using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Pirozgok.Commands;
using Pirozgok.Pieces;

namespace Pirozgok
{
    class Bot : EngineCommandReceiver, IDisposable
    {
        public MatchSettings MatchSettings { get; private set; }
        public GameState GameState { get; private set; }
        public Dictionary<string, PlayerState> Players { get; private set; }

        public Bot()
        {
            MatchSettings = new MatchSettings();
            GameState = new GameState();
            Players = new Dictionary<string, PlayerState>();

            RouteCommand<BotCommand>(ReceiveCommand);
        }

        public void Run()
        {
            Console.SetIn(new StreamReader(Console.OpenStandardInput(8192)));
            using (var parser = new Parser())
            {
                EngineCommand command;
                while ((command = parser.PollCommand(this)) != null)
                {
                    if (command.Receiver != null)
                        command.Execute();
                }
            }
        }

        public void ReceiveCommand(BotCommand command)
        {
            switch (command.Key)
            {
                case "moves":
                    var moves = MovesForRound(int.Parse(command.Value));
                    if (moves.Length == 0)
                    {
                        Console.WriteLine("no_moves");
                    }
                    else
                    {
                        Console.WriteLine("{0},drop", string.Join(",", moves).ToLower());
                    }
                    break;

                default:
                    Console.WriteLine("Invalid bot command: {0}", command.Key);
                    break;
            }
        }

        private MoveType[] MovesForRound(int milliseconds)
        {




            
            //TODO: Impliment timer
            //banchmark

            //TODO: look for lowest y and select position


            //TODO: find perfect place for current pice

            //get columns from field 
            int[] columns = Players[MatchSettings.PlayerName].Field.Columns;
            

            List<Position> goodPositions = new List<Position>();
            switch (GameState.PieceType)
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



            //TODO: check if aponnent close to die

            //TODO: prioritize combo points 

            //TODO: Benchmark all methods

            //TODO: Test columsAfter

            var finalPosition = ChoosePosition(goodPositions, columns);

            return GetMovesFromPosition(finalPosition);
        }


        private Position ChoosePosition(List<Position> positions, int[] columns)
        {
            if (positions.Count > 1)
            {
                Position cache = positions[0];
            
                for (var i=1; i < positions.Count; i++)
                {
                    if (columns[cache.X] > columns[positions[i].X])
                        cache = positions[i];
                }
                return cache;
            }
            
            if (positions.Count == 1)
            {
                return positions[0];
            }

            return new Position
            {
                Rotation = 0,
                X = 0
            };
        }

        private MoveType[] GetMovesFromPosition(Position position)
        {
            var moves = new List<MoveType>();

            //position.Rotation
            if (position.Rotation > 0)
            {
                moves.AddRange(Enumerable.Repeat(MoveType.TurnRight, position.Rotation));
            }

            var offset = (position.Rotation == 1) ? (GameState.PieceType == PieceType.I) ? 2 : 1 : 0;
            var origenX = GameState.PiecePositionX + offset;

            var destinationX = position.X;

            if (origenX > destinationX)
            {
                //move left
                moves.AddRange(Enumerable.Repeat(MoveType.Left, origenX - destinationX));

            }
            else if (origenX < destinationX)
            {
                //move right
                moves.AddRange(Enumerable.Repeat(MoveType.Right, destinationX - origenX));

            }
            else
            {
                moves.Add(MoveType.Down);
            }

            return moves.ToArray();
        }

        public void Dispose()
        {
        }
    }

    public static class ArrayExtensions
    {
        public static IEnumerable<T> ToEnumerable<T>(this Array target)
        {
            return from object item in target select (T)item;
        }
    }
}
