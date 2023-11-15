using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concretes.EntityFramework;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        IInstructorDal _instructorDal;
        public InstructorManager(IInstructorDal instructorDal)
        {
            _instructorDal = instructorDal;
        }

        public void Add(Instructor instructor)
        {
            _instructorDal.Add(instructor);
        }

        public void Delete(Instructor instructor)
        {
            _instructorDal.Delete(instructor);
        }

        //public Instructor Get(int id)
        //{
        //    return _instructorDal.Get(i=>i.Id==id);
        //}

        public List<Instructor> GetAll()
        {
            return _instructorDal.GetAll();
        }

        public List<Instructor> GetAllByName(string name)
        {
            return _instructorDal.GetAll(i=>i.FirstName==name);
        }

        public void Update(Instructor instructor)
        {
            _instructorDal.Update(instructor);
        }

        List<Instructor> IInstructorService.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
