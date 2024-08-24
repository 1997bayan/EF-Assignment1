using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Assignment1.Entities
{
        [PrimaryKey (nameof(Course_Id), nameof(Inst_Id))]
    internal class Course_instructor
    {
        public int Course_Id { get; set; }

       

        public int Inst_Id { get; set; }
        public decimal Evaluate { get; set; }


    }
}
