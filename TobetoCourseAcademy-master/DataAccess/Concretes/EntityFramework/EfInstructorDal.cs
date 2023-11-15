using Core.DataAccess.EntityFrameWork;
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
    public class EfInstructorDal :EfEntityRepositoryBase<Instructor,TobetoAcademyContext>, IInstructorDal
    {
    }  
}
