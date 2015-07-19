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
            int[] columns = GetColumns();

            Position finalPosition = new Position
            {
                Rotation = 0,
                X = 0
            };
            switch (GameState.PieceType)
            {
                case PieceType.I:
                    var deepHolesI = PiceI.PositionsDeepHole(columns);
                    if (deepHolesI.Count != 0)
                    {
                        finalPosition = ChoosePosition(deepHolesI);
                        break;
                    }
                    
                    var flatsI = PiceI.PositionsFlat(columns);
                    if (flatsI.Count != 0)
                    {
                        finalPosition = ChoosePosition(flatsI);
                        break;
                    }
                    
                    var stepsI = PiceI.PositionsOneLevelStep(columns);
                    if (stepsI.Count != 0)
                    {
                        finalPosition = ChoosePosition(stepsI);
                    }
                    break;
                case PieceType.J:
                    var deepHolesJ = PiceJ.PositionsDeepHole(columns);
                    if (deepHolesJ.Count != 0)
                    {
                        finalPosition = ChoosePosition(deepHolesJ);
                        break;
                    }

                    var flatHolesJ = PiceJ.PositionsFlatHole(columns);
                    if (flatHolesJ.Count != 0)
                    {
                        finalPosition = ChoosePosition(flatHolesJ);
                        break;
                    }

                    var flatsJ = PiceJ.PositionsFlat(columns);
                    if (flatsJ.Count != 0)
                    {
                        finalPosition = ChoosePosition(flatsJ);
                        break;
                    }
                    var notFlatsJ = PiceJ.PositionsNotFlat(columns);
                    if (notFlatsJ.Count != 0)
                    {
                        finalPosition = ChoosePosition(notFlatsJ);
                    }
                    break;
                case PieceType.L:
                    var deepHolesL = PiceL.PositionsDeepHole(columns);
                    if (deepHolesL.Count != 0)
                    {
                        finalPosition = ChoosePosition(deepHolesL);
                        break;
                    }

                    var flatHolesL = PiceL.PositionsFlatHole(columns);
                    if (flatHolesL.Count != 0)
                    {
                        finalPosition = ChoosePosition(flatHolesL);
                        break;
                    }

                    var flatsL = PiceL.PositionsFlat(columns);
                    if (flatsL.Count != 0)
                    {
                        finalPosition = ChoosePosition(flatsL);
                        break;
                    }
                    var notFlatsL = PiceL.PositionsNotFlat(columns);
                    if (notFlatsL.Count != 0)
                    {
                        finalPosition = ChoosePosition(notFlatsL);
                    }
                    break;
                case PieceType.O:
                    var deepHolesO = PiceO.PositionsDeepHole(columns);
                    if (deepHolesO.Count != 0)
                    {
                        finalPosition = ChoosePosition(deepHolesO);
                        break;
                    }

                    var stepsO = PiceO.PositionsOneLevelStep(columns);
                    if (stepsO.Count != 0)
                    {
                        finalPosition = ChoosePosition(stepsO);
                        break;
                    }

                    var flatsO = PiceO.PositionsFlat(columns);
                    if (flatsO.Count != 0)
                    {
                        finalPosition = ChoosePosition(flatsO);
                    }
                    break;
                /*case PieceType.S:
                    position = PiceS.GetFit(columns);
                    break;
                case PieceType.T:
                    position = PiceT.GetFit(columns);
                    break;
                case PieceType.Z:
                    position = PiceZ.GetFit(columns);
                    break;*/
            }



            //TODO: check if aponnent close to die

            //TODO: prioritize combo points 

            //TODO: Benchmark all methods

            //TODO: Test columsAfter

            return GetMovesFromPosition(finalPosition);
        }


        private Position ChoosePosition(List<Position> positions)
        {
            return positions[0];
        }


        //TODO: refuctor to better method and do same thing got field of player 2
        private int[] GetColumns()
        {
            var myField = Players[MatchSettings.PlayerName].Field;
            var flat = myField.Grid.ToEnumerable<FieldCell>();
            var accupiedCells = flat.Where(x => x.Type == FieldCellType.Block).ToList();
            int[] columns = new int[myField.Width];

            foreach (var cell in accupiedCells)
            {
                var yy = myField.Height - cell.Y;
                if (yy > columns[cell.X]) columns[cell.X] = yy;
            }

            return columns;
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
