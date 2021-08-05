namespace BridgePattern
{
    public interface IRepository
    {
        IStorageRepository StorageRepository { get; set; }

        void Save(Student student);
    }
}
