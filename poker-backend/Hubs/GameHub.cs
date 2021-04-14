using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using poker_backend.Managers;

namespace poker_backend.Hubs
{
    public class GameHub : Hub
    {
        private GamesManager GamesManager = new();
        
        private string Connection => Context.ConnectionId;

        public async Task JoinGame(string gamename, string username)
        {
            var game = GamesManager.JoinGame(Connection, gamename, username);

            await Groups.AddToGroupAsync(Connection, gamename);
            
            await Clients.Group(game.Name).SendAsync("Game", game);
        }

        public async Task VoteCard(int card)
        {
            var game = GamesManager.GetGameByConnection(Connection);
            game.VoteCard(Connection, card);

            await Clients.Group(game.Name).SendAsync("OnVotedCard", Connection);
        }

        public async Task ShowCards()
        {
            var game = GamesManager.GetGameByConnection(Connection);
            game.ShowCards();
       
            await Clients.Group(game.Name).SendAsync("Game", game);
        }

        public async Task NewRound()
        {
            var game = GamesManager.GetGameByConnection(Connection);
            game.ClearVotes();
            
            await Clients.Group(game.Name).SendAsync("Game", game);
        }

        public override async Task OnDisconnectedAsync(Exception? exception)
        {
            var game = GamesManager.GetGameByConnection(Connection);
            game.DeleteUser(Connection);
            
            await Clients.Group(game.Name).SendAsync("OnUserDeleted", Connection);

            await base.OnDisconnectedAsync(exception);
        }
    }
}