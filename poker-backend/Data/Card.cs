namespace poker_backend.Data
{
    public class Card
    {
        public int Value { get; set; }

        public bool Hidden { get; set; }

        public void Show()
        {
            Hidden = false;
        }
    }
}