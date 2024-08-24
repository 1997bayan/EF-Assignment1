using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment1.Entities
{
    [PrimaryKey ( nameof(Std_Id) , nameof(Course_Id) )]
    internal class Std_Course
    {
        public int Std_Id { get; set; }
        public int Course_Id { get; set; }
        public decimal Grade { get; set; }

    }
}
