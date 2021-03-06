using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using poker_backend.Data;
using poker_backend.Managers;

namespace poker_backend.Hubs
{
    public class GameHub : Hub
    {
        private static GamesManager GamesManager = new();

        private string Connection => Context.ConnectionId;

        public async Task JoinGame(string gamename, string username, string gametype)
        {
            var game = GamesManager.JoinGame(Connection, gamename, username, (CardsTypes)Enum.Parse(typeof(CardsTypes), gametype));

            await Groups.AddToGroupAsync(Connection, gamename);

            await Clients.Caller.SendAsync("Joined", game);
            await Clients.Group(game.Name).SendAsync("Game", game);
        }

        public async Task VoteCard(int card)
        {
            var game = GamesManager.GetGameByConnection(Connection);
            if (game != null)
            {
                game.VoteCard(Connection, card);

                await Clients.Group(game.Name).SendAsync("Game", game);
                // await Clients.Group(game.Name).SendAsync("OnVotedCard", Connection, card);
            }
        }

        public async Task ShowCards()
        {
            var game = GamesManager.GetGameByConnection(Connection);
            if (game != null)
            {
                game.ShowCards();

                await Clients.Group(game.Name).SendAsync("ShowCards", game);
            }
        }

        public async Task NewRound()
        {
            var game = GamesManager.GetGameByConnection(Connection);
            if (game != null)
            {
                game.ClearVotes();

                await Clients.Group(game.Name).SendAsync("NewRound", game);
            }
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            var game = GamesManager.GetGameByConnection(Connection);
            if (game != null)
            {
                game.DeleteUser(Connection);

                await Clients.Group(game.Name).SendAsync("OnUserDeleted", Connection);
            }

            await base.OnDisconnectedAsync(exception);
        }
    }
}