
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




            var moves = new List<MoveType>();
            //TODO: Impliment timer

            //TODO: look for lowest y and select position


            //TODO: find perfect place for current pice
            var columns = new[] {1, 2, 3};
            Position position;
            switch (GameState.PieceType)
            {
                case PieceType.I:
                    position = new PiceI().GetFit(columns);
                    break;
                case PieceType.J:
                    position = new PiceJ().GetFit(columns);
                    break;
            }

            //position.Rotation


            //TODO: find perfect place for next peace

            //TODO: check if aponnent close to die




            return moves.ToArray();
        }

        public void Dispose()
        {
        }
    }
}
