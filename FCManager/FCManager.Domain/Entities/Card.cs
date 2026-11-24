namespace FCManager.Domain.Entities
{
    public class Card
    {
        public Guid Id { get; private set; }
        public CardType Type { get; private set; }
        public DateOnly Date { get; private set; }
        public string Reason { get; private set; }
        public CardStatus Status { get; private set; }
    }
}
