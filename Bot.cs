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




            var moves = new List<MoveType>();
            //TODO: Impliment timer
            //banchmark

            //TODO: look for lowest y and select position


            //TODO: find perfect place for current pice

            //get columns from field 
            int[] columns = GetColumns();

            

            // var columns = GetColumns(myGrid);

            Position position = new Position
            {
                Rotation = 0,
                X = 0
            };

            switch (GameState.PieceType)
            {
                case PieceType.I:
                    position = PiceI.GetFit(columns);
                    break;
                case PieceType.J:
                    position = PiceJ.GetFit(columns);
                    break;
                case PieceType.L:
                    position = PiceL.GetFit(columns);
                    break;
                case PieceType.O:
                    position = PiceO.GetFit(columns);
                    break;
                case PieceType.S:
                    position = PiceS.GetFit(columns);
                    break;
                case PieceType.T:
                    position = PiceT.GetFit(columns);
                    break;
                case PieceType.Z:
                    position = PiceZ.GetFit(columns);
                    break;
            }

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

            //TODO: find perfect place for next peace



            //TODO: check if aponnent close to die

            //TODO: prioritize combo points 

            //TODO: Benchmark all methods


            return moves.ToArray();
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
