namespace Animal_Collector.Models
{
    public class CardService
    {
        private List<Card> cards = new List<Card>();

        public IReadOnlyList<Card> GetCards() => cards.AsReadOnly();

        public void AddCard(Card card)
        {
            cards.Add(card);
        }
    }
}
