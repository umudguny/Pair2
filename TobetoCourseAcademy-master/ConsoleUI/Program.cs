using Business.Abstract;
using Business.Concretes;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;


IInstructorService instructorManager = new InstructorManager(new EfInstructorDal());

instructorManager.GetAll();

instructorManager.Add(new Instructor() {Id=1,FirstName = "Engin", LastName = "Demiroğ" });

foreach (var item in instructorManager.GetAll())
{
    Console.WriteLine(item.FirstName+ " " + item.LastName);
}

//Console.WriteLine( instructorManager.GetAllByName("engin"));

