using DataAccess.Abstract;

using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concretes.EntityFramework
{
    public class EfCourseDal : ICourseDal
    {
        public void Add(Course entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Course entity)
        {
            throw new NotImplementedException();
        }

        //public List<Course> Get(Expression<Func<Course, bool>> filter)
        //{
        //    using (TobetoAcademyContext context = new TobetoAcademyContext())
        //    {
        //        return context.Set<Course>().SingleOrDefault(filter);
        //    }
        //}

        public List<Course> GetAll(Expression<Func<Course, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Course entity)
        {
            throw new NotImplementedException();
        }
    }
}
