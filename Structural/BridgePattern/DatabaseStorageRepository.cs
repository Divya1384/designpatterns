using System;

namespace BridgePattern
{
    public class DatabaseStorageRepository : IStorageRepository
    {
        public void Store(Student student)
        {
            Console.WriteLine($"{student.StudentName} with Id {student.StudentId} of {student.StudentDepartment} saved to the database");
        }
    }
}
