namespace MementoPattern
{
    public class Originator
    {
        public LedTv ledTV;

        public Memento CreateMemento()
        {
            return new Memento(ledTV);
        }

        public void SetMemento(Memento memento)
        {
            ledTV = memento.ledTV;
        }

        public string GetDetails()
        {
            return "Originator [ledTV=" + ledTV.GetDetails() + "]";
        }
    }
}
