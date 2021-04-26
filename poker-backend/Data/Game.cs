using System;
using System.Collections.Generic;

namespace poker_backend.Data
{
    public class Game
    {
        public string Name { get; set; }

        public Dictionary<string, User> Users { get; } = new();

        public void ClearVotes()
        {
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
            foreach (var kv in Users)
            {
                kv.Value.ShowCard();
            }
        }
    }
}