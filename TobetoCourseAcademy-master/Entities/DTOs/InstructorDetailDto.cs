using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Entities.DTOs
{
    public class InstructorDetailDto :IDto
    {
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public string CourseName { get; set; }

    }
}
