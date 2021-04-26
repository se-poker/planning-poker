using System;
using System.Collections.Generic;
using poker_backend.Data;

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

        public Game CreateGame(string gamename)
        {
            var game = new Game
            {
                Name = gamename
            };
            Games.Add(gamename, game);
            return game;
        }

        public Game JoinGame(string connection, string gamename, string username)
        {
            ConnectionsGames[connection] = gamename;
            var game = GetGame(gamename);
            var isHost = false;
            if (game == null)
            {
                game = CreateGame(gamename);
                isHost = true;
            }

            if (!game.IsUserAlreadyInGame(connection))
            {
                game.JoinUser(connection, username, isHost);
            }

            return game;
        }
    }
}