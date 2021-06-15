using System;
using System.Collections.Generic;
using poker_backend.Data;
using poker_backend.Database;

namespace poker_backend.Managers
{
    public class GamesManager
    {
        private readonly Dictionary<string, string> ConnectionsGames = new();
        private readonly Dictionary<string, Game> Games = new();

        public Game? GetGame(string gamename)
        {
            if (Games.ContainsKey(gamename))
            {
                return Games[gamename];
            }

            return null;
        }

        public Game? GetGameByConnection(string connection)
        {
            if (ConnectionsGames.ContainsKey(connection))
            {
                return GetGame(ConnectionsGames[connection]);
            }

            return null;
        }

        public Game CreateGame(string gamename, CardsTypes gameType)
        {
            var game = new Game
            {
                Name = gamename
            };
            switch (gameType)
            {
                case CardsTypes.FIBBONACI:
                    game.Cards = new List<int>() { 1, 2, 3, 5, 8, 13, 21, 34 };
                    break;
                case CardsTypes.POWER_OF_TWO:
                    game.Cards = new List<int>() { 1, 2, 4, 8, 16, 32, 64, 128 };
                    break;
                case CardsTypes.POWER_OF_THREE:
                    game.Cards = new List<int>() { 1, 3, 9, 27, 81, 243, 729, 2187};
                    break;
                default:
                    throw new Exception("INVALID CARD TYPE");
            }
            Games.Add(gamename, game);
            return game;
        }

        public Game JoinGame(string connection, string gamename, string username, CardsTypes gameType)
        {
            ConnectionsGames[connection] = gamename;
            var game = GetGame(gamename);
            var isHost = false;

            if (game == null && gameType != CardsTypes.NO)
            {
                game = CreateGame(gamename, gameType);
                isHost = true;
            }

            if (!game.IsUserAlreadyInGame(connection))
            {
                game.JoinUser(connection, username, isHost);

                var database = new Db();
                database.SaveToDatabase(username, gamename);
            }

            return game;
        }
    }
}