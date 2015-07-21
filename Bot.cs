using System;
using System.Collections.Generic;
using System.IO;
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
            // for warm up
            if (GameState.Round == 1)
            {
                return new[] { MoveType.Down };
            }

            //TODO: Impliment timer banchmark

            //TODO: check if aponnent close to die

            //TODO: prioritize combo points 

            //TODO: Benchmark all methods

            //TODO: Test columsAfter


            int[] columns = Players[MatchSettings.PlayerName].Field.Columns;

            List<Position> goodPositions = Helper.FindFitPositions(GameState.PieceType, columns);

            Position finalPosition = (goodPositions.Count > 0)
                ? Helper.ChoosePosition(goodPositions, columns)
                : Helper.MinimumDamagePosition(GameState.PieceType, columns);

            return Helper.MovesForPosition(finalPosition, GameState.PiecePositionX);
        }

        public void Dispose()
        {
        }
    }
}
