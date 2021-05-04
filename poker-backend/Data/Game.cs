using System;
using System.Collections.Generic;
using System.Linq;

namespace poker_backend.Data
{
    public class Game
    {
        public string Name { get; set; }

        public List<int> Cards { get; set; } = new();

        public bool Voting { get; set; }

        public Dictionary<string, User> Users { get; } = new();

        public List<GameStats> Stats { get; } = new();

        public void ClearVotes()
        {
            Voting = true;
            foreach (var user in Users)
            {
                Users[user.Key].Card = null;
            }
        }

        public bool IsUserAlreadyInGame(string connection)
        {
            return Users.ContainsKey(connection);
        }

        public void JoinUser(string connection, string username, bool isHost = false)
        {
            var user = new User
            {
                Name = username,
                IsHost = isHost,
                Card = null
            };

            Users.Add(connection, user);
        }

        public void DeleteUser(string connection)
        {
            Users.Remove(connection);
        }

        public void VoteCard(string connection, int card)
        {
            Users[connection].VoteCard(card);
        }

        public void ShowCards()
        {
            Voting = false;
            foreach (var kv in Users)
            {
                kv.Value.ShowCard();
            }

            Stats.Add(CalculateStats());
        }

        private GameStats CalculateStats()
        {
            var usersWhoVoted = Users.Where(u => u.Value.Card != null).Select(u => u.Value).ToList();

            return new GameStats
            {
                Round = Stats.LastOrDefault()?.Round+1 ?? 1,
                Votes = usersWhoVoted.Count,
                AverageVote = Math.Round(usersWhoVoted.Average(u => u.Card!.Value),1),
                Time = DateTime.Now.ToString("t")
            };
        }
    }
}