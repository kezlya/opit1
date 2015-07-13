
using System;
using System.Collections.Generic;
using System.IO;
using Pirozgok.Commands;

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


            var random = new Random();
            var moveValues = Enum.GetValues(typeof (MoveType));
            

            for (var i = 0; i < moveValues.Length; i++)
            {
                moves.Add((MoveType)Enum.ToObject(typeof(MoveType), random.Next(0, moveValues.Length - 1)));
            }

            return moves.ToArray();
        }

        //public List<MoveType> FindPerfectFit(PieceType piece)
        //{
        //    Field myField = Players[MatchSettings.PlayerName].Field;
        //    for (int i=0;i<myField.Width;i++)
        //    {
        //        IPieceTypeSettings.FitPosition(piece);
        //    }

        //    return new List<MoveType>();
        //}

        //private bool[] FitInColum(int[] c, PieceType pice)
        //{
        //    var result = new bool[c.Length];
        //    for (int i = 0; i < c.Length; i++)
        //    {
        //        bool fit = false;
        //        switch (pice)
        //        {
        //                case PieceType.I:
        //                if (c.Length >= i + 3)
        //                {
        //                    fit = (c[i] == c[i + 1] && c[i + 2] == c[i + 3]);
        //                }
        //                if (i - 1 >= 0 && i+1<c.Length)
        //                {
        //                    fit = (c[i - 1] > i && i < c[i + 1]);
        //                }
                        

        //        }
        //    }
        //    return result
        //}

        public void Dispose()
        {
        }

    }
}
