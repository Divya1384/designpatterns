namespace MementoPattern
{
    public class Memento
    {
        public LedTv ledTV { get; set; }

        public Memento(LedTv ledTV)
        {
            this.ledTV = ledTV;
        }

        public string GetDetails()
        {
            return "Memento [ledTV=" + ledTV.GetDetails() + "]";
        }
    }
}
