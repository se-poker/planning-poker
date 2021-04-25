namespace poker_backend.Data
{
    public class User
    {
        public string Name;

        public bool IsHost;

        public Card? Card;

        public void VoteCard(int card)
        {
            Card = new Card
            {
                Value = card,
                Hidden = false
            };
        }

        public void ShowCard()
        {
            Card?.Show();
        }
    }
}