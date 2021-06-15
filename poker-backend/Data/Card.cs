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


    public enum CardsTypes
    {
        NO=0,
        FIBBONACI = 1,
        POWER_OF_TWO = 2,
        POWER_OF_THREE
    }
}