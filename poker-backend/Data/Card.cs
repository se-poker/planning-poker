namespace poker_backend.Data
{
    public class Card
    {
        public int Value;

        public bool Hidden;

        public void Show()
        {
            Hidden = true;
        }
        
    }
}