namespace GameBlackJackOrBattle
{
    internal class Card
    {
        public
        Card(CardValue val, string col)
        {
            Value = val;
            Color = col;
        }
        public CardValue Value { get; set; }
        public string Color { get; set; }
        public int ValueAsInt => (int)Value;


    }
}
