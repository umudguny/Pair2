﻿using DataAccess.Concretes;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concretes
{
    public class CategoryManager
    {
        public void Add(Category category)
        {
            //Business çalıştırılır
            AdoNetCategoryDal categoryDal = new AdoNetCategoryDal();
        }
    }
}
