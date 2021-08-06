namespace IteratorPattern
{
    public interface IIterator
    {
        bool HasNext();

        Notification Next();
    }
}
