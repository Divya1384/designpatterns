using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student()
            {
                StudentId = 1,
                StudentName = "Divya",
                StudentDepartment = "Philips"
            };

            IRepository repository1 = new StudentRepository(new FileStorageRepository());
            repository1.Save(student);

            Console.WriteLine();

            IRepository repository2 = new StudentRepository(new DatabaseStorageRepository());
            repository2.Save(student);

            Console.Read();
        }
    }
}
