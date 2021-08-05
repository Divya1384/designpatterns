namespace BridgePattern
{
    public class StudentRepository : IRepository
    {
        public IStorageRepository StorageRepository { get; set; }

        public StudentRepository(IStorageRepository storageRepository)
        {
            StorageRepository = storageRepository;
        }

        public void Save(Student student)
        {
            StorageRepository.Store(student);
        }
    }
}
