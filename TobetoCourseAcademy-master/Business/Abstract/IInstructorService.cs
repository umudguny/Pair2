using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IInstructorService
    {
        List<Instructor> GetAll();
        //Instructor Get(int id);
        List<Instructor> GetAllByName(string name);

        void Add(Instructor instructor);
        void Update(Instructor instructor);
        void Delete(Instructor instructor);
        
    }
}
