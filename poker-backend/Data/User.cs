namespace poker_backend.Data
{
    public class User
    {
        public string Name { get; set; }

        public bool IsHost { get; set; }

        public Card? Card { get; set; }

        public void VoteCard(int card)
        {
            Card = new Card
            {
                Value = card,
                Hidden = true
            };
        }

        public void ShowCard()
        {
            Card?.Show();
        }
    }
}